using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsDemo
{
    class CustomerManager
    {

        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri veri tabanına eklendi." +customer.FirstName + customer.LastName);

        }


        public void List(Customer customer)
        {
            Console.WriteLine("Müşteri listelendi" + customer.FirstName + customer.LastName);
        }


        public void Deleted(Customer customer)
        {
            Console.WriteLine("Müşteri silindi." + customer.FirstName + customer.LastName);
        }
      



    }
}
