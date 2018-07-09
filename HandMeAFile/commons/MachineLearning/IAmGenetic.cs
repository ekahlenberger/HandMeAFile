using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace org.ek.HandMeAFile.commons.MachineLearning
{
    public interface IAmGenetic<TThis, out TFitness> where TThis : IAmGenetic<TThis, TFitness>
    {
        TFitness Fitness { get; }
        Task CalcFitness();
        [Pure]
        Task<TThis> Mutate(double mutationStrength);
        [Pure]
        Task<TThis> Recombine(TThis partner);
    }
}