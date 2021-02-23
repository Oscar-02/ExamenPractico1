using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, num3 = 0;
            string num, snum1, snum2, snum3;
            bool error1 = true;
            while (error1 == true)
            {
                try
                {
                    Console.WriteLine("Ingrese la cadena de numeros que ingresara en el siguiente formato: a,b,c (1,2,3)");
                    num = Console.ReadLine();
                    snum1 = num.Substring(0, num.IndexOf(','));
                    snum2 = num.Substring(snum1.Length + 1, num.IndexOf(','));
                    snum3 = num.Substring(snum1.Length + snum2.Length + 2, num.IndexOf(','));
                    num1 = int.Parse(snum1);
                    num2 = int.Parse(snum2);
                    num3 = int.Parse(snum3);
                    error1 = false;
                }
                catch (Exception error)
                {
                    error1 = true;
                    Console.Clear();
                    Console.WriteLine(error.ToString() + '\n');
                }
            }
            Console.Clear();
            Console.WriteLine("Tus numeros ingresados fueron: " + num1 + ", " + num2 + " y " + num3);
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);
            }
            Console.WriteLine("\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
