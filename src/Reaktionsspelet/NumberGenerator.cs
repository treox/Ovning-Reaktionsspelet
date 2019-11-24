using System;

namespace Reaktionsspelet
{
    public class NumberGenerator
    {
        int minValue = 3000;
        int maxValue = 10000;

        public int ReturnsARandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(minValue, maxValue);
        }
    }
}
