using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace ClassMetotDemo
{
    public class Program
    {
        public ArrayList customerList = new ArrayList();
        static void Main(string[] args)
        {   //müşteri oluşturulacak
            Customer margin1690 = new Customer();
            //özellikler tanımlanacak
            margin1690.setName = "Muhammed";
            margin1690.setSurname = "ARGİN";
            margin1690.setRegion = "Bursa";
            //customerManager oluşturulacak
            CustomerManager manager1 = new CustomerManager();
            // showList çağırılıp listenin boş olduğu görülecek
            Console.WriteLine("Show list checked,it's must be empty");
            manager1.ShowList();
            Console.WriteLine("------------------------------------");
            //ekleme işlemi yapılacak
            manager1.Add(margin1690);
            //show çağırılıp neler var görülecek
            manager1.ShowList();
            Console.WriteLine("------------------------------------");
            //ikinci müşteri üretilip ikinci ekleme yapılacak
            Customer zyargin6060 = new Customer();
            zyargin6060.setName = "Zeynep";
            zyargin6060.setSurname = "Argin";
            zyargin6060.setRegion = "Bursa";
            manager1.Add(zyargin6060);
            manager1.ShowList();
            Console.WriteLine("------------------------------------");
            //silme işlemi yapılacak
            manager1.Remove(zyargin6060);
            //silme işleminden sonra neler var görülecek
            manager1.ShowList();
            Console.WriteLine("------------------------------------");
            



            

        }
    }
}
