using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();  //class örneği
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasya Elması";


            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 40;
            product2.Explanation = "Diyarbakır karpuzu";

            Product[] products = new Product[] {product1,product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("-----------------------");

            }


            Console.WriteLine("-------------Metotlar-----------");

            //instance - örnek class örneği 
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
           

        }
    }
}



//Methotlar tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
