using System;

// References
// https://docs.microsoft.com/en-us/dotnet/api/system.random?view=net-5.0#Instantiate
// https://docs.microsoft.com/en-us/dotnet/api/system.random.next?view=net-5.0

namespace P1
{
    class RandomUtility
    {
        public Random GetRandom(int seed) // method1- random number with seed with users input
        {
            return new Random(seed);
        }

        public int Roll(Random random, int lowervalue, int uppdervalue) // random number 1-6 using upper and lower values
        {
            return random.Next(lowervalue, uppdervalue + 1);
        }
    }
}
