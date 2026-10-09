using System;
using System.Collections.Generic;
using System.Text;

namespace ShipManager
{
    public interface IUszokepes
    {

        public IUszokepes(int suly, int onsuly, int uzemanyagszint, int maxsebesseg)
        {
            this.suly = suly;
            this.onsuly = onsuly;
            this.uzemanyagszint = uzemanyagszint;
            this.maxsebesseg = maxsebesseg;
        }
    }
}
