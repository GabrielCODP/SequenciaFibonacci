using System;

namespace SequênciaFibonacci
{
    class Program
    {
        static int fibonacciRecursivo(int tamanho) 
        {
            if (tamanho <= 1) // Se o número Fibonacci é menor ou igual a 0 (sempre começa do 0), então o valor e o proprio valor
                return tamanho;
            else
                return fibonacciRecursivo(tamanho - 1) + fibonacciRecursivo(tamanho - 2);
        }

        static int fibonacciOperadorTernario(int tamanho)
        {
            return (tamanho <= 1) ? tamanho : fibonacciOperadorTernario(tamanho - 1) + fibonacciOperadorTernario(tamanho - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(":::::::::::::::: Sequência de Fibonacci - Utilizando método recursivo::::::::::::::::");

            Console.Write("Informe o tamanho de N termos: ");
            int tamanho = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamanho; i++)
            {
                //if (i < tamanho-1) 
                //    Console.Write($"{fibonacciRecursivo(i)} + ");

                //else
                //{
                //    Console.Write($"{fibonacciRecursivo(i)}");
                //}

                Console.Write((tamanho - 1 > i) ? $"{fibonacciRecursivo(i)} + " : $"{fibonacciRecursivo(i)}");

            }

            Console.WriteLine("\n::::::::::::::::Sequência de Fibonacci - Operador Ternário::::::::::::::::");

            for (int i = 0; i < tamanho; i++)
                Console.Write((tamanho - 1 > i) ? $"{fibonacciOperadorTernario(i)} + " : $"{fibonacciOperadorTernario(i)}");

            Console.WriteLine("\n::::::::::::::::Sequência de Fibonacci - Utilizando For::::::::::::::::");



        }
    }
}
