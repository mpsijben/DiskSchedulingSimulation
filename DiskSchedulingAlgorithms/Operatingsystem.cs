using System.Collections.Generic;

namespace DiskSchedulingAlgorithms
{
    class Operatingsystem
    {
        private IScheduleStrategy scheduleStrategy;
        private int previousRead;
        private bool direction;

        public List<int> AlreadyRead { get; set; }
        public List<int> ReadRequests { get; private set; }
        public Operatingsystem()
        {
            this.ReadRequests = new List<int>();
            this.AlreadyRead = new List<int>();
            this.previousRead = 0;
            this.direction = true;
        }

        public void Reset()
        {
            this.ReadRequests.Clear();
            this.AlreadyRead.Clear();
            this.previousRead = 0;
            this.direction = true;
        }

        public void SetStartHeader(int header)
        {
            this.AlreadyRead.Add(header);
        }

        public void SetPreviousRead(int read)
        {
            this.previousRead = read;
        }
        
        public void AddScheduleStrategy(IScheduleStrategy algoritmStrat)
        {
            this.scheduleStrategy = algoritmStrat;
        }


        public void AddReadRequest(int id)
        {
            this.ReadRequests.Add(id);
        }

        public void ReadNext()
        {
            this.previousRead = this.scheduleStrategy.ReadNext(this.ReadRequests, this.previousRead, ref this.direction);
            
            this.ReadRequests.Remove(this.previousRead);
            this.AlreadyRead.Add(this.previousRead);
        }
    }
}
