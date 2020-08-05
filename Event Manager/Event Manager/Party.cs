using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Manager
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        private decimal calculateCostOfDecoration()
        {
            decimal CCOD;
            if (FancyDecorations)
                CCOD = (NumberOfPeople * 15.00M) + 50M;
            else
                CCOD = (NumberOfPeople * 7.50M) + 30M;
            return CCOD;
        }

        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = calculateCostOfDecoration();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;

                if (NumberOfPeople > 12)
                    totalCost += 100;

                return totalCost;
            }
        }
    }
}
