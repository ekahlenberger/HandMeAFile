using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using org.ek.HandMeAFile.commons.Tools;

namespace org.ek.HandMeAFile.commons.MachineLearning
{
    public class GeneticAlgo<TGenome,TFitness> : IEvolvePopulations<TGenome> where TGenome : IAmGenetic<TGenome, TFitness>
    {
        private readonly IConfigureGeneticParameters m_parameters;
        private readonly ICanModifyTheGeneticParameters<TGenome> m_parameterModifier;
        private readonly ICreateGenomes<TGenome, TFitness> m_genomeCreator;
        private readonly IComparer<TFitness> m_fitnessComparer;
        private TGenome[] m_currentPopulation;
        private readonly Random m_random = new CryptoRandom();

        public GeneticAlgo(ICanModifyTheGeneticParameters<TGenome> parameters,
                        [NotNull] ICreateGenomes<TGenome, TFitness> genomeCreator,
                        [CanBeNull] IComparer<TFitness> fitnessComparer)
        {
            if (parameters == null) throw new ArgumentNullException(nameof(parameters));
            if (genomeCreator == null) throw new ArgumentNullException(nameof(genomeCreator));

            m_parameters = parameters;
            m_parameterModifier = parameters;
            m_genomeCreator = genomeCreator;
            m_fitnessComparer = fitnessComparer;
        }

        public GeneticAlgo(IConfigureGeneticParameters parameters, ICreateGenomes<TGenome, TFitness> genomeCreator, [CanBeNull] IComparer<TFitness> fitnessComparer)
        {
            if (genomeCreator == null) throw new ArgumentNullException(nameof(genomeCreator));
            m_parameters = parameters;
            m_genomeCreator = genomeCreator;
            m_fitnessComparer = fitnessComparer;
        }
        public TGenome Fittest { get; private set; }
        //public double AverageFitness { get; private set; }
        //public double StandardDeriviation { get; private set; }
        public void Evolve(CancellationToken token)
        {
            if (m_currentPopulation == null)
            {
                m_currentPopulation = m_genomeCreator.Create(m_parameters.PopulationCount, token);
                CalculateAllFitnessOfPopulation();
            }

            TGenome[] selection = Selection(m_currentPopulation, token);
            TGenome[] newBasePopulation = Task.WhenAll(
                GetElite(selection, token),
                Recombine(selection, token),
                Mutate(selection, token)).Result.SelectMany(t => t).ToArray();

            int missingPopCount = m_parameters.PopulationCount - newBasePopulation.Length;
            TGenome[] commonIndividuals = GetRandomIndividualsOfPopulation(m_currentPopulation, missingPopCount, token);

            m_currentPopulation = newBasePopulation.Concat(commonIndividuals).ToArray();

            CalculateAllFitnessOfPopulation();
            Fittest = GetOrderedPopulation(m_currentPopulation).First();
            //AverageFitness = m_currentPopulation.Sum(g => g.Fitness) / m_currentPopulation.Length;
            //StandardDeriviation = m_currentPopulation.Sum(g => Math.Pow(g.Fitness - Fittest.Fitness, 2)) / m_currentPopulation.Length;
        }
        private TGenome[] Selection(TGenome[] population, CancellationToken token)
        {
            return GetOrderedPopulation(population).Take((int)(population.Length * m_parameters.SelectionQuota)).ToArray();
        }
        private Task<TGenome[]> GetElite(TGenome[] selection, CancellationToken token)
        {
            return Task.Run(() => GetOrderedPopulation(selection).Take((int)(m_parameters.PopulationCount * m_parameters.EliteQuota)).ToArray(), token);
        }
        private async Task<TGenome[]> Mutate(TGenome[] selection, CancellationToken token)
        {
            List<Task<TGenome>> tasks = new List<Task<TGenome>>();
            int count = (int)(m_parameters.PopulationCount * m_parameters.MutationQuota);
            for (int i = 0; i < count; i++)
            {
                TGenome selectedGenome = selection[m_random.Next(0, selection.Length - 1)];
                tasks.Add(selectedGenome.Mutate(m_parameters.MutationStrength));
                token.ThrowIfCancellationRequested();
            }
            List<TGenome> mutatedIndivuals = new List<TGenome>();
            foreach (Task<TGenome> mutationTask in tasks)
            {
                mutatedIndivuals.Add(await mutationTask);
                token.ThrowIfCancellationRequested();
            }
            return mutatedIndivuals.ToArray();
        }
        private Task<TGenome[]> Recombine(TGenome[] selection, CancellationToken token)
        {
            return Task.Run(() =>
            {
                int recombCount = (int)(m_parameters.RecombinationQuota * m_parameters.PopulationCount);
                List<Task<TGenome>> recombinations = new List<Task<TGenome>>();
                for (var i = 0; i < recombCount; i++)
                {
                    recombinations.Add(SingleRecombine(selection));
                }
                // ReSharper disable once CoVariantArrayConversion
                Task.WaitAll(recombinations.ToArray(), token);
                return recombinations.Select(t => t.Result).ToArray();
            }, token);
        }
        private Task<TGenome> SingleRecombine(TGenome[] selection)
        {
            int fatherIdx = m_random.Next(0, selection.Length - 1);
            int motherIdx = -1;
            while (motherIdx == -1 || motherIdx == fatherIdx)
                motherIdx = m_random.Next(0, selection.Length);

            TGenome father = selection[fatherIdx];
            TGenome mother = selection[motherIdx];

            return father.Recombine(mother);
        }
        private void CalculateAllFitnessOfPopulation()
        {
            List<Task> tasks = new List<Task>();
            foreach (TGenome individual in m_currentPopulation)
                tasks.Add(individual.CalcFitness());
            if (m_parameterModifier == null)
                Task.WaitAll(tasks.ToArray());
            else
                Task.WhenAll(Task.WhenAll(tasks), m_parameterModifier.AdjustParameters(m_currentPopulation)).Wait();
        }
        private TGenome[] GetRandomIndividualsOfPopulation(TGenome[] population, int count, CancellationToken token)
        {
            return population.OrderBy(p => m_random.Next()).Take(count).ToArray();
        }
        private IOrderedEnumerable<TGenome> GetOrderedPopulation(TGenome[] population)
        {
            if (m_parameters.OptimizationDirection == GeneticAlgoOptimizationDirection.Up)
                return population.OrderByDescending(g => g.Fitness,m_fitnessComparer);
            return population.OrderBy(g => g.Fitness,m_fitnessComparer);
        }
    }
}