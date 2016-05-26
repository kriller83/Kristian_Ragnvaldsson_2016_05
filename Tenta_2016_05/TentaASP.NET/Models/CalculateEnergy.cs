using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TentaASP.NET.Models
{
    public class CalculateEnergy
    {
        public double CalculateMass(string mass)
        {
            double parsedMass = double.Parse(mass);
            double speeOfLight = 299792458;
            var energy = parsedMass*(Math.Pow(speeOfLight, 2));
            return energy;
        }
    }
}