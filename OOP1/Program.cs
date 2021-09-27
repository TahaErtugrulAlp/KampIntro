using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // İki tür class vardı. 1 özellik taşıtan classlar. 2 operasyon(metot) barındıran classlar.

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Laptop";
            product1.UnitPrice = 10000;
            product1.UnitsInStock = 8;


            Product product2 = new Product {Id=2,CategoryId=5,UnitsInStock=6,
             ProductName ="Kalem",UnitPrice = 35};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);



            //int, double,bool... deger tip
            //diziler,class ,abstract class,interface ... referans tip
            //ref out





           
        }
    }
}
