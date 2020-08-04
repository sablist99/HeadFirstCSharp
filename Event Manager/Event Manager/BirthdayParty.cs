using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Manager
{
    class BirthdayParty
    {
        private const int CostOfFoodPerPerson = 25;


        private int NumberOfPeople;
        private bool FancyDecorations;
        private string CakeWriting;
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40M + ActualLength * .25M;
                else
                    cakeCost = 75M + ActualLength * .25M;
                return totalCost + cakeCost;
            }
        }
        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }
        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWriting.Length;
            }
        }

        public int getNumberOfPeople() { return NumberOfPeople; }
        public bool getFancyDecorations() { return FancyDecorations; }
        public string getCakeWriting() { return CakeWriting; }

        public void setNumberOfPeople(int numberOfPeople) { NumberOfPeople = numberOfPeople; }
        public void setFancyDecorations(bool fancyDecorations) { FancyDecorations = fancyDecorations; }
        public void setCakeWriting(string cakeWriting)
        {
            CakeWriting = cakeWriting;

        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }

        private int CakeSize()
        {
            if (NumberOfPeople < 5)
                return 8;
            else
                return 16;
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            return costOfDecorations;
        }


    }
}
