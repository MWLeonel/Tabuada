using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um Número: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(numero + " * " + x + " = " + numero * x);
            }
        }
    }
}
