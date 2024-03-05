using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_lab3
{
    internal class Lodgings : Flat, IRent
    {

        int bookedMonths;

        public Lodgings(double area, int roomsCount, int unitPrice) : base(area, roomsCount, unitPrice)
        {
            this.bookedMonths = 0;
            this.inhabitantsCount = 0;
            this.area = area;
            this.roomsCount = roomsCount;
            this.unitPrice = unitPrice;
        }

        public bool Book(int months)
        {
            if (!this.IsBooked())
            {
                this.bookedMonths = months;
                return true;
            }
            return false;
        }

        public int GetCost(int months)
        {
            return months * this.TotalValue() / 240 / this.inhabitantsCount;
        }

        public bool IsBooked()
        {
            if (this.bookedMonths == 0)
            {
                return false;
            }
            return true;
        }

        public override bool moveIn(int newInhabitants) //tobb problema a feltételek kombinációjának ellenőrzésénél
        {
            if (IsBooked())
            {
                int maxInhabitants = this.roomsCount * 8;
                if (newInhabitants <= maxInhabitants)
                {

                    if ((this.area / newInhabitants) == 2)
                    {
                        this.inhabitantsCount += newInhabitants;
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString()+$",{this.bookedMonths}";
        }
    }
}
