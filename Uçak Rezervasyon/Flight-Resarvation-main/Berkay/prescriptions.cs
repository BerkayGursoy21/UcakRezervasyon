using System;
using System.IO;

namespace Berkay.mains
{
    internal class prescriptions
    {
        public string Customer;
        public string Airplane;
        public string Location;
        public string Date;
        public string bK;

        public prescriptions(string Ad, string Soyad, string airplane, string location, string date, string bk)
        {
            Customer = Ad + " " + Soyad;
            Airplane = airplane;
            Location = location;
            Date = date;
            bK = bk;
        }

        public string UcusDondur()
        {
            // Uçuş bilgileri
            Reservation rezervasyon = new Reservation();

            string Temp = "\n NEREDEN: " + bK + "\n NEREYE: " + Location + "\n Uçuş Tarihiniz: " + Date + "\n ADINIZ SOYADINIZ: " + Customer + "\n Uçağınız: " + Airplane + "\n Koltuk Numaranız: " + rezervasyon.PassangerNumber + "\n Bilet Tutarınız: " + rezervasyon.Price + "TL";
            return Temp;
        }

       
    }
}
