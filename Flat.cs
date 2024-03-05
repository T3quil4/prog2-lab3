using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_lab3
{
    internal abstract class Flat : IRealEstate
    {

        protected double area;
        protected int roomsCount;
        protected int inhabitantsCount;
        protected int unitPrice;

        protected Flat(double area, int roomsCount, int inhabitantsCount, int unitPrice)
        {
            this.area = area;
            this.roomsCount = roomsCount;
            this.inhabitantsCount = inhabitantsCount;
            this.unitPrice = unitPrice;
        }

        protected Flat(double area, int roomsCount, int unitPrice)
        {
            this.area = area;
            this.roomsCount = roomsCount;
            this.unitPrice = unitPrice;
        }

        public int GetInhabitantsCount()
        {
            return this.inhabitantsCount;
        }

        public abstract bool moveIn(int newInhabitants);
        public int TotalValue()
        {
            return (int)(this.unitPrice * this.area);
        }

        public override string ToString()
        {
            return $"{this.roomsCount},{this.inhabitantsCount},{this.area},{this.unitPrice}";
        }
    }
}
