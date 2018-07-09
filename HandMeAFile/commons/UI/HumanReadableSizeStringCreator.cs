using System;
using System.Linq;

namespace org.ek.HandMeAFile.commons.UI
{
    public class HumanReadableSizeStringCreator : ICreateHumanReadableSizeStrings
    {

        public string Create(ulong size)
        {
            string[] sizes = {"B", "KiB", "MiB", "GiB", "TiB"};
            decimal len = size;
            int order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len = len / 1024;
            }
            string number = $"{len:0.00}";
            number = number.Substring(0, Math.Min(number.Count(c => c == ',' || c == '.') + 3, number.Length));
            number = number.TrimEnd('.', ',');
            return $"{number} {sizes[order]}";
        }
    }
}