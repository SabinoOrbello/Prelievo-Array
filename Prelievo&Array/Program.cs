using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelievo_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il numero del conto :" );
            string numeroConto = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Inserisci il nome del titolare");
            string titolare = Console.ReadLine();
            Console.WriteLine("");


            ContoCorrente mioConto = new ContoCorrente(numeroConto, titolare);

            Console.Write("Inserisci l'importo iniziale per aprire il conto (almeno 1000 euro): ");
            if (int.TryParse(Console.ReadLine(), out int importoIniziale))
            {
                mioConto.ApriConto(importoIniziale);
            }
            else
            {
                Console.WriteLine("Inserimento non valido per l'importo iniziale.");
            }
            Console.WriteLine("");
            Console.Write("Inserisci l'importo per il versamento: ");
            if (int.TryParse(Console.ReadLine(), out int importoVersamento))
            {
                mioConto.Versamento(importoVersamento);
            }
            else
            {
                Console.WriteLine("Inserimento non valido per l'importo del versamento.");
            }
            Console.WriteLine("");
            Console.Write("Inserisci l'importo per il prelievo: ");
            if (int.TryParse(Console.ReadLine(), out int importoPrelievo))
            {
                mioConto.Prelievo(importoPrelievo);
                
            }
            else
            {
                Console.WriteLine("Inserimento non valido per l'importo del prelievo.");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            // ESERCIOZIO 2

            Console.Write("Inserisci il numero di nomi: ");
            if (int.TryParse(Console.ReadLine(), out int numeroNomi) && numeroNomi > 0)
            {
                // Dichiaro e inizializzo l'array di stringhe
                string[] arrayNomi = new string[numeroNomi];

                // Carico l'array con i nomi
                for (int i = 0; i < numeroNomi; i++)
                {
                    Console.Write($"Inserisci il nome {i + 1}: ");
                    arrayNomi[i] = Console.ReadLine();
                }

                // Input del nome da cercare
                Console.Write("Inserisci il nome da cercare: ");
                string nomeDaCercare = Console.ReadLine();

                // Ricerca del nome nell'array
                if (Array.Exists(arrayNomi, nome => nome.Equals(nomeDaCercare, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"Il nome '{nomeDaCercare}' è presente nell'array.");
                }
                else
                {
                    Console.WriteLine($"Il nome '{nomeDaCercare}' non è presente nell'array.");
                }
            }
            else
            {
                Console.WriteLine("Input non valido per il numero di nomi.");
            }

            Console.WriteLine("");
            Console.WriteLine("");


            //ESERCIZIO3

            Console.Write("Inserisci la dimensione dell'array: ");
            if (int.TryParse(Console.ReadLine(), out int dimensioneArray) && dimensioneArray > 0)
            {
                // Dichiarazione e inizializzazione dell'array di interi
                int[] numeri = new int[dimensioneArray];

                // Richiesta all'utente di inserire i numeri nell'array
                for (int i = 0; i < dimensioneArray; i++)
                {
                    Console.Write($"Inserisci il numero {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                    {
                        numeri[i] = numero;
                    }
                    else
                    {
                        Console.WriteLine("Inserimento non valido. Inserisci un numero intero.");
                        i--; // Decrementa l'indice per permettere all'utente di reinserire il numero 
                    }
                }

                // Calcola la somma di tutti i numeri nell'array
                int somma = 0;
                foreach (int numero in numeri)
                {
                    somma += numero;
                }

                // Calcola la media aritmetica
                double media = (double)somma / dimensioneArray;

                // Stampa la somma e la media
                Console.WriteLine($"La somma di tutti i numeri è: {somma}");
                Console.WriteLine($"La media aritmetica è: {media}");
            }
            else
            {
                Console.WriteLine("Input non valido per la dimensione dell'array.");
            }

            // Attendi prima di chiudere la console
            Console.ReadLine();

        }
    }
}
