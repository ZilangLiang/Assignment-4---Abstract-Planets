using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Name: Zilang Liang
/// Date:July 22, 2017
/// Description: This is the TerrestrialPlanet class for my project
/// version 0.1
/// </summary>
namespace Assignment_4___Abstract_Planets
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        private bool _oxygen;
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
        public bool Habitable()
        {
            if (this._oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HasMoons()
        {
            if (this.MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
