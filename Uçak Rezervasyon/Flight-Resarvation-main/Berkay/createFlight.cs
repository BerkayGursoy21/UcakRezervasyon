using System;
using System.Text;
using Berkay.mains;

namespace Berkay
{
    internal class createFlight
    {

        public string Airplane;
        public string Location;
        public string Date;

        string TempLocU = string.Empty;
        string TempLocS = string.Empty;
        string TempLocH = string.Empty;
        public createFlight(string tip)
        {


            createAirPlane ucakOlusturma = new createAirPlane();
            Airplane = ucakOlusturma.Model;

            CLnewClass cl = new CLnewClass();


            int USayac = 1;
            foreach (var item in cl.LokasyonListU)
            {
                Console.WriteLine(USayac + "." + item);
                USayac++;
            }


            int secimU = 0;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n{tip} için Ulke seçiniz: ");
                Console.ForegroundColor = ConsoleColor.White;
                secimU = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (secimU >= 1 && secimU <= USayac - 1)
                {
                    TempLocU = cl.LokasyonListU[secimU - 1];
                    break;
                }
            }

            int SSayac = 1;
            CityList cityList = new CityList();
            string[] sehirler = cityList.getCityList(secimU);

            for (int i = 0; i < sehirler.Length; i++)
            {
                string TLokasyon = sehirler[i];
                cl.LokasyonListS.Add(TLokasyon);
            }

            foreach (var item in cl.LokasyonListS)
            {

                Console.WriteLine(SSayac + "." + item);
                SSayac++;
            }

            int secimS = 0;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n{tip} için Sehir seçiniz: ");
                Console.ForegroundColor = ConsoleColor.White;
                secimS = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (secimS >= 1 && secimS <= SSayac - 1)
                {
                    TempLocS = cl.LokasyonListS[secimS - 1];
                    break;
                }
            }


            AirportList airportList = new AirportList();
            string[] airports = airportList.getAirPortList(secimU, secimS);

            for (int i = 0; i < airports.Length; i++)
            {
                string TLokasyon = airports[i];
                cl.LokasyonListH.Add(TLokasyon);
            }
            int HSayac = 1;
            foreach (var item in cl.LokasyonListH)
            {
                Console.WriteLine(HSayac + "." + item);
                HSayac++;
            }


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n{tip} için Havaalanı seçiniz: ");
                Console.ForegroundColor = ConsoleColor.White;
                int secimH = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (secimH >= 1 && secimH <= HSayac - 1)
                {
                    TempLocH = cl.LokasyonListH[secimH - 1];
                    break;
                }
            }

            Location = $"{TempLocU} - {TempLocS} - {TempLocH}";

            /// CSV dosyasına yazma işlemi
            string dosyaYolu = "musteri.csv";

            // Dosya varsa append (ekleme) modunda açılır, yoksa oluşturulur.
            using (StreamWriter sw = new StreamWriter(dosyaYolu, true, Encoding.UTF8))
            {
                // CSV dosyasına yeni bir satır eklenir
                sw.WriteLine($"{DateTime.Now},{Airplane},{Location},{Date}");
            }

            Console.WriteLine("Uçuş bilgileri CSV dosyasına kaydedildi.");

        }
    }
}








