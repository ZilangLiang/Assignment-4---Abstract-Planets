using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Name: Zilang Liang
/// Date:July 22, 2017
/// Description: This is the driver class for my project
/// version 0.1
/// </summary>
namespace Assignment_4___Abstract_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("GiantA", 5, 5, "Huge");
            Console.WriteLine(giantPlanet.ToString());

            TerrestrialPlanet terrestiaPlanet = new TerrestrialPlanet("TerrestialA", 2, 3, true);
            Console.WriteLine(terrestiaPlanet.ToString());

            Console.ReadKey();
        }
    }
}
