﻿namespace org.ek.HandMeAFile.commons.MachineLearning
{
    public interface IConfigureGeneticParameters
    {
        /// <summary>
        /// Desired population size for each generation
        /// </summary>
        int PopulationCount { get; }
        /// <summary>
        /// Quota of best indivuals used for recombination and mutation
        /// </summary>
        /// <remarks>between 0 ... 1</remarks>
        double SelectionQuota { get; }
        /// <summary>
        /// Quota (in relation to PopulationCount) of best individuals from selection that are directly taken over into the next generation
        /// </summary>
        /// <remarks>between 0 ... 1</remarks>
        double EliteQuota { get; }
        /// <summary>
        /// Quota (in relation to PopulationCount) of individuals generated by recombination from selection
        /// </summary>
        /// <remarks>between 0 ... 1</remarks>
        double RecombinationQuota { get; }
        /// <summary>
        /// Quota (in relation to PopulationCount) of individuals generated by mutation from selection
        /// </summary>
        /// <remarks>between 0 ... 1</remarks>
        double MutationQuota { get; }
        /// <summary>
        /// Determines the strength of mutation for each mutated individual
        /// </summary>
        /// <remarks>between 0 ... 1</remarks>
        double MutationStrength { get; }
        GeneticAlgoOptimizationDirection OptimizationDirection { get; }
    }
}