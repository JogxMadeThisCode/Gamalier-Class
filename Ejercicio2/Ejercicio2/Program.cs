using System;

namespace sueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA DE PAGO");

            Console.WriteLine("\nIngrese el sueldo por hora");
            float sueldoPorHora = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las horas trabajadas");
            int horasTrabajadas = int.Parse(Console.ReadLine());

            float sueldoBruto = sueldoPorHora * horasTrabajadas;
            float AFP = (sueldoBruto * 2.84f) / 100;
            float SFS = (sueldoBruto * 3.04f) / 100;
            float TotalDescuentos = AFP + SFS;
            float sueldoNeto = sueldoBruto - TotalDescuentos;

            Console.WriteLine("Sueldo Bruto: " + (sueldoBruto));
            Console.WriteLine("Descuento AFP: " + (AFP));
            Console.WriteLine("Descuento SFS: " + (SFS));
            Console.WriteLine("Sueldo Neto: " + (sueldoNeto));

        }

    }
}