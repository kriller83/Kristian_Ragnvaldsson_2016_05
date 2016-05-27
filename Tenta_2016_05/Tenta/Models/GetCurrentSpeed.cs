using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tenta.Models
{
    public class GetCurrentSpeed
    {
        public double GetSpeed(string distance)
        {
            double distanceInput = double.Parse(distance);
            double time = 60;
            var speed = distanceInput/time;
            return speed;
        }
    }
}

