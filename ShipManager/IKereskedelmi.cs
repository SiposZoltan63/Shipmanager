using System;
using System.Collections.Generic;
using System.Text;

namespace ShipManager
{
    public interface IKereskedelmi
    {
        int MaxKapacitas { get; set; }
        int JelenlegiRakomany { get; set; }
        bool Berakodas(int tonna);
        bool Kirakodas(int tonna);
    }
    
}
