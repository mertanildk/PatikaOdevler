using System;
using System.Collections;

namespace Soru1
{
    class Program
    {

        //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

        //Negatif ve numeric olmayan girişleri engelleyin.
        //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
        static void Main(string[] args)
        {
            int adet = SayiMi("Kaç Adet Sayı Girişi Yapacaksınız: ");
            ArrayList asal = new ArrayList();
            ArrayList asalDegil = new ArrayList();
            Console.WriteLine();
            for (int i = 0; i < adet; i++)
            {

                int sayi = SayiMi((i + 1) + ". Sayıyı Giriniz: ");
                Console.WriteLine();
                if (asalMi(sayi))
                {
                    asal.Add(sayi);
                }
                else
                {
                    asalDegil.Add(sayi);
                }

            }
            Console.WriteLine();

            asal.Sort();

            Console.WriteLine("-----ASAL SAYILAR-----");
            Console.WriteLine();
            double total = 0;
            Console.Write("      ");
            foreach (var item in asal)
            {
                
                Console.Write(item + " ");
                total += (int)item;
            }
            Console.WriteLine();
            Console.WriteLine("Asal ArrayList Eleman Sayısı: " + asal.Count);
            Console.WriteLine();

            Console.WriteLine("Asal ArrayList Ortalaması:  " + (total / asal.Count));
            Console.WriteLine();

            asalDegil.Sort();
            Console.WriteLine("-------ASAL OLMAYAN SAYILAR-------");
            Console.WriteLine();

            total = 0;
            Console.Write("      ");
            foreach (var item in asalDegil)
            {
                
                Console.Write(item + " ");
                total+=(int)item;
            }
            Console.WriteLine();
            Console.WriteLine("Asal Olmayan ArrayList Eleman Sayısı: " + asalDegil.Count);
            Console.WriteLine();

            Console.WriteLine("Asal Olmayan ArrayList Ortalaması:  " + (total / asalDegil.Count));
            Console.WriteLine();

        }
        public static int SayiMi(string mesaj)
        {
            do
            {

                int sayi;

                Console.Write(mesaj);
                string giris = Console.ReadLine();
                if (int.TryParse(giris, out sayi) && sayi > 0)
                {
                    return sayi;
                }
                else
                {
                    Console.WriteLine("Lütfen Pozitif Bir Tamsayi Giriniz...");
                }

            } while (true);

        }
        public static bool asalMi(int sayi)
        {

            if (sayi < 2)
            {
                return false;
            }
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            return true;


        }

    }
}
