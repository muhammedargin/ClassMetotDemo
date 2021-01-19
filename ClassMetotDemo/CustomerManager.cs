using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ClassMetotDemo
{
    
    public class CustomerManager
    {
        public ArrayList customerList = new ArrayList();
        public CustomerManager()
        {
            Console.WriteLine("CustomerManager has been created\n");
            
        }
    

         public void Add(Customer Id)
        {
            customerList.Add(Id);
            //return "Customer adding is completed successfully.";
            Console.WriteLine("Customer has been added.\n");
           
        }

        public void ShowList()
        {
            Console.WriteLine("ShowList method has been processed.");
            foreach (var showElement in customerList) 
            {
                Console.WriteLine("Okunan Müşteri ıd :"+ showElement);

            }

        }

        public void Remove(Customer Id)
        {
            customerList.Remove(Id);
            Console.WriteLine("Customer has been removed.\n");

        }


    }
}
