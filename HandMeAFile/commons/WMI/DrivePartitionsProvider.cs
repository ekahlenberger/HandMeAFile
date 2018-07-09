using System.Collections.Generic;
using System.Linq;
using System.Management;

namespace org.ek.HandMeAFile.commons.WMI
{
    public class DrivePartitionsReader : IReadSystemsPartitions
    {
        public IEnumerable<Partition> ReadPartitions()
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskPartition"))
            {
                return searcher.Get().OfType<ManagementBaseObject>().Select(m => new Partition(
                                                                                               (string) m["Name"],
                                                                                               (uint) m["Index"],
                                                                                               (uint) m["DiskIndex"],
                                                                                               (bool) m["BootPartition"],
                                                                                               (ulong) m["Size"]
                                                                                              ));
            }
        }
    }
}