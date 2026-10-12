using System;
using System.Collections.Generic;
using System.Text;

namespace ShipManager
{
    public class KereskedelmiHajo : AbsztrakShips, IKereskedelmi
    {
        public int MaxKapacitas { get; set; }
        public int JelenlegiRakomany { get; set; }

        public KereskedelmiHajo(string nev, string azonosito, int suly, int onsuly, int uzemanyag, int maxsebesseg, int maxKapacitas)
            : base(suly, onsuly, uzemanyag, maxsebesseg, nev, azonosito)
        {
            MaxKapacitas = maxKapacitas;
            JelenlegiRakomany = 0;
        }

        public bool Berakodas(int tonna)
        {
            if (JelenlegiRakomany + tonna <= MaxKapacitas)
            {
                JelenlegiRakomany += tonna;
                Console.WriteLine($"[SIKER] {tonna} tonna berakodva a(z) {Nev} hajóra.");
                return true;
            }
            Console.WriteLine($"[HIBA] A(z) {Nev} nem tud ennyi árut fogadni! Kapacitás túllépés!");
            return false;
        }

        public bool Kirakodas(int tonna)
        {
            if (JelenlegiRakomany >= tonna)
            {
                JelenlegiRakomany -= tonna;
                Console.WriteLine($"[SIKER] {tonna} tonna kirakodva a(z) {Nev} hajóról.");
                return true;
            }
            Console.WriteLine($"[HIBA] Nincs ennyi rakomány a(z) {Nev} hajón!");
            return false;
        }

        public override void Karbantartas()
        {
            Console.WriteLine($"[KARBANTARTÁS] A(z) {Nev} kereskedelmi hajó raktér-ellenőrzése és motorolaj-cseréje elvégezve.");
        }

        public override void StatuszReport()
        {
            Console.WriteLine($"[KERESKEDELMI] {Nev} ({Azonosito}) | Üzemanyag: {Uzemanyagszint}L | Rakomány: {JelenlegiRakomany}/{MaxKapacitas} tonna");
        }
    }
}
