using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, nombre1 = null, nombre2 = null, nombre3 = null, horas, shoras1, shoras2, shoras3;
            int cargo1 = 0, cargo2 = 0, cargo3 = 0, horas1 = 0, horas2 = 0, horas3 = 0;
            double sbase1, sbase2, sbase3, descuento1, descuento2, descuento3, neto1, neto2, neto3;
            bool error2 = true, error3 = true;

            Console.WriteLine("Por favor inserte el nombre de los empleados en el siguiente formato:");
            Console.WriteLine("Empleado1,Empleado2,Empleado3 (Josue Barrera,Manuel Arce,Nick Rodriguez)");
            nombre = Console.ReadLine();
            nombre1 = nombre.Substring(0, nombre.IndexOf(','));
            nombre2 = nombre.Substring(nombre1.Length + 1, nombre.IndexOf(','));
            nombre3 = nombre.Substring(nombre1.Length + nombre2.Length + 2);

            Console.Clear();
            while (error2 == true)
            {
                Console.WriteLine("Nombres Ingresados: ");
                Console.WriteLine(nombre1 + '\n' + nombre2 + '\n' + nombre3 + '\n');
                Console.WriteLine("Por favor presione la tecla con el cargo que posee cada empleado...");
                Console.WriteLine("1. Gerente\n2. Asistente\n3. Secretaria\n4. Otro Cargo");
                Console.WriteLine("...para " + nombre1);
                char tecla = Console.ReadKey().KeyChar;
                if (tecla == '1')
                {
                    cargo1 = 1;
                    error2 = false;
                }
                else if (tecla == '2')
                {
                    cargo1 = 2;
                    error2 = false;
                }
                else if (tecla == '3')
                {
                    cargo1 = 3;
                    error2 = false;
                }
                else if (tecla == '4')
                {
                    cargo1 = 4;
                    error2 = false;
                }
                else
                {
                    Console.WriteLine("Has presionado una tecla no valida...Vuelvelo a intentar");
                }
            }
            Console.Clear();

            error2 = true;
            while(error2 == true)
            {
                Console.WriteLine("Nombres Ingresados: ");
                Console.WriteLine(nombre1 + '\n' + nombre2 + '\n' + nombre3 + '\n');
                Console.WriteLine("Por favor presione la tecla con el cargo que posee cada empleado...");
                Console.WriteLine("1. Gerente\n2. Asistente\n3. Secretaria\n4. Otro Cargo");
                Console.WriteLine("Valor Cargo de " + nombre1 + ": " + cargo1);
                Console.WriteLine("...para Empleado 2: ");
                char tecla = Console.ReadKey().KeyChar;
                if (tecla == '1')
                {
                    cargo2 = 1;
                    error2 = false;
                }
                else if (tecla == '2')
                {
                    cargo2 = 2;
                    error2 = false;
                }
                else if (tecla == '3')
                {
                    cargo2 = 3;
                    error2 = false;
                }
                else if (tecla == '4')
                {
                    cargo2 = 4;
                    error2 = false;
                }
                else
                {
                    Console.WriteLine("Has presionado una tecla no valida...Vuelvelo a intentar");
                }
            }
            Console.Clear();

            error2 = true;
            while (error2 == true)
            {
                Console.WriteLine("Nombres Ingresados: ");
                Console.WriteLine(nombre1 + '\n' + nombre2 + '\n' + nombre3 + '\n');
                Console.WriteLine("Por favor presione la tecla con el cargo que posee cada empleado...");
                Console.WriteLine("1. Gerente\n2. Asistente\n3. Secretaria\n4. Otro Cargo");
                Console.WriteLine("Valor Cargo de " + nombre1 + ": " + cargo1);
                Console.WriteLine("Valor Cargo de " + nombre2 + ": " + cargo2);
                Console.WriteLine("...para Empleado 3: ");
                char tecla = Console.ReadKey().KeyChar;
                if (tecla == '1')
                {
                    cargo3 = 1;
                    error2 = false;
                }
                else if (tecla == '2')
                {
                    cargo3 = 2;
                    error2 = false;
                }
                else if (tecla == '3')
                {
                    cargo3 = 3;
                    error2 = false;
                }
                else if (tecla == '4')
                {
                    cargo3 = 4;
                    error2 = false;
                }
                else
                {
                    Console.WriteLine("Has presionado una tecla no valida...Vuelvelo a intentar");
                }
            }
            Console.Clear();
            while(error3 == true)
            {
                try
                {
                    Console.WriteLine("Nombres Ingresados: ");
                    Console.WriteLine(nombre1 + '\n' + nombre2 + '\n' + nombre3 + '\n');
                    Console.WriteLine("Valor Cargo de " + nombre1 + ": " + cargo1);
                    Console.WriteLine("Valor Cargo de " + nombre2 + ": " + cargo2);
                    Console.WriteLine("Valor Cargo de " + nombre3 + ": " + cargo3);
                    Console.WriteLine("\nIngrese la cantidad de horas laboradas en el formato a,b,c (100,200,300)...");
                    horas = Console.ReadLine();
                    shoras1 = horas.Substring(0, horas.IndexOf(','));
                    shoras2 = horas.Substring(shoras1.Length + 1, horas.IndexOf(','));
                    shoras3 = horas.Substring(shoras1.Length + shoras2.Length + 2);
                    horas1 = int.Parse(shoras1);
                    horas2 = int.Parse(shoras2);
                    horas3 = int.Parse(shoras3);
                    error3 = false;
                }
                catch (FormatException error)
                {
                    error3 = true;
                    Console.Clear();
                    Console.WriteLine(error.ToString() + '\n');
                }
            }
            Console.WriteLine("\nNOMBRES INGRESADOS: ");
            Console.WriteLine(nombre1 + '\n' + nombre2 + '\n' + nombre3 + '\n');
            Console.WriteLine("Valor Cargo de " + nombre1 + ": " + cargo1);
            Console.WriteLine("Valor Cargo de " + nombre2 + ": " + cargo2);
            Console.WriteLine("Valor Cargo de " + nombre3 + ": " + cargo3);
            Console.WriteLine("\nHORAS LABORADAS:");
            Console.WriteLine(nombre1 + ": " + horas1);
            Console.WriteLine(nombre2 + ": " + horas2);
            Console.WriteLine(nombre3 + ": " + horas3);

            if (horas1 <= 0 || horas2 <= 0 || horas3 <= 0)
            {
                Console.WriteLine("Lo sentimos. Las horas laboradas no deben ser menores o iguales a 0. EL PROGRAMA SE CERARARA");
                Console.WriteLine("Presione cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            if (horas1 <= 160)
            {
                sbase1 = horas1 * 9.75;
            }
            else
            {
                sbase1 = (160 * 9.75) + ((horas1 - 160) * 11.5);
            }

            if (horas2 <= 160)
            {
                sbase2 = horas2 * 9.75;
            }
            else
            {
                sbase2 = (160 * 9.75) + ((horas2 - 160) * 11.5);
            }

            if (horas3 <= 160)
            {
                sbase3 = horas3 * 9.75;
            }
            else
            {
                sbase3 = (160 * 9.75) + ((horas3 - 160) * 11.5);
            }

            descuento1 = (sbase1 * 0.0525) + (sbase1 * 0.0688) + (sbase1 * 0.1);
            descuento2 = (sbase2 * 0.0525) + (sbase2 * 0.0688) + (sbase2 * 0.1);
            descuento3 = (sbase3 * 0.0525) + (sbase3 * 0.0688) + (sbase3 * 0.1);

            neto1 = sbase1 - descuento1;
            neto2 = sbase2 - descuento2;
            neto3 = sbase3 - descuento3;

            if (cargo1 == 1 && cargo2 == 2 && cargo3 == 3)
            {
                Console.Clear();
                Console.WriteLine("Nombres Ingresados: ");
                Console.WriteLine(nombre1 + '\n' + nombre2 + '\n' + nombre3 + '\n');
                Console.WriteLine("Valor Cargo de " + nombre1 + ": " + cargo1);
                Console.WriteLine("Valor Cargo de " + nombre2 + ": " + cargo2);
                Console.WriteLine("Valor Cargo de " + nombre3 + ": " + cargo3);
                Console.WriteLine("\nHORAS LABORADAS:");
                Console.WriteLine(nombre1 + ": " + horas1);
                Console.WriteLine(nombre2 + ": " + horas2);
                Console.WriteLine(nombre3 + ": " + horas3);
                Console.WriteLine("\nDESCUENTO: ");
                Console.WriteLine(nombre1 + ": " + descuento1);
                Console.WriteLine(nombre2 + ": " + descuento2);
                Console.WriteLine(nombre3 + ": " + descuento3);
                Console.WriteLine("\nSALARIO NETO: \nNO HAY BONO");
                Console.WriteLine(nombre1 + ": " + neto1);
                Console.WriteLine(nombre2 + ": " + neto2);
                Console.WriteLine(nombre3 + ": " + neto3);
            }
            else 
            {
                if (cargo1 == 1)
                {
                    neto1 = neto1 + (neto1 * 0.1);
                }
                else if(cargo1 == 2)
                {
                    neto1 = neto1 + (neto1 * 0.05);
                }
                else if(cargo1 == 3)
                {
                    neto1 = neto1 + (neto1 * 0.03);
                }
                else if (cargo1 == 4)
                {
                    neto1 = neto1 + (neto1 * 0.02);
                }

                if (cargo2 == 1)
                {
                    neto2 = neto2 + (neto2 * 0.1);
                }
                else if (cargo2 == 2)
                {
                    neto2 = neto2 + (neto2 * 0.05);
                }
                else if (cargo2 == 3)
                {
                    neto2 = neto2 + (neto2 * 0.03);
                }
                else if (cargo2 == 4)
                {
                    neto2 = neto2 + (neto2 * 0.02);
                }

                if (cargo3 == 1)
                {
                    neto3 = neto3 + (neto3 * 0.1);
                }
                else if (cargo3 == 2)
                {
                    neto3 = neto3 + (neto3 * 0.05);
                }
                else if (cargo3 == 3)
                {
                    neto3 = neto3 + (neto3 * 0.03);
                }
                else if (cargo3 == 4)
                {
                    neto3 = neto3 + (neto3 * 0.02);
                }

                Console.Clear();
                Console.WriteLine("Nombres Ingresados: ");
                Console.WriteLine(nombre1 + '\n' + nombre2 + '\n' + nombre3 + '\n');
                Console.WriteLine("Valor Cargo de " + nombre1 + ": " + cargo1);
                Console.WriteLine("Valor Cargo de " + nombre2 + ": " + cargo2);
                Console.WriteLine("Valor Cargo de " + nombre3 + ": " + cargo3);
                Console.WriteLine("\nHORAS LABORADAS:");
                Console.WriteLine(nombre1 + ": " + horas1);
                Console.WriteLine(nombre2 + ": " + horas2);
                Console.WriteLine(nombre3 + ": " + horas3);
                Console.WriteLine("\nDESCUENTO: ");
                Console.WriteLine(nombre1 + ": " + descuento1);
                Console.WriteLine(nombre2 + ": " + descuento2);
                Console.WriteLine(nombre3 + ": " + descuento3);
                Console.WriteLine("\nSALARIO NETO: \nBONO DISPONIBLE");
                Console.WriteLine(nombre1 + ": " + neto1);
                Console.WriteLine(nombre2 + ": " + neto2);
                Console.WriteLine(nombre3 + ": " + neto3);

                if (neto1 > neto2 && neto1 > neto3)
                {
                    Console.WriteLine("\nEl salario de " + nombre1 + " es el mayor");
                    if (neto2 > neto3)
                    {
                        Console.WriteLine("El salario de " + nombre3 + " es el menor");
                    }
                    else
                    {
                        Console.WriteLine("El salario de " + nombre2 + " es el menor");
                    }
                }

                else if (neto1 < neto2 && neto2 > neto3)
                {
                    Console.WriteLine("\nEl salario de " + nombre2 + " es el mayor");
                    if (neto1 > neto3)
                    {
                        Console.WriteLine("El salario de " + nombre3 + " es el menor");
                    }
                    else
                    {
                        Console.WriteLine("El salario de " + nombre1 + " es el menor");
                    }
                }
                else if (neto3 > neto2 && neto1 < neto3)
                {
                    Console.WriteLine("\nEl salario de " + nombre3 + " es el mayor");
                    if (neto2 > neto1)
                    {
                        Console.WriteLine("El salario de " + nombre1 + " es el menor");
                    }
                    else
                    {
                        Console.WriteLine("El salario de " + nombre2 + " es el menor");
                    }
                }

                if (neto1 > 300)
                {
                    Console.WriteLine(nombre1 + "tiene un salario mayor a 300$");
                }
                if (neto2 > 300)
                {
                    Console.WriteLine(nombre2 + "tiene un salario mayor a 300$");
                }
                if (neto3 > 300)
                {
                    Console.WriteLine(nombre3 + "tiene un salario mayor a 300$");
                }

            }
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
