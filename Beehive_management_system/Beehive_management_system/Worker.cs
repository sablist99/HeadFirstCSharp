using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_management_system
{
    class Worker
    {
        private string[] jobsICanDo;
        private string currentJob = "";
        public string CurrentJob{ get { return currentJob; } }
        private int shiftsToWork;
        private int shiftsWorked;

        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string job, int countOfShift)
        {
            if (!string.IsNullOrEmpty(currentJob))
                return false;
            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (job.Equals(jobsICanDo[i]))
                {
                    currentJob = job;
                    shiftsToWork = countOfShift;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;
        }

        public bool DidYouFinish()
        {
            if (string.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
                return false;
        }

        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }
    }
}
