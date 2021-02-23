using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int not1 = 0, not2 = 0, not3 = 0;
            double prom;
            string notas, snot1, snot2, snot3;
            bool error1 = true;
            while (error1 == true)
            {
                try
                {
                    Console.WriteLine("Por favor ingrese las calificaciones en el formato: a,b,c (9,8,10)");
                    notas = Console.ReadLine();
                    snot1 = notas.Substring(0, notas.IndexOf(','));
                    snot2 = notas.Substring(snot1.Length + 1, notas.IndexOf(','));
                    snot3 = notas.Substring(snot1.Length + snot2.Length + 2, notas.IndexOf(','));
                    not1 = int.Parse(snot1);
                    not2 = int.Parse(snot2);
                    not3 = int.Parse(snot3);
                    error1 = false;
                }
                catch (FormatException error)
                {
                    error1 = true;
                    Console.Clear();
                    Console.WriteLine(error.ToString() + '\n');
                }
            }
            prom = (not1 + not2 + not3) / 3;
            if (prom >= 7)
            {
                Console.WriteLine("\n\nPromocionado");
            }
            else if (prom >= 4)
            {
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
