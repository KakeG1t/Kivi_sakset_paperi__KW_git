using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Pisteet = 0;
            int ai_Pisteet = 0; //making an iteger to store the match's points

            Console.WriteLine("Kivi, sakset, paperi!");

            while (Pisteet != 3 && ai_Pisteet != 3)//creating a loop to prevent the program from stopping until one player scores 3 points
            {
                Console.WriteLine("Sinun pisteet: " + Pisteet + " | Koneen pisteet: " + ai_Pisteet);
                Console.WriteLine("valitse: kivi 'k', sakset 's' tai paperi 'p'"); // give each choice
                string valinta = Console.ReadLine(); // store the player's choice in string

                int kone_valinta = random.Next(0, 2); // Computer chooses 0 - 2 randomly 

                if (kone_valinta == 0)
                {
                    Console.WriteLine("Kone valitsi kiven.");

                    switch (valinta)
                    {
                        case "k":
                            Console.WriteLine("Valitsitte molemmat kiven.");
                            break;
                        case "p":
                            Console.WriteLine("+1 piste");
                            Pisteet++;
                            break;
                        default:
                            Console.WriteLine("+1 piste koneelle");
                            ai_Pisteet++;
                            break;

                    }
                }
                else if (kone_valinta == 1)
                {
                    Console.WriteLine("Kone valitsi sakset.");
                    switch (valinta)
                    {
                        case "k":
                            Console.WriteLine("1+ piste");
                            Pisteet++;
                            break;
                        case "p":
                            Console.WriteLine("+1 piste koneelle");
                            ai_Pisteet++;
                            break;
                        default:
                            Console.WriteLine("Valitsitte molemmat sakset.");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Kone valitsi paperin.");
                    switch (valinta)
                    {
                        case "k":
                            Console.WriteLine("+1 piste koneelle");
                            Pisteet++;
                            break;
                        case "p":
                            Console.WriteLine("Valitsitte molemmat paperin.");
                            break;
                        default:
                            Console.WriteLine("+1 piste");
                            Pisteet++;
                            break;

                    }
                }

            }
            if (Pisteet == 3)
            {
                Console.WriteLine("Voitit, ensikertaan!");
            }
            else
            {
                Console.WriteLine("Hävisit, ensikertaan!");

            }

            Console.ReadKey();
        }
    }
}
