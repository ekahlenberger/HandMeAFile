using System.Threading;

namespace org.ek.HandMeAFile.commons.MachineLearning
{
    public interface IEvolvePopulations<T>
    {
        T Fittest { get; }
        //double AverageFitness { get; }
        //double StandardDeriviation { get; }
        void Evolve(CancellationToken token);
    }
}