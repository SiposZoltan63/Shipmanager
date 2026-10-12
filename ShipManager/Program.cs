namespace ShipManager
{
    class Program
    {
        static List<AbsztrakShips> flotta = new List<AbsztrakShips>();

        static void Main(string[] args)
        {

            flotta.Add(new KereskedelmiHajo("Titan Cargo", "TRD-01", 1200, 800, 500, 45, 500));
            flotta.Add(new HadiHajo("HMS Victory", "WAR-99", 1500, 1100, 800, 60, 350));

            bool futo = true;
            while (futo)
            {
                Console.WriteLine("\n========== SHIPMANAGER MENÜ ==========");
                Console.WriteLine("1. Flotta listázása");
                Console.WriteLine("2. Kereskedelmi műveletek (IKereskedelmi)");
                Console.WriteLine("3. Harci műveletek (IHadi)");
                Console.WriteLine("4. Flotta karbantartása (IKarbantarthato)");
                Console.WriteLine("5. Kilépés");
                Console.Write("Válassz opciót (1-5): ");

                string? valasz = Console.ReadLine();
                Console.WriteLine();

                switch (valasz)
                {
                    case "1":
                        FlottaListazas();
                        break;
                    case "2":
                        KereskedelmiMuveletek();
                        break;
                    case "3":
                        HarciMuveletek();
                        break;
                    case "4":
                        KarbantartasMuvelet();
                        break;
                    case "5":
                        futo = false;
                        Console.WriteLine("Rendszer leállítva.");
                        break;
                    default:
                        Console.WriteLine("Érvénytelen választás!");
                        break;
                }
            }
        }

        static void FlottaListazas()
        {
            Console.WriteLine("=== FLOTTA ÁLLAPOTA ===");
            for (int i = 0; i < flotta.Count; i++)
            {
                Console.Write($"[{i + 1}] ");
                flotta[i].StatuszReport();
            }
        }

        static void KereskedelmiMuveletek()
        {
            Console.WriteLine("=== KERESKEDELMI HAJÓK ===");
            for (int i = 0; i < flotta.Count; i++)
            {
                if (flotta[i] is IKereskedelmi k)
                {
                    Console.WriteLine($"[{i + 1}] {flotta[i].Nev} - Rakomány: {k.JelenlegiRakomany}/{k.MaxKapacitas} tonna");
                }
            }

            Console.Write("Válassz hajót: ");
            if (int.TryParse(Console.ReadLine(), out int idx) && idx > 0 && idx <= flotta.Count)
            {
                if (flotta[idx - 1] is IKereskedelmi kh)
                {
                    Console.Write("1-Berakodás / 2-Kirakodás: ");
                    string? opc = Console.ReadLine();
                    Console.Write("Mennyiség (tonna): ");
                    int.TryParse(Console.ReadLine(), out int t);

                    if (opc == "1") kh.Berakodas(t);
                    else if (opc == "2") kh.Kirakodas(t);
                }
                else Console.WriteLine("[HIBA] Ez a hajó nem kereskedelmi hajó!");
            }
        }

        static void HarciMuveletek()
        {
            Console.WriteLine("=== HADI HAJÓK ===");
            for (int i = 0; i < flotta.Count; i++)
            {
                if (flotta[i] is IHadi h)
                {
                    Console.WriteLine($"[{i + 1}] {flotta[i].Nev} - Fegyvererő: {h.FegyverzetEro}");
                }
            }

            Console.Write("Válassz hajót: ");
            if (int.TryParse(Console.ReadLine(), out int idx) && idx > 0 && idx <= flotta.Count)
            {
                if (flotta[idx - 1] is IHadi hh)
                {
                    Console.Write("1-Tüzelés / 2-Pajzs aktiválás: ");
                    string? opc = Console.ReadLine();

                    if (opc == "1") hh.Tuzeles();
                    else if (opc == "2") hh.PajzsAktivalas();
                }
                else Console.WriteLine("[HIBA] Ez a hajó nem hadi hajó!");
            }
        }

        static void KarbantartasMuvelet()
        {
            Console.WriteLine("=== TELJES FLOTTA KARBANTARTÁSA ===");
            foreach (var hajo in flotta)
            {
                hajo.Karbantartas();
            }
        }
    }
}
