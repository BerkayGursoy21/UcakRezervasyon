using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berkay
{
    internal class AirportList
    {
        public string[] getAirPortList(int selectedCountry, int selectedCity)
        {
            string[] defaultList = { "", "", "", "", "" };

            //HAVALİMANLARI

            string[] istanbulhavalimanı = { "İstanbul Havalimanı", "Sabiha Gökçen Havalimanı" };
            string[] ankarahavalimanı = { "Ankara Esenboğa Havalimanı" };
            string[] antalyahavalimanı = { "Antalya Havalimanı" };
            string[] izmirhavalimanı = { "Adnan Menderes Havalimanı" };
            string[] balıkesirhavalimanı = { "Balıkesir Koca Seyit Havalimanı" };
            string[] Berlinhavalimanı = { "Berlin Brandenburg Havalimanı1", "Berlin Tempelhof Havalimanı" };
            string[] Dusseldorfhavalimanı = { "Düsseldorf Uluslararası Havalimanı" };
            string[] frankfurthavalimanı = { "Frankfurt Havalimanı" };
            string[] stuttgarthavalimanı = { "Stuttgart Havaalanı" };
            string[] kölnhavalimanı = { "Köln Bonn Havalimanı" };
            string[] parishavalimanı = { "Paris Orly, Paris Charles de Gaulle", "Paris Beauvais" };
            string[] nicehavalimanı = { "Cote D'azur Uluslararası Havalimanı" };
            string[] lyonhavalimanı = { "Lyon–Saint-Exupéry Havaalanı" };
            string[] canneshavalimanı = { "Cannes Mandelieu Airport" };
            string[] strazburghavalimanı = { "Strazburg Havalimanı" };
            string[] glasglowhavalimanı = { "Glasgow Havaalanı" };
            string[] blackpoolhavalimanı = { "Blackpool Airport" };
            string[] liverpoolhavalimanı = { "Liverpool Havalimanı" };
            string[] londrahavalimanı = { "Londra City ", "Londra Heathrow", "Londra Gatwick", "Londra Luton", "Londra Stansted", "Londra Southend" };
            string[] newcastlehavalimanı = { "Newcastle Havaalanı" };
            string[] barihavalimanı = { "Bari Karol Wojtyła Havaalanı" };
            string[] bolognahavalimanı = { "Bologna Guglielmo Marconi Havalimanı" };
            string[] pisahavalimanı = { "Pisa Uluslararası Havaalanı" };
            string[] milanohavalimanı = { "Milano-Malpensa Havalimanı","Milano-Bergamo Havalimanı", "Milanı-Malpensa Havaliman" };
            string[] romahavalimanı = { "Roma Leonardo da Vinci" ,"Fiumicino Havalimanı","Roma Ciampino Havaalanı" };


            if (selectedCountry == 1)
            {
                if (selectedCity == 1)
                    return istanbulhavalimanı;
                if (selectedCity == 2)
                    return ankarahavalimanı;
                if (selectedCity == 3)
                    return antalyahavalimanı;
                if (selectedCity == 4)
                    return izmirhavalimanı;
                if (selectedCity == 5)
                    return balıkesirhavalimanı;
            }
            if (selectedCountry == 2)
            {
                if (selectedCity == 1)
                    return Berlinhavalimanı;
                if (selectedCity == 2)
                    return Dusseldorfhavalimanı;
                if (selectedCity == 3)
                    return frankfurthavalimanı;
                if (selectedCity == 4)
                    return stuttgarthavalimanı;
                if (selectedCity == 5)
                    return kölnhavalimanı;

            }
            if (selectedCountry == 3)
            {
                if (selectedCity == 1)
                    return parishavalimanı;
                if (selectedCity == 2)
                    return nicehavalimanı;
                if (selectedCity == 3)
                    return lyonhavalimanı;
                if (selectedCity == 4)
                    return canneshavalimanı;
                if (selectedCity == 5)
                    return strazburghavalimanı;
            }
            if (selectedCountry == 4)
            {
                if (selectedCity == 1)
                    return glasglowhavalimanı;
                if (selectedCity == 2)
                    return blackpoolhavalimanı;
                if (selectedCity == 3)
                    return liverpoolhavalimanı;
                if (selectedCity == 4)
                    return londrahavalimanı;
                if (selectedCity == 5)
                    return newcastlehavalimanı;
            }
            if (selectedCountry == 5)
            {
                if (selectedCity == 1)
                    return barihavalimanı;
                if (selectedCity == 2)
                    return bolognahavalimanı;
                if (selectedCity == 3)
                    return pisahavalimanı;
                if (selectedCity == 4)
                    return milanohavalimanı;
                if (selectedCity == 5)
                    return romahavalimanı;
            }

            return defaultList;
        }
    }
}
