using System;

namespace TabuadaPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Seja bem vindo ao Tabuada PRO!");
            Console.WriteLine("Você gostaria de ver a tabuada de qual número? ");
            //Numero digitado pelo usuario
            int tab = Convert.ToInt32(Console.ReadLine());
            Console.Clear(); //Limpa tela
            Console.WriteLine("Segue abaixo a tabuada do número " + tab + "\n");
            for (int l = 1; l < 11; l++)
            {
                //Tabuada do numero digitado pelo usuario
                Console.WriteLine(tab + " X " + l + " = " + tab * l);
            }
            Console.ReadKey();
        }
    }
}
