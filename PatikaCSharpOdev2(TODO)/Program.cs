using System;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.DefaultCard();
            operation.DefaultPerson();
            operation.start();
            bool kontrol = true;
            while (kontrol)
            {
                Console.Write("Lütfen 1 - 5 Arasında Bir İşlem Seçiniz: ");
                string no = Console.ReadLine();
                
               
                switch (no)
                {
                    case "1":
                        operation.listele();
                        break;
                    case "2":
                        operation.add();
                        break;
                    case "3":
                        operation.Delete();
                        break;
                    case "4":
                        operation.transfer();
                        break;
                    case "5":
                        kontrol = false;
                        break;
                    default:
                        Console.WriteLine("Hatalı Giriş... Tekrar Deneyin");
                        break;
                }
            }
        }
    }
}