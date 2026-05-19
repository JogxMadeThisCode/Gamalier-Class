using System;
using System.Runtime.Intrinsics.X86;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA DE PROMEDIOS");

            Console.WriteLine("Ingrese 5 numeros: ");

            Console.Write("N. 1: ");
            float num1 = int.Parse(Console.ReadLine());
            Console.Write("N. 2: ");
            float num2 = int.Parse(Console.ReadLine());
            Console.Write("N. 3: ");
            float num3 = int.Parse(Console.ReadLine());
            Console.Write("N. 4: ");
            float num4 = int.Parse(Console.ReadLine());
            Console.Write("N. 5: ");
            float num5 = int.Parse(Console.ReadLine());

            float promedio = (num1 + num2 + num3 + num4 + num5) / 5;
            Console.WriteLine("El promedio de sus 5 numeros es: " + (promedio));

        }
    }
}