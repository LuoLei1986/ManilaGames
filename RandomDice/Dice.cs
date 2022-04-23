using System;

namespace RandomDice
{
    public class Dice
    {
        public int Roll()
        {
            return new Random().Next(1, 6);
        }
    }
}
