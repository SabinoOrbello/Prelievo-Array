using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelievo_Array
{
    internal class ContoCorrente
    {
        public string NumeroConto {  get; set; }
        public string Titolare { get; set; }
        public int Saldo { get; set; }

        private bool ContoAperto;

        public ContoCorrente(string numeroConto, string titolare)
        {
            NumeroConto = numeroConto;
            Titolare = titolare;
            Saldo = 0;
            ContoAperto = false;
        }

        public void ApriConto(int importoIniziale)
        {
            if (!ContoAperto)
            {
                if (importoIniziale >= 1000)
                {
                    Saldo += importoIniziale;
                    ContoAperto = true;
                    Console.WriteLine("Conto aperto con successo!");
                }
                else
                {
                    Console.WriteLine("L'importo iniziale deve essere almeno 1000 euro per aprire il conto.");
                    ChiediAllUtenteDiChiudere();
                }
            }
            else
            {
                Console.WriteLine("Il conto è già aperto. Chiusura dell'applicazione.");
                ChiediAllUtenteDiChiudere();
            }
        }

        private static void ChiediAllUtenteDiChiudere()
        {
            Console.WriteLine("Premi un tasto per chiudere l'applicazione.");
            Console.ReadKey(); 
            Environment.Exit(0);
        }
        public void Versamento(int importo) 
        {
            if(ContoAperto) 
            {
                Saldo += importo;
                Console.WriteLine($"Versamento di {importo} dollari effettuato con successo. Saldo attuale: {Saldo} $");
            }
            else
            {
                Console.WriteLine("Il conto è chiuso. Aprire il conto prima di effettuare un versamento");
            }
        }

        public void Prelievo(int importo)
        {
            if(ContoAperto && Saldo >= importo)
            {
                Saldo -= importo;
                Console.WriteLine($"Prelievo di {importo} dollari effettuato con successo. SALDO ATTUALE : {Saldo}");
            }
            else
            {
                Console.WriteLine("Impossibile effettuare il prelievo. Il saldo non è sufficiente");
            }
        }
    }
}
