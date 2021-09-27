using System;

namespace ClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ertuğrul ";
            customer1.LastName = "Alp";
            customer1.BirthYear = 2002;
            customer1.IdentifyNo = "48541901462";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Mehmet ";
            customer2.LastName = "Öztürk";
            customer2.BirthYear = 1978;
            customer2.IdentifyNo = "43442424242";

            Customer customer3= new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Melisa ";
            customer3.LastName = "Demir";
            customer3.BirthYear = 1990;
            customer3.IdentifyNo = "58524324234";


            Console.WriteLine(customer1.Id + " " + customer1.FirstName+ " " + customer1.LastName);
            Console.WriteLine(customer2.Id + " " + customer2.FirstName+ " " + customer2.LastName);
            Console.WriteLine(customer3.Id + " " + customer3.FirstName+ " " + customer3.LastName);


            Customer[] customers = new Customer[] {customer1,customer2 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.BirthYear);
                Console.WriteLine(customer.IdentifyNo);

            }


            Console.WriteLine("-------------------Customer1--------------------------");

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Add(customer1);
            customerManager1.List(customer1);
            customerManager1.Deleted(customer1);


            Console.WriteLine("-------------------Customer 2 --------------------------");

            CustomerManager customerManager2 = new CustomerManager();
            customerManager2.Add(customer2);
            customerManager2.List(customer2);
            customerManager2.Deleted(customer2);

        }
    }
}
