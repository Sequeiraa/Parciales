using System;

namespace Ejercicio3_Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {     
            sucursales();
            Console.ReadKey();
            static void sucursales()
            {
                Console.Title = "Sucursales";
                string[] nombreDeSucursal = new string[5];                
                int[] empleados = new int[5];
                double[] gananciaDeSucursal = new double[5];

                double gananciasTotales = 0;
                int empleadosSobrantes = 0;
                int arribaMenor = 0; 
                int arribaMayor = 0;

                for (int i = 0; i < nombreDeSucursal.Length; i++)
                {
                    Console.Write($"Nombre de la sucursal: ");
                    nombreDeSucursal[i] = Console.ReadLine();

                    Console.Write($"Ganancias de la sucursal ({nombreDeSucursal[i]}): $");
                    gananciaDeSucursal[i] = double.Parse(Console.ReadLine());

                    while (gananciaDeSucursal[i] < 1000 || gananciaDeSucursal[i] > 50000)
                    {
                        Console.WriteLine("El valor ingresado no es correcto.");
                        Console.Write($"Ganancias de la sucursal {nombreDeSucursal[i]}: $");
                        gananciaDeSucursal[i] = double.Parse(Console.ReadLine());
                    }
                    Console.Write($"Cantidad de empleados ({nombreDeSucursal[i]}): ");
                    empleados[i] = int.Parse(Console.ReadLine());
                    while (empleados[i] < 10)
                    {
                        Console.WriteLine("El valor es minimo a la cantidad de empleados permitidos.");
                        Console.Write($"Cantidad de empleados ({nombreDeSucursal[i]}): ");
                        empleados[i] = int.Parse(Console.ReadLine());
                    }
                    Console.Write("\n");
                }
              
                for (int i = 0; i < 5; i++)
                {
                    while (empleados[i] > 20)
                    {
                        empleadosSobrantes = empleados[i] - 20;
                        empleados[i] = 20;
                        for (int k = 0; k < 5; k++)
                        {
                            if (empleadosSobrantes <= 0)
                                break;

                            while (empleados[k] < 20)
                            {
                                if (empleadosSobrantes <= 0)
                                    break;

                                empleados[k]++;
                                empleadosSobrantes--;
                            }
                        }
                    }
                }

                
                for (int i = 0; i < 5; i++)
                {
                    gananciasTotales += gananciaDeSucursal[i];

                    if (gananciaDeSucursal[i] > 1000 && gananciaDeSucursal[i] < 25000)
                        arribaMenor++;
                    if (gananciaDeSucursal[i] >= 25000)
                        arribaMayor++;
                }
                Console.Clear();
                Console.WriteLine($"Sucursales que obtienen ganancias entre $1,000 y $25,000: {arribaMenor}");

                for (int i = 0; i < 5; i++)
                {
                    if (gananciaDeSucursal[i] > 1000 && gananciaDeSucursal[i] < 25000)
                    {
                        Console.Write($"Sucursal: {nombreDeSucursal[i]} ");
                        if (gananciaDeSucursal[i] < 30000)
                            Console.Write("(Regular)");
                        else
                            Console.Write("(Bien Hecho)");
                        Console.WriteLine($"\nGanancias: ${gananciaDeSucursal[i]}");
                        Console.WriteLine($"Empleados: {empleados[i]}\n");
                    }
                }
                Console.WriteLine($"Sucursales que obtienen ganancias mayores de $25000: {arribaMayor}"); ;
                for (int i = 0; i < 5; i++)
                {
                    if (gananciaDeSucursal[i] >= 25000)
                    {
                        Console.Write($"Sucursal: {nombreDeSucursal[i]} ");
                        if (gananciaDeSucursal[i] < 30000)
                            Console.Write("(Regular)");
                        else
                            Console.Write("(Bien Hecho)");

                        Console.WriteLine($"\nGanancias: ${gananciaDeSucursal[i]}");
                        Console.WriteLine($"Empleados: {empleados[i]}\n");
                    }
                }
                Console.WriteLine($"Ganancia total de la empresa: ${gananciasTotales}");
            }
        }
    }
}
