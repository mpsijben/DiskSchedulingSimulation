namespace DiskSchedulingAlgorithms.Algorithms
{
    using System.Collections.Generic;
    using System.Linq;

    class ScanSchedule : IScheduleStrategy
    {
        public string GetName()
        {
            return "Scan";
        }
        public int ReadNext(List<int> readRequest, int previousRead, ref bool direction)
        {
            bool tempDir = direction;
            int readValue = direction ? 100 : 0;
            List<int> sortedRequest = readRequest.OrderBy(i => tempDir ? i : -i).ToList();

            foreach (int req in sortedRequest)
            {
                if (direction)
                {
                    if (req < previousRead)
                    {
                        continue;
                    }
                    readValue = req;
                    break;
                }
                if (req > previousRead)
                {
                    continue;
                }
                readValue = req;
                break;
            }
            if (readValue == 100 || readValue == 0)
            {
                direction = !direction;
            }

            return readValue;
        }
    }
}
