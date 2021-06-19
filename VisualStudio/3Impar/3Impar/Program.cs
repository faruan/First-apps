using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("Algoritmo para verificar se o número digitao é impar ou par \n");
            Console.Write("Informe um número: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0 )
            {
                Console.WriteLine($"\nO número {n} é par");
            }
            else
            {
                Console.WriteLine($"\nO número {n} é impar");
            }
            Console.ReadKey();
            
        }
    }
}
