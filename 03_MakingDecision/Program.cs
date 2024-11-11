using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;

            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital=="Ankara" & country=="Türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("veriler hatalı");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //0-50 kötü
            //51-70 orta
            //71-85 iyi
            //85 < çok iyi

            //double exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("1.Sınav Notunuzu giriniz: ");
            //exam1= double.Parse(Console.ReadLine());

            //Console.Write("2.Sınav Notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());


            //Console.Write("3.Sınav Notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine(average);

            //if (average >= 0 & average <= 50 )
            //{

            //    result =" Not ortalaman KÖTÜ";
            //}
            //if (average >=51 & average <=70 )
            //{

            //    result = " Not ortalaman ORTA";
            //}
            //if (average >= 71 & average <= 84)
            //{

            //    result = " Not ortalaman İYİ";
            //}
            //if (average >=85)
            //{

            //    result = " Not ortalaman ÇOK İYİ";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city= Console.ReadLine();

            //if (city=="adana"|city=="ankara"|city=="bursa"|city=="trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("lütfen kullanıcı adınızı giriniz: ");
            //string username =Console.ReadLine();
            //if (username!="admin")
            //{
            //    Console.WriteLine("Kullanıcı adı hatalı!");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}


            #endregion
            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result=number % 5;
            //Console.WriteLine(result);

            //Console.Write("1. sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result= number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan : " + result);

            //Console.Write("Lütfen sayıyı giriniz : ");
            //int number= int .Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("ÇİFT");
            //}
            //else
            //{
            //    Console.Write("TEK");
            //}

            #endregion
            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if (team== 'g' | team=='G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion
            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("1.Ana Yemekler");
            //Console.WriteLine("2.Çorbalar");
            //Console.WriteLine("3.Pizzalar");
            //Console.WriteLine("4.İÇecekler");
            //Console.WriteLine("5.Tatlılar");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menüyü seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek");
            //    Console.WriteLine("2- Ezogelin");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz");
            //    Console.WriteLine("2- Margarita");
            //    Console.WriteLine("3- tavuklu");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Triliçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine();
            //}

            #endregion
            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat");break;
            //    case 3:Console.Write("Mart");break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi");break;

            //}




            #endregion
            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1.sayı: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2.sayı: ");
            //number2=int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi seçiniz");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result=number1 + number2;
            //        Console.WriteLine("Sonuç: " + result);break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sonuç: " + result); break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sonuç: " + result); break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Sonuç: " + result); break;
            //}

            
            #endregion

            Console.Read();

        }
    }
}
