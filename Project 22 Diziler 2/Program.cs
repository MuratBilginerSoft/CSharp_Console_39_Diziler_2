using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_22_Diziler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Takımlar = new string[1];

            int TS;

            Console.WriteLine("Kaç Takım Olucak");
            TS = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dizinin Uzunluğu:{0}",Takımlar.Length);

            // Array.Resize(ref Dizinin_İsmi, Dizinin_YeniDeğeri);

            Takımlar[0] = "Galatasaray";
            
            Array.Resize(ref Takımlar, TS);

            Console.WriteLine("Dizinin Uzunluğu:{0}", Takımlar.Length);

           
            // String Bir Değişken Aynı Zamanda Bir Dizidir.

            string Kelime = "Industryolog";

            Console.WriteLine(Kelime[0]);

            Console.ReadKey();

        }
    }
}
