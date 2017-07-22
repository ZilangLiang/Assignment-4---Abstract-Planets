using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4___Abstract_Planets
{
    class GiantPlanet : Planet,IHasMoons,IHasRings
    {
        private string _type;

        public GiantPlanet(string name, double diameter, double mass, string type)
            :base(name,diameter,mass)
        {
            this._type = type;

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
        public bool HasRings()
        {
            if(this.RingCount > 0)
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
