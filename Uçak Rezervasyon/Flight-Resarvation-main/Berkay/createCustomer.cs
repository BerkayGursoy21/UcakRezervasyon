using System;
using System.IO;
using System.Text;

namespace Berkay.mains
{
    internal class createCustomer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string Id { get; set; }
        public string TelNo { get; set; }
        public int Sex { get; set; }
        public string Date { get; set; }

        public Customer customer()
        {
            Console.Write("\n----------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nTarih Giriniz (gün/ay/yıl): ");
            Console.ForegroundColor = ConsoleColor.White;
            Date = Console.ReadLine();
            Console.Write("\n----------------------------------------\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nAdınızı Giriniz: ");
            Console.ForegroundColor = ConsoleColor.White;
            Name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nSoyadınızı Giriniz: ");
            Console.ForegroundColor = ConsoleColor.White;
            Surname = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nYaşınızı Giriniz(Sayı veya Yazım olarak Girebilirsiniz): ");
            Console.ForegroundColor = ConsoleColor.White;
            Age = string.Empty;
            for (int kT = 4; kT > 0; kT--)
            {
                Age = Console.ReadLine();

                if (Age.Length != 2 && kT > 0)
                {
                    Console.WriteLine("\nYAZIM HATASI!, TEKRAR DENEYİNİZ");
                    Console.WriteLine($"{kT - 1} DENEME HAKKINIZ KALDI ");
                }
                if (kT == 0 && Age.Length != 2)
                {
                    Console.WriteLine("Deneme hakkınız Sona ermiştir. Hatalı bilgi girdiniz");
                }
                if (Age.Length == 2)
                {
                    break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nKimlikNo Giriniz: ");
            Console.ForegroundColor = ConsoleColor.White;
            Id = string.Empty;
            for (int kT = 4; kT > 0; kT--)
            {
                Id = Console.ReadLine();

                if (Id.Length != 11 && kT > 0)
                {
                    Console.WriteLine("KİMLİK NO EKSİK YADA YANLIŞ TUŞLADINIZ! TEKRAR DENEYİNİZ");
                    Console.WriteLine($"{kT - 1} DENEME HAKKINIZ KALDI ");
                }
                if (kT == 0 && Id.Length != 11)
                {
                    Console.WriteLine("Deneme hakkınız Sona ermiştir. Hatalı bilgi girdiniz");
                }
                if (Id.Length == 11)
                {
                    break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nLütfen Başında \"0\" Olmadan Telefon Numaranızı Giriniz: ");
            Console.ForegroundColor = ConsoleColor.White;
            TelNo = string.Empty;
            for (int tT = 4; tT > 0; tT--)
            {
                TelNo = Console.ReadLine();

                if (TelNo.Length != 10 && tT > 0)
                {
                    Console.WriteLine("TELEFON NUMARANIZI EKSİK YADA YANLIŞ TUŞLADINIZ! TEKRAR DENEYİNİZ");
                    Console.WriteLine($"{tT - 1} DENEME HAKKINIZ KALDI ");
                    Console.WriteLine($"BAŞINDA \"0\" OLMAMASINA DİKKAT EDİNİZ");
                }
                if (tT == 0 && TelNo.Length != 11)
                {
                    Console.WriteLine("Deneme hakkınız Sona ermiştir. Hatalı bilgi girdiniz");
                }
                if (TelNo.Length == 10)
                {
                    break;
                }
            }

            while (true)
            {
                string Temp = " ";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nCinsiyetinizi Giriniz (erkek/kadın)(E/K): ");
                Console.ForegroundColor = ConsoleColor.White;
                Temp = Console.ReadLine();

                if (Temp == "Erkek" || Temp == "E" || Temp == "erkek" || Temp == "e")
                {
                    Sex = 1;
                    break;
                }
                else if (Temp == "Kadın" || Temp == "K" || Temp == "kadın" || Temp == "k")
                {
                    Sex = 2;
                    break;
                }
                else
                {
                    Console.WriteLine("HATALI TUŞLAMA YAPTINIZ! TEKRAR DENEYİNİZ");
                    Console.WriteLine("Lütfen E ila K Kısaltmaları İle Cevap Vermeye Özen Gösteriniz");
                }
            }

            Customer musteri = new Customer(Name, Surname, Age, Id, TelNo, Sex, Date);

            // CSV dosyasına yazma işlemi
            string dosyaYolu = "musteri.csv";

            // Dosya varsa append (ekleme) modunda açılır, yoksa oluşturulur.
            using (StreamWriter sw = new StreamWriter(dosyaYolu, true, Encoding.UTF8))
            {
                // CSV dosyasına yeni bir satır eklenir
                sw.WriteLine($"{musteri.Name},{musteri.Surname},{musteri.Age},{musteri.Id},{musteri.TelNo},{musteri.Sex},{musteri.Date}");
            }

            Console.WriteLine("Müşteri bilgileri CSV dosyasına kaydedildi.");
            return musteri;

        }
    }
}