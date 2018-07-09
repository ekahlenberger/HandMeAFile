using System;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.commons.WMI
{
    public class Partition
    {
        public string Name { get; }
        public uint Index { get; }
        public uint DiskIndex { get; }
        public bool BootPartition { get; }
        public ulong Size { get; }

        public Partition([NotNull] string name, uint index, uint diskIndex, bool bootPartition, ulong size)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Index = index;
            DiskIndex = diskIndex;
            BootPartition = bootPartition;
            Size = size;
        }
    }
}