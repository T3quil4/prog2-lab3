using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_lab3
{
    internal class FamilyApartment : Flat
    {
        int childrenCount;
        public FamilyApartment(double area, int roomsCount, int unitPrice) : base(area, roomsCount, unitPrice)
        {
            this.childrenCount = 0;
            this.inhabitantsCount = 0;
            this.area = area;
            this.roomsCount = roomsCount;
            this.unitPrice = unitPrice;
        }

        bool ChildIsBorn()
        {
            if (this.inhabitantsCount-this.childrenCount>=2)
            {
                return false;
            }
            return false;
        }

        public override bool moveIn(int newInhabitants)
        {
            throw new NotImplementedException();
        }
    }
}
