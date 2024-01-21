using System;
using System.Collections.Generic;
using System.IO;
using Berkay.mains;

namespace Berkay
{
    internal class CLnewClass : Location
    {

        public string Country { get; set; }
        public string City { get; set; }
        public string Airport { get; set; }

        private string TLokasyon = string.Empty;

        //lISTELER

        public List<string> LokasyonListU = new List<string>();
        public List<string> LokasyonListS = new List<string>();
        public List<string> LokasyonListH = new List<string>();

        //Ülke seçenekleri

        string[] ulkeler = { "Türkiye", "Almanya", "Fransa", "İngiltere", "İtalya" };


  
        public CLnewClass()
        {
            for (int i = 0; i < ulkeler.Length; i++)
            {
                TLokasyon = ulkeler[i];
                LokasyonListU.Add(TLokasyon);
            }
        }

       
    }
}
