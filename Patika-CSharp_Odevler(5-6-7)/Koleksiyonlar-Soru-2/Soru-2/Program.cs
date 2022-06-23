using System;
using System.Collections;

namespace Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi 
             * ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan 
             * ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
             */
            ArrayList sayilar = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Console.Write((i+1)+". Sayıyı Giriniz: ");
                sayilar.Add(int.Parse(Console.ReadLine()));
                
            }
            sayilar.Sort();
            ArrayList buyukler= new ArrayList() {sayilar.Count-1, sayilar.Count - 2, sayilar.Count - 3 };
            ArrayList kucukler = new ArrayList() { sayilar[0], sayilar[1], sayilar[2] };
            int kucuklerToplam = 0;
            int buyuklerToplam = 0;
            
            for (int i = 0; i < 3; i++)
            {
                kucuklerToplam += (int)kucukler[i];
                buyuklerToplam +=(int)buyukler[i];
            }
           
            Console.WriteLine();
            Console.WriteLine("Girilen En Küçük 3 Sayının Ortalaması: "+kucuklerToplam/kucukler.Count);
            Console.WriteLine();
            Console.WriteLine("Girilen En Büyük 3 Sayının Ortalaması: " + buyuklerToplam / buyukler.Count);
            Console.WriteLine();
            int ikiGrupOrt=(kucuklerToplam / kucukler.Count)+(buyuklerToplam / kucukler.Count);
            Console.WriteLine("Küçük Sayıların ve Büyük Sayıların Ortalama Toplamları:  " + ikiGrupOrt);

        }
    }
}
