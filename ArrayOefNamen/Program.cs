//Enrick De Munter 5ITN nr3 24/01/2020
/* OPGAVE
 * ======
 * 3 namen (user input) gesorteerd en in hoofdletters
 * ANALYSE  
 * ======
 * VRAAG    3 namen aan de gebruiker
 *  
 * BEREKEN  ALS     gebruiker naam ingeeft
 *          DAN     sorter op volgorde 
 *          ALS     de namen zijn gesorteerd
 *          DAN     de namen in hoofdletter
 *          
 * TOON      de namen in volgorde
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOefNamen
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaraties
            string NamenUpgrade, NamenUpgrades;
            string[] namen = new string[3];

            // VRAAG    3 namen aan de gebruiker
            for (int i = 0; i < 3; i++)
            {
                // BEREKEN  ALS     gebruiker naam ingeeft
                Console.WriteLine("geef een naam");
                namen[i] = Console.ReadLine();
            }
            //          DAN     sorter op volgorde 
            //          ALS     de namen zijn gesorteerd
            Array.Sort(namen);
            foreach (string item in namen)
            {
                //          DAN     de namen in hoofdletter
                // TOON      de namen in volgorde

                NamenUpgrade = item;
                NamenUpgrade = item.Substring(0, 1);
                NamenUpgrades = item.Substring();
                Console.WriteLine($"{NamenUpgrade.ToUpper()}.{NamenUpgrades.ToUpper()}");

            }
            //wachten 
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();
        }
    }
}
