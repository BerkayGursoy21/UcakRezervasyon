using System;
using System.Diagnostics;
using Berkay.mains;

namespace Berkay
{
    internal class createAirPlane : Airplane
    {

        public string Model { get; set; }


        private Random Random = new Random();

        public createAirPlane()
        {

            int random = Random.Next(0, 4);

            if (random == 0)
            {
                Model = "AIRBUS A330";

            }
            if (random == 1)
            {
                Model = "BOEING 737-800";

            }
            if (random == 2)
            {
                Model = "BOEING 737-900ER";

            }
            if (random == 3)
            {
                Model = "AIRBUS A340";

            }

        }
    }
}