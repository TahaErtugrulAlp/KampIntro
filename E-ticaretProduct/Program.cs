using System;

namespace E_ticaretProduct
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.name = "Life q10";
            product1.type = "kulaklık";
            product1.brand = "Anker";
            product1.price = 369;

            Product product2 = new Product();
            product2.Id = 2;
            product2.name = "13 pro";
            product2.type = "Akıllı telefon";
            product2.brand = "Iphone";
            product2.price = 13000;

            Product product3 = new Product();
            product3.Id = 3;
            product3.name = "Sm-619";
            product3.type = "Kablosuz mouse";
            product3.brand = "Everest";
            product3.price = 100;


            Product[] products = new Product[] {product1,product2,product3};

            foreach (Product product in products)
            {
                Console.WriteLine(product.name +" "+product.type);

            }

            Console.WriteLine("Foreach bitti.");

            //Environment.NewLine sıralarken lazım oluyor. ürünleri numaralama işini görüyor.

            for (int i = 0; i <products.Length; i++)
            {
                Console.WriteLine(products[i].Id + Environment.NewLine + products[i].name + Environment.NewLine+ products[i].type + Environment.NewLine + products[i].brand+ Environment.NewLine,+products[i].price);

            }

            Console.WriteLine("For bitti");

            int count = 0;    //count = saymak 
            while (count<products.Length)
            {
                Console.WriteLine(products[count].Id + Environment.NewLine + products[count].name+Environment.
                NewLine+products[count].type+Environment.NewLine+products[count].brand+Environment.NewLine+products[count].price);
                count++;

            }

            Console.WriteLine("While Döngü bitti");





        }

        class Product
        {
            public int Id { get; set; }
            public string name { get; set; }
            public string type{ get; set; }
            public string brand { get; set; }
            public int price { get; set; }


        }







    }
}
