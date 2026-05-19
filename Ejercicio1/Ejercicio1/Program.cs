using System;

namespace Calcular2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce 2 numeros para ver los resultados:");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Suma: " + (num1 + num2));
            Console.WriteLine("Resta: " + (num1 - num2));
            Console.WriteLine("Multiplicacion: " + (num1 * num2));
            Console.WriteLine("Division: " + (num1 / num2));
        }
    }
}