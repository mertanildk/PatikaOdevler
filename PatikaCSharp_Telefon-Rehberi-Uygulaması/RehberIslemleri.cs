using System;
using System.Collections.Generic;
using System.Linq;

namespace PatikaCSharp_Telefon_Rehberi_Uygulaması
{
    class RehberIslemleri
    {
        public List<Rehber> rehber = new List<Rehber>();
        public void NumaraEkle(string name, string surName, string phoneNumber)
        {
            Rehber yeniKayit = new Rehber();
            yeniKayit.Name = name;
            yeniKayit.PhoneNumber = phoneNumber;
            yeniKayit.SurName = surName;
            this.rehber.Add(yeniKayit);
        }
        public void NumaraSil(string surName, string name, string phoneNumber)
        {
            Rehber silinecekNumara = rehber.Where(x => x.Name == name).FirstOrDefault();
            if (silinecekNumara != null)
            {
                rehber.Remove(silinecekNumara);
            }
            else
            {
                Console.WriteLine("Numara Bulunamadı...");
            }

        }
        public void Guncelle(Rehber guncellenecekNumara,string numara)
        {
            guncellenecekNumara.PhoneNumber = numara;
           
          
                
           
            

        }
        public Rehber AdSoyadArama(string veri)
        {
            Rehber rehberdeMi = rehber.Where(x => x.Name == veri).FirstOrDefault();
            if (rehberdeMi == null)
            {
                Rehber rehberdeMi1 = rehber.Where(x => x.SurName == veri).FirstOrDefault();
                if (rehberdeMi1!=null)
                {
                    return rehberdeMi1;

                }
                
            }
            return rehberdeMi;
        }






    }
}
