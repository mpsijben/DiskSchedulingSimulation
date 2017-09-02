namespace DiskSchedulingAlgorithms.Algorithms
{
    using System.Collections.Generic;
    using System.Linq;

    class CLookSchedule : IScheduleStrategy
    {
        public string GetName()
        {
            return "CLook";
        }
        public int ReadNext(List<int> readRequest, int previousRead, ref bool direction)
        {
            int readValue = this.GetReadValue(readRequest, previousRead, direction);


            if (readValue == 100)
            {
                readValue = readRequest.Min();
            }
            if (readValue == 0)
            {
                readValue = readRequest.Max();
            }

            return readValue;
        }


        private int GetReadValue(List<int> readRequest, int previousRead, bool direction)
        {
            List<int> sortedRequest = readRequest.OrderBy(i => direction ? i : -i).ToList();
            int readValue = direction ? 100 : 0;
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
            return readValue;
        }
    }
}
