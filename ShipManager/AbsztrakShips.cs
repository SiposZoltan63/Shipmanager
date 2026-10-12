using System;
using System.Collections.Generic;
using System.Text;

namespace ShipManager
{
    public abstract class AbsztrakShips : IKarbantarthato
    {
        public int Suly { get; set; }
        public string? Azonosito { get; set; }
        public string? Nev { get; set; }
        public int Uzemanyagszint { get; set; }
        public int Maxsebesseg { get; set; }
        public int Aktualissebesseg { get; set; }
        public int Onsuly { get; set; }

        public AbsztrakShips(int suly, int onsuly, int uzemanyagszint, int maxsebesseg, string? nev = null, string? azonosito = null)
        {
            Suly = suly;
            Onsuly = onsuly;
            Uzemanyagszint = uzemanyagszint;
            Maxsebesseg = maxsebesseg;
            Nev = nev;
            Azonosito = azonosito;
        }

        public abstract void Karbantartas();
        public abstract void StatuszReport();
    }
}
