using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laskin_KW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;   //using integer to store the number
            int num2;

            string vastaus;
            int result;

            Console.WriteLine("Tervetuloa laskimeen."); //writing welcome and asking for the first number
            Console.WriteLine("Anna numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("anna toinen numero");

            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minkä tyyppinen lasku? y jos haluat yhteenlaskun, v jos haluat vähennyslaskun, k jos haluat kertolaskun ja j jos haluat jakolaskun "); //asking for wich type of calculation we are running

            vastaus = Console.ReadLine(); //response to the previous question in string format

            if (vastaus == "y") //the calculations
            {
                result = num1 + num2;
                Console.WriteLine("Vastaus = " + result);
            }
            else if (vastaus == "v")
            {
                result = num1 - num2;
                Console.WriteLine("Vastaus = " + result);
            }
            else if (vastaus == "k")
            {
                result = num1 * num2;
                Console.WriteLine("Vastaus = " + result);
            }
            else if (vastaus == "j")
            {
                result = num1 / num2;
                Console.WriteLine("Vastaus = " + result);
            }
            else
            {
                Console.WriteLine("Väärä vastaus");
            }

            // Console.WriteLine("Vastaus = " + result); i could not figure out why this doesnt work here
            Console.WriteLine("Kiitos käynnistä");


            Console.ReadKey();
        }
    }
}
