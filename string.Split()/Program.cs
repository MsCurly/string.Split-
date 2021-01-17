using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string.Split__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bölge giriniz:");
            string bolge = Console.ReadLine();
            string akdeniz = "Adana Antalya Burdur Hatay Isparta Kahramanmaraş Mersin Osmaniye";    
            string doguAnadolu = "Ağrı, Ardahan, Bingöl, Bitlis, Elazığ, Erzincan, Erzurum, Hakkari, Iğdır, Kars, Malatya, Muş, Tunceli, Van";
            string ege = "Afyonkarahisar, Aydın, Denizli, İzmir, Kütahya, Manisa, Muğla, Uşak";
            string guneydoguAnadolu = "Adıyaman, Batman, Diyarbakır, Gaziantep, Mardin, Siirt, Şanlıurfa, Şırnak, Kilis";
            string içAnadolu = "Aksaray, Ankara, Çankırı, Eskişehir, Karaman, Kayseri, Kırıkkale, Kırşehir, Konya, Nevşehir, Niğde, Sivas, Yozgat";
            string marmara = "Balıkesir, Bilecik, Bursa, Çanakkale, Edirne, İstanbul, Kırklareli, Kocaeli, Sakarya, Tekirdağ, Yalova";
            string karadeniz = "Amasya, Artvin, Bartın, Bayburt, Bolu, Çorum, Düzce, Giresun, Gümüşhane, Karabük, Kastamonu, Ordu, Rize, Samsun, Sinop, Tokat, Trabzon, Zonguldak";

            if (bolge == "akdeniz" || bolge == "Akdeniz" )
            {
                Console.WriteLine("Akdeniz Bölgesinde Bulunan Şehirler:");
                string[] sehirler = akdeniz.Split();
                foreach (string ad in sehirler)
                    Console.WriteLine(ad);
            }

            else if (bolge == "dogu anadolu" || bolge == "Dogu Anadolu")
            {
                Console.WriteLine("Doğu Anadolu Bölgesinde Bulunan Şehirler:");
                string[] sehirler = doguAnadolu.Split();
                foreach (string ad in sehirler)
                    Console.WriteLine(ad);
            }
            else if (bolge == "ege" || bolge == "Ege")
            {
                Console.WriteLine("Ege Bölgesinde Bulunan Şehirler:");
                string[] sehirler = ege.Split();
                foreach (string ad in sehirler)
                    Console.WriteLine(ad);
            }
            else if (bolge == "guneydogu anadolu" || bolge == "Guneydogu Anadolu")
            {
                Console.WriteLine("Guneydoğu Anadolu Bölgesinde Bulunan Şehirler:");
                string[] sehirler = guneydoguAnadolu.Split();
                foreach (string ad in sehirler)
                    Console.WriteLine(ad);
            }
            else if (bolge == "guneydogu anadolu" || bolge == "Guneydogu Anadolu")
            {
                Console.WriteLine("Guneydoğu Anadolu Bölgesinde Bulunan Şehirler:");
                string[] sehirler = guneydoguAnadolu.Split();
                foreach (string ad in sehirler)
                    Console.WriteLine(ad);
            }
            else if (bolge == "iç anadolu" || bolge == "İç Anadolu")
            {
                Console.WriteLine("İç Anadolu Bölgesinde Bulunan Şehirler:");
                string[] sehirler = içAnadolu.Split();
                foreach (string ad in sehirler)
                    Console.WriteLine(ad);
            }
            else if (bolge == "marmara" || bolge == "Marmara")
            {
                Console.WriteLine("Marmara Bölgesinde Bulunan Şehirler: ");
                string[] sehirler = marmara.Split();
                foreach (string ad in sehirler)
                    Console.WriteLine(ad);
            }
            else if (bolge == "karadeniz" || bolge == "Karadeniz")
            {
                Console.WriteLine("Karadeniz Bölgesinde Bulunan Şehirler: ");
                string[] sehirler = marmara.Split();
                foreach (string ad in sehirler)
                    Console.WriteLine(ad);
            }
            else
                Console.WriteLine("Yanlış ya da eksik arama yaptınız, lütfen tekrar giriniz!");


            Console.ReadLine();
        }
    }
}
