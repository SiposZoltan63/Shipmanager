using System;
using System.Collections.Generic;
using System.Text;

namespace ShipManager
{
    public abstract class AbsztrakShips : IKarbantarthato, IUszokepes
    {
        public int suly { get; set; }
        public string? azonosito { get; set; }
        public string? nev { get; set; }
        public int uzemanyagszint { get; set; }
        public int maxsebesseg { get; set; }
        public int aktualissebesseg { get; set; }
        public int onsuly { get; set; }
        public IUszokepes(int suly,int onsuly,int uzemanyagszint,int maxsebesseg)
        {
            this.suly = suly;
            this.onsuly = onsuly;
            this.uzemanyagszint = uzemanyagszint;
            this.maxsebesseg = maxsebesseg;
        }
    }
}
