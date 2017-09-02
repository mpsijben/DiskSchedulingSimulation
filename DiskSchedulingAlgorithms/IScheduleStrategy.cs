using System.Collections.Generic;

namespace DiskSchedulingAlgorithms
{
    public interface IScheduleStrategy
    {
        string GetName();
        int ReadNext(List<int> readRequest, int previousRead, ref bool direction);
    }
}
