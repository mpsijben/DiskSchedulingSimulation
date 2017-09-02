namespace DiskSchedulingAlgorithms.Algorithms
{
    using System.Collections.Generic;
    using System.Linq;

    class FcfsSchedule : IScheduleStrategy
    {
        public string GetName()
        {
            return "Fcfs";
        }

        public int ReadNext(List<int> readRequest, int previousRead, ref bool direction)
        {
            return readRequest.First();
        }

    }
}
