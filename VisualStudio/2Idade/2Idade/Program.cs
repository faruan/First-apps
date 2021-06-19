using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2, idade3, idade4, idade5, media;

            Console.WriteLine("Calculando a média de idades");
            Console.WriteLine();
            Console.Write("Informe a primeira idade: ");
            idade1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a segunda idade: ");
            idade2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a terceira idade: ");
            idade3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a quarta idade: ");
            idade4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a quinta idade: ");
            idade5 = Convert.ToInt32(Console.ReadLine());

            media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;
            Console.WriteLine("A média das idades é de: " + media);
            Console.ReadKey();
        }
    }
}
