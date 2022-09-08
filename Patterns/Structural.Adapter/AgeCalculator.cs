using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Adapter
{
    internal static class AgeCalculator
    {
        //The theory is that this is external code that we have no access to and cannot modify
        public static double CalculateAge(double days)
        {
            return Math.Round(days * 365.25);
        }
    }
}
