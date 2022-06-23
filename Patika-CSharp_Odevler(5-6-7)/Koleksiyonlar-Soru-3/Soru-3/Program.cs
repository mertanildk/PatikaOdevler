using System;
using System.Collections;

namespace Soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru - 3: Klavyeden girilen cümle içerisindeki
            //sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            Console.Write("Cümle Giriniz: ");
            string cumle=Console.ReadLine();
            ArrayList CumleIcısesliHarfler = new ArrayList() ;
            string sesli = "eaıioöuü";
            for (int i = 0; i < cumle.Length; i++)
            {
                for (int ik = 0; ik < sesli.Length; ik++)
                {
                    if (cumle[i] == sesli[ik])
                    {
                        CumleIcısesliHarfler.Add(cumle[i]);



                    }
                }
               
            }

            ArrayList sesliHarfler = new ArrayList();
            foreach (var item in CumleIcısesliHarfler)
            {

                if (sesliHarfler.Contains(item))
                {
                    continue;
                }
                sesliHarfler.Add(item);

            }
            sesliHarfler.Sort();
            foreach (var item in sesliHarfler)
            {
                Console.Write(item+" ");
            }



        }
    }
}
