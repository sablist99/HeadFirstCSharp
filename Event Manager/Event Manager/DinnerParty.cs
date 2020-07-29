﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Manager
{
    class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty (int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        private decimal calculateCostOfDecoration()
        {
            decimal CCOD;
            if (FancyDecorations)
                CCOD = (NumberOfPeople * 15.00M) + 50M;
            else
                CCOD = (NumberOfPeople * 7.50M) + 30M;
            return CCOD;
        }

        private decimal calculateCostOfBeveragesPerPerson()
        {
            decimal CCOBPP;
            if (HealthyOption)
                CCOBPP = 5.00M;
            else
                CCOBPP = 20.00M;
            return CCOBPP;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = calculateCostOfDecoration();
                totalCost += ((calculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                    totalCost *= 0.95M;
                return totalCost;
            }
        }
    }
}