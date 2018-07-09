using System.Collections.Concurrent;

namespace org.ek.HandMeAFile.commons.Extensions
{
    public static class ConcurrentQueueExtensions
    {
        public static void Clear<T>(this ConcurrentQueue<T> cq)
        {
            if (cq.IsNullOrEmpty()) return;

            while (cq.Count > 0)
                cq.TryDequeue(out _);
        }
    }
}