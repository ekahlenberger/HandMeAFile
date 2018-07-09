using System.Collections.Generic;

namespace org.ek.HandMeAFile.commons.WMI
{
    public interface IReadSystemsPartitions
    {
        IEnumerable<Partition> ReadPartitions();
    }
}