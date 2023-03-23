using System;

namespace Project2
{
    class aRandomVariable
    {
        //int random;
        static Random random;
        public aRandomVariable(int seed) //method 1- random number with seed with the users input
        {
            random = new Random(seed);
        }

        public int getRandomValue(int minValue, int maxValue) // random number using upper and lower values
        {
            return random.Next(minValue, maxValue);
        }

    }
}
