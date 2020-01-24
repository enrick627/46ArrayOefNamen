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
            string[] namen = new string[3];

            // VRAAG    3 namen aan de gebruiker
            for (int i = 0; i < 3 ; i++)
            {
                Console.WriteLine("geef een naam");
                namen = Console.ReadLine();
            }
            // BEREKEN  ALS     gebruiker naam ingeeft
            //          DAN     sorter op volgorde 
            //          ALS     de namen zijn gesorteerd
            //          DAN     de namen in hoofdletter
                      
            // TOON      de namen in volgorde
        }
    }
}
