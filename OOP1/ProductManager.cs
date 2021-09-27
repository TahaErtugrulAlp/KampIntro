using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //Encapsulation
        //void ne işe yarıyor : Emir metotudur.( git ekle , git si vb.)
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }




    }
}
