using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_management_system
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber = 0;
        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string work, int countOfShift)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(work, countOfShift))
                    return true;
            return false;
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = "Отчет для смены №" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                    report += "Рабочий №" + (i + 1) + " закончил работу\r\n";
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Рабочий №" + (i + 1) + " не работает\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                    report += "Рабочий №" + (i + 1) + " выполняет '" + workers[i].CurrentJob + "' еще " + workers[i].ShiftsLeft + " смен\r\n";
                else
                    report += "Рабочий №" + (i + 1) + " закончит '" + workers[i].CurrentJob + "' после этой смены\r\n";
            }
            return report;
        }
    }
}
