using System;

namespace fibonacciVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, number;
             Console.Write("Insira o numero de vezes para o calculo: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printando 0 e 1    
            for (i = 2; i < number; ++i) //loop começa no 2 por que 0 and 1 já estão printados    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

            Console.ReadLine();
        }
    }
}
