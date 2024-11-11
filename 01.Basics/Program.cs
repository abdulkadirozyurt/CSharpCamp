using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Printing
            //Console.WriteLine("Hello world.");
            //Console.Write("Hello.");

            //Console.WriteLine("********** Yemek Kategorileri ***********");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("********** Yemek Kategorileri ***********");
            #endregion

            #region StringVariables

            //string name;
            //name = "Murat";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Murat";
            //customerSurname = "Yücedağ";
            //customerPhone = "0532 123 45 67";
            //customerEmail = "info@example.com";
            //district = "Çekmeköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri Adı: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone + " - " + customerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ahmet";
            //customerSurname = "Yılmaz";
            //customerPhone = "0532 123 45 67";
            //customerEmail = "test@example.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri Adı: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone + " - " + customerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("--------------------------------------------------");

            #endregion

            #region IntegerVariables

            //int number1 = 10;
            //Console.WriteLine(number1);

            int hamburgerPrice = 300;
            int cokaPrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 200;
            int lemonadePrice = 30;

            Console.WriteLine("Restoran menü");
            Console.WriteLine();
            Console.WriteLine("1-Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("2-Kola: " + cokaPrice + " TL");
            Console.WriteLine("3-Su: " + waterPrice + " TL");
            Console.WriteLine("4-Patates: " + friesPrice + " TL");
            Console.WriteLine("5-Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("6-Limonata: " + lemonadePrice + " TL");
            Console.WriteLine();

            int hamburgerCount = 2;
            int cokaCount = 3;
            int waterCount = 1;
            int friesCount = 1;
            int pizzaCount = 1;
            int lemonadeCount = 2;
            int totalPrices = (hamburgerPrice * hamburgerCount) + (cokaPrice * cokaCount) + (waterPrice * waterCount) + (friesPrice * friesCount) + (pizzaPrice * pizzaCount) + (lemonadePrice * lemonadeCount);

            Console.WriteLine("Sipariş Özeti");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerCount + " adet");
            Console.WriteLine("Kola: " + cokaCount + " adet");
            Console.WriteLine("Su: " + waterCount + " adet");
            Console.WriteLine("Patates: " + friesCount + " adet");
            Console.WriteLine("Pizza: " + pizzaCount + " adet");
            Console.WriteLine("Limonata: " + lemonadeCount + " adet");
            Console.WriteLine();
            Console.WriteLine("Toplam Tutar: " + totalPrices + " TL");

            #endregion



            Console.ReadLine();
        }
    }
}




