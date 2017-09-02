namespace DiskSchedulingAlgorithms.Algorithms
{
    using System;
    using System.Collections.Generic;

    class SstfSchedule : IScheduleStrategy
    {
        public string GetName()
        {
            return "Sstf";
        }
        public int ReadNext(List<int> readRequest, int previousRead, ref bool direction)
        {
            int closestToPrevious = 5000000;
            int closestPos = -1;
            foreach (int req in readRequest)
            {
                int distance = Math.Abs(previousRead - req);
                if (distance >= closestToPrevious)
                {
                    continue;
                }
                closestToPrevious = distance;
                closestPos = req;
            }

            return closestPos;
        }
    }
}
