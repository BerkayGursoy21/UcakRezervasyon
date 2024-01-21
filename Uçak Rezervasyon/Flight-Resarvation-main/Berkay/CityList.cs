using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berkay
{
    internal class CityList
    {
        public string[] getCityList(int selectCountry)
        {
            //SEHIRLER

            string[] turkiyeSehirler = { "İstanbul", "Ankara", "Antalya", "İzmir", "Balıkesir" };
            string[] almanyaSehirler = { "Berlin", "Dusseldorf ", "Frankfurt", "Stuttgart", "Köln" };
            string[] fransaSehirler = { "Paris", "Nice", "Lyon", "Cannes", "Strazburg" };
            string[] ingiltereSehirler = { "Glasglow", "Blackpool", "Liverpool", "Londra", "Newcastle" };
            string[] italyaSehirler = { "Bari", "Bologna", "Pisa", "Milano ", "Roma" };

            if (selectCountry == 1)
            {
                return turkiyeSehirler;
            }
            if (selectCountry == 2)
            {
                return almanyaSehirler;
            }
            if (selectCountry == 3)
            {
                return fransaSehirler;
            }
            if (selectCountry == 4)
            {
                return ingiltereSehirler;
            }
            if (selectCountry == 5)
            {
                return italyaSehirler;
            }

            return new string[0];
        }
    }
}
