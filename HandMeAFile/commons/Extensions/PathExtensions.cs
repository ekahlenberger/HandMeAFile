using System.Collections.Generic;
using System.Linq;
using org.ek.HandMeAFile.commons.Tools;

namespace org.ek.HandMeAFile.commons.Extensions
{
    public static class PathExtensions
    {
        public static Path FindLargestCommon(this IEnumerable<Path> paths)
        {
            Dictionary<Path, Path[]> ancestors = paths.ToDictionary(p => p, p => new[] { p }.Concat(p.GetAncestors()).ToArray());
            if (ancestors.None()) return null;
            if (ancestors.Count == 1) return ancestors.Single().Key;
            int  maxIndex              = ancestors.Min(kvp => kvp.Value.Length);
            Path largestCommonAncestor = null;
            for (int i = 1; i <= maxIndex; i++)
            {
                Path[] testAncestors     = ancestors.Select(kvp => kvp.Value[kvp.Value.Length - i]).ToArray();
                Path[] distinctAncestors = testAncestors.Distinct().Take(2).ToArray();
                if (distinctAncestors.Length == 1)
                    largestCommonAncestor = distinctAncestors.Single();
                else
                    return largestCommonAncestor;
            }
            return largestCommonAncestor;
        }
    }
}