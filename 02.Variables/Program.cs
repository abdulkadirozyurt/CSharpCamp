using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            #region DoubleVariables
            //double number;
            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice,orangePrice, strawberryPrice,potato,tomato;
            //applePrice = 2.5;
            //orangePrice = 3.5;
            //strawberryPrice = 4.5;
            //potato = 1.5;
            //tomato = 2.5;
            //Console.WriteLine("Elma : " + applePrice + " ₺");
            //Console.WriteLine("Portakal : " + orangePrice + " TL");
            //Console.WriteLine("Çilek : " + strawberryPrice + " TL");
            //Console.WriteLine("Patates : " + potato + " TL");
            //Console.WriteLine("Domates : " + tomato + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 1.540;
            //strawberryGram = 2.000;
            //potatoGram = 5.210;
            //tomatoGram = 3.120;

            //double appleTotal, orangeTotal, strawberryTotal, potatoTotal, tomatoTotal;

            //appleTotal = applePrice * appleGram;
            //Console.WriteLine("Elma Toplam Fiyatı : " + appleTotal + " TL");

            //orangeTotal = orangePrice * orangeGram;
            //Console.WriteLine("Portakal Toplam Fiyatı : " + orangeTotal + " TL");

            //strawberryTotal = strawberryPrice * strawberryGram;
            //Console.WriteLine("Çilek Toplam Fiyatı : " + strawberryTotal + " TL");

            //potatoTotal = potato * potatoGram;
            //Console.WriteLine("Patates Toplam Fiyatı : " + potatoTotal + " TL");

            //tomatoTotal = tomato * tomatoGram;
            //Console.WriteLine("Domates Toplam Fiyatı : " + tomatoTotal + " TL");
            //Console.WriteLine();
            //double total = appleTotal + orangeTotal + strawberryTotal + potatoTotal + tomatoTotal;
            //Console.WriteLine("Toplam Fiyat : " + total + " TL");
            #endregion

            #region CharVariables

            //char character;
            //character = 'A';


            #endregion

            #region InputData

            //Console.WriteLine("C# Hava Yolları Yolcu Bilgisi");
            //Console.WriteLine();

            //string firstName, lastName, district, city, age, idNumber;

            //Console.Write("Adınız : ");
            //firstName = Console.ReadLine();

            //Console.Write("Soyadınız : ");
            //lastName = Console.ReadLine();

            //Console.Write("Yaşınız : ");
            //age = Console.ReadLine();

            //Console.Write("Kimlik Numaranız : ");
            //idNumber = Console.ReadLine();





            #endregion

            #region IntegerInputsAndTypeCasting

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz");
            //shoesCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz");
            //computerCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz");
            //tvCount = Convert.ToInt32(Console.ReadLine());

            //int totalPrice = (shoesPrice * shoesCount) + (computerPrice * computerCount) + (tvPrice * tvCount);
            //Console.WriteLine("Toplam Tutar : " + totalPrice + " TL");

            #endregion

            #region DoubleInputs

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region CharachterInputs

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.ReadLine();

        }
    }
}
