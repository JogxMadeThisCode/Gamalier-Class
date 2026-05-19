using System;

namespace ImporteProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMPORTE DE PRODUCTO");

            Console.Write("\nIntroduce el precio del articulo: ");
            if (precio != int)
            {
                Console.WriteLine("El precio debe ser un número válido.");
                return;
            }
            else {
                float precio = float.Parse(Console.ReadLine());

                Console.Write("Introduce la cantidad: ");
                float cantidad = float.Parse(Console.ReadLine());

                float importe = precio * cantidad;
                Console.WriteLine("El importe total es: " + importe);
            }
        }
    }
}