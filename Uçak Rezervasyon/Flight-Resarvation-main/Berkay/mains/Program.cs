using System;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Berkay.mains
{
    internal class Program
    {
        static void Main(string[] args)
        {
        turnBack:
            try
            {

                Console.Title = "Berkay Havayolu - Rezervasyon Sistemi";


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-----------Berkay Havayolu Rezervasyon Sistemimize Hoşgeldiniz.-----------\n");
                Console.ForegroundColor = ConsoleColor.White;

                createFlight kalkisNoktasi = new createFlight("Kalkış Noktası Seçiniz:");
                createFlight ucusNoktası = new createFlight("Varış Noktası Seçiniz:");



                createCustomer musteriOLusturma = new createCustomer();
                Customer musteri = musteriOLusturma.customer();


                Console.ForegroundColor = ConsoleColor.Cyan;
                prescriptions son = new prescriptions(musteri.Name, musteri.Surname, ucusNoktası.Airplane,ucusNoktası.Location, musteriOLusturma.Date, kalkisNoktasi.Location);
                Console.WriteLine(son.UcusDondur());
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("\n\n-----------Bizi Tercih Ettiğiniz İçin Teşekkür Eder İyi Günler Dileriz.-----------");
                Thread.Sleep(500);

            }

            catch (Exception)
            {

                Console.WriteLine("\n HATALI GİRİŞ YAPTINIZ!");
                Thread.Sleep(500);

            }

            Console.WriteLine("\n-----------TEKRAR DENEMEK İÇİN \"T\" PROGRAMI BİTİRMEK İÇİN İSE HERHANGİ BİR TUŞA BASINIZ-----------");
            Console.Write("\n: ");
            string isT = Console.ReadLine();
            if (isT == "t" || isT == "T")
            {
                Console.WriteLine("");
                goto turnBack;
            }


        }
    }
}
