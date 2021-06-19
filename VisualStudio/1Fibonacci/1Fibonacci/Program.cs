using System;

namespace _1Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 0;
            int soma = 0;

            for (int i = 1; i < 20; i++)
            {
                soma = n1 + n2;
                n2 = n1;
                n1 = soma;
                Console.WriteLine("A sequencia de Fibonacci é: " +soma );
            }
        }

    }
}
