# Flight-Resarvation Promgram

Bu Program Genel olarak Classlardan ve List Yapısından oluşan, Kullanıcıdan aldıgı bilgileri en sonda Ekrana Yazdıran basit bir Uçak rezervasyon Uygulamasıdır.

Airplane, Customer, Location, Reservation Classlarımız mevcut.

AirportList Sayfamızda İste List Yapısı Kullanarak Yaklaşık 35'den fazla havalimanı Listeledik. Seçilen Ülke ve şehire bağlı olarak listeyi döndürür. Bunun için ise If ve return yapısı kullandım

CityList Sayfamızda ise List yapısı kullanarak şehirlerimizi listeledik. If ve return yapısı kullanıp ülkeye göre şehirleri döndürür.

CLnewClass Bölümünde ise string yapısı kullanarak ülke, şehir ve havalimanı bilgierlini tutmak için kullanıp, List yapısı kullanarak ülke, şehir ve havalimanı bilgilerini saklıyoruz.

createAirPlane Sınıfımızda ise Size sunulan Uçakları Random Olarak gösteren 4 adet uçak modelimiz mevcut.

createCustomer Sınıfımızda ise Programın Önemli bir bölümü yer almakta. Kullanıcıdan aldığımız ad, soyad, yas, kimlik no,telefon no ve cinsiyet Kodları bu sayfada bulunmakta. Aynı zamanda If else yapısı kullanarak basit bir şekilde Yas, Telefon Numarası VE Kimlik Numarası bölümüne doğru bilgi girilmesi için Hata sistemi mevcut. Örneğin Program sizden kimlik numaranızı istediğinde maksimum 11 haneli giriş için doğru kabul ediyor. Eğer siz 11 Haneden eksik, yanlış veya sayı yerine harf kullandığınızda Program tarafından Uyarı alıp tekrar giriş yapmanız isteniyor. Aynı olay tekrardan If yapısı kullanarak telefon giriş sistemindede mevcut maksimum 10 karakter girmeniz isteniyor. Kimlik sisteminde olduğu gibi eksik, fazla veya harf kullanımı yaptığınızda sistem tarafından uyarılıp tekrar girmenizi istiyor. Son olarak tekrardan If Else yapısı kullanarak cinsiyet seçme bölümündede mevcut Programın sizden istediği Erkek, E Kadın, K yazımlarından farklı bir giriş yaparsanız Program tarafından uyarılıp doğru karakterleri girmeniz için sizden tekrardan giriş ister

createFlight = Bu bölümde ise Kullanıcıya Ülke, Şehir ve Havalimanı seçimi yaptırıyoruz. Seçimlerimiz List yapsında kullandığımız ülke,şehir,havalimanı bölümünden çekilmekte. seçimler sonunda Location dizesini oluşturuyor. 

prescriptions = Bu bölümde ise Kullanıcıdan Alınan bütün bilgilerin Programın sonunda Kullanıcaya Gösteren son bilgi bölümüdür.
