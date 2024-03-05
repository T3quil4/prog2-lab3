using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_lab3
{
    internal class Tarolo : IComparable
    {

        public enum Besorolas
        {
            KurvaNehez,
            Nehez,
            EbbeMegMehet
        }
        string cimke;
        int suly;
        Besorolas besor;

        public Tarolo(string cimke, int suly, Besorolas besor)
        {
            this.cimke = cimke;
            this.suly = suly;
            this.besor = besor;
        }

        public string Cimke { get {  return cimke; } }

        public int CompareTo(object? obj)
        {
            if (obj is Tarolo)
            {
                Tarolo masikTarolo = obj as Tarolo;
                if (masikTarolo.suly>this.suly)
                {
                    return 1;
                }

                if (masikTarolo.suly==this.suly)
                {
                    return 0;
                }

                if (masikTarolo.suly<this.suly)
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
