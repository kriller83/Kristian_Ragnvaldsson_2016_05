using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTenta2.Models
{
    public class CalculateEnergy
    {
        public double CalculateMass(string mass)
        {
            var massInput = double.Parse(mass);
            var lighSpeed = 435454656;
            var energy = massInput*(Math.Pow(lighSpeed, 2));
            return energy;
        }
}