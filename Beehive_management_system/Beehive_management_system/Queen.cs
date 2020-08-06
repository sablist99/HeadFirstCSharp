using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_management_system
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber = 0;
        public Queen(Worker[] workers, double weightMg) : base(weightMg)
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
            double honeyConsumed = HoneyConsumptionRate();

            shiftNumber++;
            string report = "Отчет для смены №" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                honeyConsumed += workers[i].HoneyConsumptionRate();
                if (workers[i].DidYouFinish())
                    report += "Рабочий №" + (i + 1) + " закончил работу\r\n";
                if (string.IsNullOrEmpty(workers[i].currentJob))
                    report += "Рабочий №" + (i + 1) + " не работает\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                    report += "Рабочий №" + (i + 1) + " выполняет '" + workers[i].currentJob + "' еще " + workers[i].ShiftsLeft + " смен\r\n";
                else
                    report += "Рабочий №" + (i + 1) + " закончит '" + workers[i].currentJob + "' после этой смены\r\n";
            }
            report += "За смену было съедено " + honeyConsumed + " меда\r\n";
            return report;
        }
    }
}
