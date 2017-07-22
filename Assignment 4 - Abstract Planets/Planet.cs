using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_4___Abstract_Planets
{
    public abstract class Planet
    {
        //PRIVATE FIELDS
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //PUBLIC PROPERTIES
        public double Diameter { get; }
        public double Mass { get; }
        public int MoonCount { get; set; }
        public string Name { get; }
        public double OrbitaPeriod { get; set; }
        public int RingCount { get; set; }
        public double RotationPeriod { get; set; }

        //METHODS
        public Planet (string name, double diameter, double mass)
        {
            this.Name = name;
            this.Diameter = diameter;
            this.Mass = mass;
        }

        public override string ToString()
        {
            return string.Format("Name:{0}  Diameter:{1}  Mass:{2}", Name, Diameter, Mass);
        }
    }
}