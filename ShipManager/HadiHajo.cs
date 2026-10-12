using System;
using System.Collections.Generic;
using System.Text;

namespace ShipManager
{
    public class HadiHajo : AbsztrakShips, IHadi
    {
        public int FegyverzetEro { get; set; }

        public HadiHajo(string nev, string azonosito, int suly, int onsuly, int uzemanyag, int maxsebesseg, int fegyverzetEro)
            : base(suly, onsuly, uzemanyag, maxsebesseg, nev, azonosito)
        {
            FegyverzetEro = fegyverzetEro;
        }

        public void Tuzeles()
        {
            Console.WriteLine($"[HARC] {Nev} tüzet nyitott az ellenségre! Sebzés: {FegyverzetEro} pont!");
        }

        public void PajzsAktivalas()
        {
            Console.WriteLine($"[VÉDELEM] {Nev} energiapajzsai bekapcsolva!");
        }

        public override void Karbantartas()
        {
            Console.WriteLine($"[KARBANTARTÁS] A(z) {Nev} hadi hajó ágyúinak kalibrációja és páncélzatának átvizsgálása kész.");
        }

        public override void StatuszReport()
        {
            Console.WriteLine($"[HADI HAJÓ] {Nev} ({Azonosito}) | Üzemanyag: {Uzemanyagszint}L | Fegyverzet ereje: {FegyverzetEro}");
        }
    }
}
