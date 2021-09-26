using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";


            //array = dizi 

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", 
               "Programlamaya başlangıç için temel kurs","Java","Python","C#"};



                   //Başla //Şart //Artış
            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            //foreach dizilerdeki elemanları tek tek dolaşıyor.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
