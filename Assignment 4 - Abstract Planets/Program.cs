using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Name: Zilang Liang
/// Date:July 26, 2017
/// Description: This is the driver class for my project
/// version 0.2 - Added WaitForAnyKey method
/// </summary>
namespace Assignment_4___Abstract_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Super Giant", 5, 5, "Huge");
            Console.WriteLine(giantPlanet.ToString());

            TerrestrialPlanet terrestiaPlanet = new TerrestrialPlanet("Terrestial A", 2, 3, true);
            Console.WriteLine(terrestiaPlanet.ToString());

            WaitForAnyKey();
        }
        public static void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
