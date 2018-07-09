using System.Threading;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.commons.MachineLearning
{
    public interface ICreateGenomes<out TThis, TFitness> where TThis : IAmGenetic<TThis, TFitness>
    {
        [NotNull]TThis[] Create(int count, CancellationToken token);
    }
}