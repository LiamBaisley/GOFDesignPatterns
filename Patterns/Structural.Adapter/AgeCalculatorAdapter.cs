using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Adapter
{
    internal static class AgeCalculatorAdapter
    {
        //We build an adapter so that our code can integrate with the third party "AgeCalculator" logic.
        public static double GetAge(double DogAgeInDogYears)
        {
            double dogAgeInDays = (DogAgeInDogYears / 7);

            return AgeCalculator.CalculateAge(dogAgeInDays);
        }
    }
}
