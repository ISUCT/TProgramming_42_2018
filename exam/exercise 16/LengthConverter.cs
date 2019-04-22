using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_16
{
    class LengthConverter
    {
        public double ConvertMilesToKm(double length)
        {
            return length * 1.609;
        }
        public double ConvertKmToMiles(double length)
        {
            return length / 1.609;
        }
    }
}
