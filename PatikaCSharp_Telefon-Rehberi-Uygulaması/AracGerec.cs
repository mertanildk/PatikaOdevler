using System;

namespace PatikaCSharp_Telefon_Rehberi_Uygulaması
{
    class AracGerec
    {
        public string NumaraKontrol(string mesaj)
        {
            while (true)
            {
                Console.Write(mesaj);
                string sayilar = "0123456789";
                string numara = Console.ReadLine();
                int bulunan = 0;
                numara.Replace(" ", "");
                for (int i = 0; i < numara.Length; i++)
                {
                    for (int k = 0; k < sayilar.Length; k++)
                    {
                        if (numara[i] == sayilar[k])
                        {
                            bulunan++;
                        }
                    }
                }
                if (bulunan != numara.Length)
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız...");
                }
                else
                {
                    return numara;
                }

            }

        }

        public string BosGirisKontrol(string mesaj)
        {
            while (true)
            {
                Console.Write(mesaj);
                string veri = Console.ReadLine();

                if (veri.Length >= 1) return veri;

                else Console.WriteLine("Boş Bırakılamaz...");
            }

        }

        public string BasHarfBuyut(string veri)
        {

            string[] dizi = veri.Split(' ');
            string cikanMetin = "";
            if (dizi.Length > 1)
            {

                for (int i = 0; i < dizi.Length; i++)
                {
                    if (dizi[i] != "")
                    {
                        cikanMetin += dizi[i].Substring(0, 1).ToUpper() + dizi[i].Substring(1).ToLower() + " ";

                    }
                }
                return cikanMetin.Trim();
            }
            return veri.Substring(0, 1).ToUpper() + veri.Substring(1).ToLower();
        }
        public string AdSoyadBirlestir(string ad, string soyad)
        {
            return ad + " " + soyad;

        }
    }
}
