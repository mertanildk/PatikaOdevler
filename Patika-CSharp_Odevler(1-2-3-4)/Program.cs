using System;
using System.Collections.Generic;
namespace Patika_CSharp_Odevler_1_2_3_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.Write("Kaç Adet Sayı Girmek İstersiniz: "); //BİLE İSTEYE DİZİ KULLANMAK İSTEDİM TEKRAR AMAÇLI
            string giris = Console.ReadLine();
            if (int.TryParse(giris, out int adet))
            {
                int[] pozitifSayilar = new int[adet];
                for (int i = 0; i < adet; i++)
                {
                    Console.Write((i + 1) + ". Sayıyı Giriniz: ");
                    string veri = Console.ReadLine();
                    if (!int.TryParse(veri, out int sayi))
                    {
                        i--;
                        continue;
                    }
                    if (sayi == 0 || sayi % 2 == 0)
                    {
                        pozitifSayilar[i] = sayi;

                    }


                }
                foreach (var item in pozitifSayilar)
                {
                    if (item != 0)
                    {
                        Console.Write(item + " ");

                    }
                }

            }


            //2.Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.Write("Bir sayı Giriniz: "); //BİLEREK VE İSTEYEREK CEVAPLARI UZATIYORUM BİR ŞEYLER DENEMEK İSTİYORUM FIRSAT BU FIRSAT :-]
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Kaç Adet Sayı Girmek İstersiniz: ");
            int adet1 = int.Parse(Console.ReadLine());
            string yazdir = "";

            for (int i = 0; i < adet1; i++)
            {

                Console.Write((i + 1) + ".Sayıyı Giriniz: ");
                int deneme = int.Parse(Console.ReadLine());
                if (deneme == sayi1 || sayi1 % deneme == 0)
                {
                    yazdir += deneme.ToString() + " ";
                }


            }
            Console.WriteLine();
            string[] sayilar = yazdir.Split(' ');
            if (sayilar.Length != 0)
            {

                Console.Write($"{sayi1}.Sayısı ve Tam Bölenleri.:===>>>>");
                Console.WriteLine();
                for (int i = 0; i < sayilar.Length; i++)
                {
                    Console.Write(" " + sayilar[i]);
                }

            }

            //3.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            ////Sonrasında kullanıcıdan n adet kelime girmesi isteyin.Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.Write("Bir Sayı Giriniz: ");
            int adet2 = int.Parse(Console.ReadLine());
            List<string> elemanCeviren = new();
            List<string> list = new List<string>();

            for (int i = 0; i < adet2; i++)
            {
                Console.Write((i + 1) + ". Veriyi Giriniz: ");
                string yazi = Console.ReadLine();
                list.Add(yazi);

            }
            list.Reverse();
            Console.WriteLine();
            Console.WriteLine("---------------Sondan başa doğru sıralanmış hali------------------  ");
            Console.WriteLine();
            Console.Write("                     ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }









            //4.Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Bir Cümle Giriniz: ");
            string giris1 = Console.ReadLine();
            string[] dizi = giris1.Split(' ');
            Console.WriteLine(dizi.Length + " kelime sayısı");
            Console.WriteLine((giris.Length) - (dizi.Length - 1) + " harf sayisi");
        }
    }
}
