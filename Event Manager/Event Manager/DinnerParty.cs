using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Manager
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }


        public DinnerParty (int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal CCOBPP;
            if (HealthyOption)
                CCOBPP = 5.00M;
            else
                CCOBPP = 20.00M;
            return CCOBPP;
        }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += CalculateCostOfBeveragesPerPerson() * NumberOfPeople;
                if (HealthyOption)
                    totalCost *= 0.95M;
                return totalCost;
            }
        }
    }
}
