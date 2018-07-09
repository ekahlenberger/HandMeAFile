using System.Threading.Tasks;

namespace org.ek.HandMeAFile.commons.MachineLearning
{
    public interface ICanModifyTheGeneticParameters<T> : IConfigureGeneticParameters
    {
        Task AdjustParameters(T[] currentPopulation);
    }
}