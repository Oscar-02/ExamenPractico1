using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool error1 = true;
            int cant = 0;
            double precio = 0, total = 0;
            while (error1 == true)
            {
                try
                {
                    Console.WriteLine("Por favor ingrese la cantidad de articulos...");
                    cant = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Cantidad de Productos Ingresados: " + cant + '\n');
                    Console.WriteLine("Ingrese el precio unitario de cada producto...");
                    precio = double.Parse(Console.ReadLine());
                    Console.Clear();
                    error1 = false;
                }
                catch (Exception error)
                {
                    Console.Clear();
                    Console.WriteLine(error.ToString() + '\n');
                    error1 = true;
                }
            }
            Console.Clear();
            Console.WriteLine("Cantidad de Productos Ingresados: " + cant);
            Console.WriteLine("Precio Unitario del Producto: $" + precio);
            total = cant * precio;
            Console.WriteLine("Total: $" + total + " (Nro. Productos: " + cant + ')');
            Console.WriteLine("\nPresione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
