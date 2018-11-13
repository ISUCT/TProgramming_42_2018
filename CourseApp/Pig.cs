using System;

namespace ConsoleApp4
{
    class Pig
    {
        private int salo;
        private int age;
        private string pol;
     
        private Pig()
        {
            pol = "M";
            age = 20;
            salo = 70;
        }
        private Pig(string n )
        {
            pol = n;
            if (pol == "M")
            {
                age = 15; salo = 45;
            }
            else
            { age = 20; salo = 70; }
        }

    }

}
