using System;
using System.Collections.Generic;
using System.Linq;

namespace PatikaCSharp_Telefon_Rehberi_Uygulaması

{
    class Uygulama
    {
        int sayac = 0;
        public RehberIslemleri rehberIslemleri = new RehberIslemleri();
        public AracGerec aracgerec = new AracGerec();
        public void Run()
        {
            if (sayac <= 0)
            {
                DummyData();
                sayac++;
            }

            Menu();
            SecimAl();

        }
        public void SecimAl()
        {

            while (true)
            {
                Console.Write("Seçiminiz: ");
                string giris = Console.ReadLine().TrimEnd();
                Console.WriteLine();
                switch (giris)
                {
                    case "1":
                        NumaraEkle();
                        break;
                    case "2":
                        NumaraSil();
                        break;
                    case "3":
                        NumaraGuncelle();
                        break;
                    case "4":
                        RehberiListele("HEPSINILISTELE");
                        break;
                    case "5":
                        RehberdeAramaYap();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Hatalı Giriş Yapıldı...");
                        break;
                }
                Console.WriteLine();
            }

        }
        public void NumaraEkle()
        {

            string isim = aracgerec.BasHarfBuyut(aracgerec.BosGirisKontrol("Lütfen isminizi giriniz       :"));

            string soyIsim = aracgerec.BasHarfBuyut(aracgerec.BosGirisKontrol("Lütfen soyisim giriniz       :"));

            string numara = aracgerec.NumaraKontrol("Lütfen telefon numarası giriniz :");
            Console.WriteLine();

            Console.Write("Kaydetmek istediğinize emin misiniz? :[E/H] ");
            
            string kayitKarari = Console.ReadLine().ToUpper();
            Console.WriteLine();
            if (kayitKarari == "E")
            {
                new RehberIslemleri().NumaraEkle(isim, soyIsim, numara);
                Console.WriteLine("Numara Başarıyla Kaydedildi.");

            }
            else
            {
                Console.WriteLine("Numara kaydedilemedi...");
            }



        }

        public void NumaraSil()
        {
            do
            {
                Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string kisi = aracgerec.BasHarfBuyut(Console.ReadLine());
                Rehber silinecekNumara = rehberIslemleri.AdSoyadArama(kisi);
                if (silinecekNumara == null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine(" * Silmeyi sonlandırmak için : (1)\n * Yeniden denemek için: (2)");
                    Console.WriteLine();
                    Console.Write("Seçiminiz: ");
                    string karar = Console.ReadLine();
                    if (karar == "1")
                    {
                        Run();
                    }

                }
                else
                {
                    Console.Write("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? (y/n): ", silinecekNumara.Name + " " + silinecekNumara.SurName);
                    string karar = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    if (karar == "Y")
                    {
                        rehberIslemleri.NumaraSil(silinecekNumara.SurName, silinecekNumara.Name, silinecekNumara.PhoneNumber);
                        Console.WriteLine("Numara Başarıyla Silinmiştir...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Rehberden kimse silinmedi...");
                        break;
                    }

                }


            } while (true);
        }
        public void NumaraGuncelle()
        {

            {
                do
                {
                    Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
                    string kisi = aracgerec.BasHarfBuyut(Console.ReadLine());
                    Rehber guncellenecekkNumara = rehberIslemleri.AdSoyadArama(kisi);
                    if (guncellenecekkNumara == null)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine(" * Güncellemeyi sonlandırmak için : (1)\n * Yeniden denemek için: (2)");
                        Console.WriteLine();
                        Console.Write("Seçiminiz: ");
                        string karar = Console.ReadLine();
                        if (karar == "1")
                        {
                            Run();
                        }

                    }
                    else
                    {
                        Console.WriteLine("{0} isimli kişi için", guncellenecekkNumara.Name + " " + guncellenecekkNumara.SurName);
                        string numara = aracgerec.NumaraKontrol("Lütfen yeni bir telefon numarası giriniz :");
                        Console.WriteLine();

                        Console.Write("{0} isimli kişi Güncellenmek üzere , onaylıyor musunuz ? (y/n): ", guncellenecekkNumara.Name + " " + guncellenecekkNumara.SurName);
                        string karar = Console.ReadLine().ToUpper();
                        Console.WriteLine();
                        if (karar == "Y")
                        {
                            rehberIslemleri.Guncelle(guncellenecekkNumara,numara);
                            Console.WriteLine("Numara Başarıyla Güncelenmiştir...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Numara güncellenmemiştir...\n" +
                                "Menüye Aktarılıyorsunuz");
                            Console.WriteLine();
                            Run();
                        }

                    }


                } while (true);
            }
        }


        public void RehberiListele(string veri)
        {
            if (veri == "HEPSINILISTELE")
            {
                Console.WriteLine("A-Z Sıralaması için (1) : ");
                Console.WriteLine("Z-A Sıralaması için (2) : ");
                string karar = aracgerec.NumaraKontrol("Seçiminiz: ");
                List<Rehber> list = rehberIslemleri.rehber.OrderByDescending(x => x.Name).ToList();
                if (karar=="2")
                {
                    list.Reverse();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Yanlış Giriş yapıldı otomatik olarak A-Z sıralandı...");
                    Console.WriteLine();
                }
                if (list.Count != 0)
                {
                    foreach (var item in list)
                    {
                        Console.WriteLine("İsim: " + item.Name + "\nSoyisim: " + item.SurName + "\nTelefon Numarası: " + item.PhoneNumber + "\n-");
                    }

                }
                else
                {
                    Console.WriteLine("Listelenecek Herhangi Bir Öğrenci Bulunamadı...");
                }
            }
        


        }

        public void RehberdeAramaYap()
        {
            Rehber aranan=null;
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string karar = aracgerec.NumaraKontrol("Seçiminiz: ");
            if (karar == "1")
            {
                string kisiAdiveyaSoyadi =aracgerec.BasHarfBuyut(aracgerec.BosGirisKontrol("Adını veya Soyadını Giriniz: "));
                aranan = rehberIslemleri.AdSoyadArama(kisiAdiveyaSoyadi);
                

            }
            else if (karar == "2")
            {
                string kisiTelefon = aracgerec.BosGirisKontrol(aracgerec.BasHarfBuyut("Telefon numarasını Giriniz: "));
                aranan = rehberIslemleri.rehber.Where(x => x.PhoneNumber == kisiTelefon).FirstOrDefault();

            }
            if (aranan==null)
            {
                Console.WriteLine("Aradığınız Kişiyi Bulamadık...");
                
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("\nİsim: " + aranan.Name + "\nSoyisim: " + aranan.SurName + "\nTelefon Numarası: " + aranan.PhoneNumber);
                }
               
            }

            





        }


        public void Menu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(6) Cikis Yap ");

        }
        public void DummyData()
        {
            rehberIslemleri.NumaraEkle("Mert Anıl", "Deke", "5312932389");
            rehberIslemleri.NumaraEkle("Mert Anıl", "Deke", "5312932389");
            rehberIslemleri.NumaraEkle("Yasemin", "Deke", "5322525621");
            rehberIslemleri.NumaraEkle("Şevval", "Kesen", "5367353263");
            rehberIslemleri.NumaraEkle("Cafer", "Caferoğlu", "5315324534");
            rehberIslemleri.NumaraEkle("Mürsel", "Numune", "5312923423");

        }
    }

}
