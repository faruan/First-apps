using System;

namespace Tabuadapronta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop para numero de uma mesma coluna
            for (int c = 1; c < 10; c++)
            {
                Console.WriteLine("\nTabuada do " + c);
                //Loop para numeros que serão multiplicados pela coluna
                for (int l = 1; l < 10; l++)
                {
                    Console.WriteLine(c + " X " + l + " = " + c * l); //resultado das multiplicações
                }
            }
        }
    }
}
