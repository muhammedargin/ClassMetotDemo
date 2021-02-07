using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

 namespace  ClassMetotDemo
{
      public class Customer
    {
        private string customerName, customerSurname;
        private string customerRegion;
        
     
       

        public string Name
        {
            get { return customerName; }
            set { customerName = value; }

        }
        public string Surname
        {
            get { return customerSurname; }
            set { customerSurname = value; }

        }
        public string Region
        {
            get { return customerRegion; }
            set { customerRegion = value; }

        }

       

    }
}
