using System;
using System.Collections.Generic;

namespace ToDo
{
    public class Operation
    {
        ToDo toDo = new ToDo();
        person person = new person();


        public void DefaultPerson()
        {
            person.Add("1", "Mert", "Anil");
            person.Add("2", "Şevval", "Kesen");
            person.Add("2", "Ayşe", "Karayılan");
            person.Add("2", "Cafer", "Gönlüaz");

        }

        public void DefaultCard()
        {
            toDo.Add("Ders", "Todo Tamamlanacak", "1", "2");
            toDo.Add("Derss", "Sinavlar calişilacak", "1", "3");
        }
        public void start()
        {
            Console.WriteLine("Lutfen yapmak istediğiniz işlemi seciniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşimak");
            Console.WriteLine("(5) Programi Kapat");
        }

        public void add()
        {
            Console.WriteLine("Card Ekleme Bölumu");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Kart Başliğini Giriniz");
            string baslik = Console.ReadLine();
            Console.WriteLine("Kart Iceriğini Giriniz");
            string icerik = Console.ReadLine();
        i:
            Console.WriteLine("Kart Sahibinin ID'sini Giriniz");
            string id = Console.ReadLine();
            if (!person.varmi(id))
            {
                Console.WriteLine("Yanliş bir id girdiniz");
                goto i;
            }
        b:
            Console.WriteLine("Kart Buyukluğunu Giriniz --> XS(1),S(2),M(3),L(4),XL(5)");
            string boy = Console.ReadLine();
            if (int.Parse(boy) < 1 || int.Parse(boy) > 5)
            {
                Console.WriteLine("yanliş bir buyukluk girdiğiniz 1-5 arasinda secim yapiniz");
                goto b;
            }
            toDo.Add(baslik, icerik, id, boy);
            Console.WriteLine("Işlem Başariyla Gercekleşti");
        }

        public void listele()
        {
            List<CardModel> list = toDo.Liste();
            Console.WriteLine("Kartlari Göruntuleme Bölumu");
            Console.WriteLine("*******************************************");
            Console.WriteLine("TODO Line");
            Console.WriteLine("*******************************************");
            foreach (var item in list)
            {
                if (item.Durum1 == 0)
                {
                    Console.WriteLine("Başlik =  {0}", item.Baslik1);
                    Console.WriteLine("Icerik  = {0}", item.Icerik1);
                    Console.WriteLine("Kart Sahibi = {0}", person.Find(item.KartSahibi1));
                    Console.WriteLine("kart Buyukluğu = {0}",int.Parse(item.Buyukluk1));
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("*******************************************");
            foreach (var item in list)
            {
                if (item.Durum1 == 1)
                {
                    Console.WriteLine("Başlik =  {0}", item.Baslik1);
                    Console.WriteLine("Icerik  = {0}", item.Icerik1);
                    Console.WriteLine("Kart Sahibi = {0}", item.KartSahibi1);
                    Console.WriteLine("kart Buyukluğu = {0}", item.Buyukluk1);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" DONE Line");
            Console.WriteLine("*******************************************");
            foreach (var item in list)
            {
                if (item.Durum1 == 2)
                {
                    Console.WriteLine("Başlik =  {0}", item.Baslik1);
                    Console.WriteLine("Icerik  = {0}", item.Icerik1);
                    Console.WriteLine("Kart Sahibi = {0}", item.KartSahibi1);
                    Console.WriteLine("kart Buyukluğu = {0}", item.Buyukluk1);
                }
            }

        }

        public void Delete()
        {
            List<CardModel> list = new List<CardModel>();
            Console.WriteLine("Kartlari Silme Bölumu");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Silmek istediğiniz kartin başliğini giriniz");
            String veri = Console.ReadLine();
            list = toDo.Find(veri, "", "", "");
            if (list.Count <= 0)
            {
                Console.WriteLine("Aradiğiniz Card Bulunamadi");
                Console.WriteLine("Tekrar Denemek Icin (1)");
                Console.WriteLine("Işlemi Iptal etmek icin (2)");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi == 1)
                {
                    Delete();
                }
                if (sayi == 2)
                {

                }
            }
            else
            {
                Console.WriteLine("{0} kart i silmek istiyor musunuz Y/N", list[0].Baslik1);
                string YN = Console.ReadLine();
                if (YN == "Y")
                {
                    toDo.Delete(list[0]);
                    Console.WriteLine("Işlem Başariyla Gercekleşti");
                }
                else
                {
                    Console.WriteLine("Işlem Başariyla Iptal Edildi");
                }
            }
        }

        public void transfer()
        {
            List<CardModel> list = new List<CardModel>();
            Console.WriteLine("Kart Taşima Bölumu");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Taşimak istediğiniz kartin kart başliğini giriniz");
            string veri = Console.ReadLine();
            list = toDo.Find(veri, "", "", "");
            if (list.Count <= 0)
            {
                Console.WriteLine("Aradiğiniz Card Bulunamadi");
                Console.WriteLine("Tekrar Denemek Icin (1)");
                Console.WriteLine("Işlemi Iptal etmek icin (2)");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi == 1)
                {
                    transfer();
                }
                if (sayi == 2)
                {

                }
            }
            else
            {
                Console.WriteLine("Bulunan kart bilgiler");
                Console.WriteLine("*******************************************");
                foreach (var item in list)
                {
                    Console.WriteLine("Başlik =  {0}", item.Baslik1);
                    Console.WriteLine("Icerik  = {0}", item.Icerik1);
                    Console.WriteLine("Kart Sahibi = {0}", item.KartSahibi1);
                    Console.WriteLine("kart Buyukluğu = {0}", item.Buyukluk1);
                    Console.WriteLine("Durum = {0}", item.Durum1);
                    Console.WriteLine("****** ****** ****** ******");
                l:
                    Console.WriteLine("Lutfen taşimak istediğiniz Durum'u seciniz");
                    Console.WriteLine("(0) TODO");
                    Console.WriteLine("(1) IN PROGRESS");
                    Console.WriteLine("(2) DONE");

                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi < 0 || sayi > 2)
                    {
                        Console.WriteLine("Yanliş bir Buyukluk sectiniz");
                        goto l;
                    }
                    item.Durum1 = sayi;
                }
            }
        }
    }
}