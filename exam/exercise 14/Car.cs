using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_14
{
    class Car
    {
        public string start()
        {
            return $"Машина стартует";
        }

        public string stop()
        {
            return $"Машина останавливается";
        }

        public int drive(int howlong)
        {
            return howlong * 60;
        }
    }
}
