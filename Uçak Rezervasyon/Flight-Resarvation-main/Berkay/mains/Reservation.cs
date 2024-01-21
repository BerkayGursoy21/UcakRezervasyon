using System;

namespace Berkay.mains
{
    internal class Reservation
    {
        public int Price;
        public int PassangerNumber;
        public Reservation()
        {
            Random rnd = new Random();
            Price = rnd.Next(500, 10000);

            Random rnd2 = new Random();
            PassangerNumber = rnd2.Next(1, 500);
        }
    }
}
