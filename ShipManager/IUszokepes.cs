using System;
using System.Collections.Generic;
using System.Text;

namespace ShipManager
{
    public interface IUszokepes
    {
        public int suly { get; set; }
        public int onsuly { get; set; }
        public int uzemanyagszint { get; set; }
        public int maxsebesseg { get; set; }
        public IUszokepes(int suly, int onsuly, int uzemanyagszint, int maxsebesseg)
        {
            this.suly = suly;
            this.onsuly = onsuly;
            this.uzemanyagszint = uzemanyagszint;
            this.maxsebesseg = maxsebesseg;
        }
    }
}
