using System;

namespace Ejercicio3_Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {     
            ganancias();
            Console.ReadKey();
            static void ganancias ()
            {
                Console.Title = "Nombre de las sucursales";
                string[] sucursal = new string[5];                
                int[] empleados = new int[5];
                int empleadosSobrantes = 0;
                double[] gananciaS = new double[5];                
                double gananciasT = 0;
                int menor = 0; 
                int mayor = 0;

                for (int i = 0; i < sucursal.Length; i++)
                {
                    Console.Write($"Nombre de la sucursal: ");
                    sucursal[i] = Console.ReadLine();

                    Console.Write($"Ganancias de la sucursal ({sucursal[i]}): $");
                    sucursal[i] = double.Parse(Console.ReadLine());

                    while (gananciaS[i] < 1000 || gananciaS[i] > 50000)
                    {
                        Console.WriteLine("El valor ingresado no es correcto.");
                        Console.Write($"Ganancias de la sucursal {sucursal[i]}: $");
                        gananciaS[i] = double.Parse(Console.ReadLine());
                    }
                    
                    Console.Write($"Cantidad de empleados ({sucursal[i]}): ");
                    empleados[i] = int.Parse(Console.ReadLine());
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
                    while (empleados[i] < 10)
                    {
                        Console.WriteLine("El valor es minimo a la cantidad de empleados permitidos.");
                        Console.Write($"Cantidad de empleados ({sucursal[i]}): ");
                        empleados[i] = int.Parse(Console.ReadLine());
                    }
                }                              
                
                for (int i = 0; i < 5; i++)
                {
                    gananciasT += gananciaS[i];

                    if (gananciaS[i] > 1000 && gananciaS[i] < 25000)
                        menor++;
                    if (gananciaS[i] >= 25000)
                        mayor++;
                }
                Console.Clear();
                Console.WriteLine($"Sucursales que obtienen ganancias entre $1,000 y $25,000: {menor}");

                for (int i = 0; i < 5; i++)
                {
                    if (gananciaS[i] > 1000 && gananciaS[i] < 25000)
                    {
                        Console.Write($"Sucursal: {sucursal[i]} ");
                        if (gananciaS[i] < 30000)
                            Console.Write("(Regular)");
                        else
                            Console.Write("(Bien Hecho)");
                        Console.WriteLine($"\nGanancias: ${gananciaS[i]}");
                        Console.WriteLine($"Empleados: {empleados[i]}\n");
                    }
                }
                Console.WriteLine($"Sucursales que obtienen ganancias mayores de $25000: {mayor}"); ;
                for (int i = 0; i < 5; i++)
                {
                    if (gananciaS[i] >= 25000)
                    {
                        Console.Write($"Sucursal: {sucursal[i]} ");
                        if (gananciaS[i] < 30000)
                            Console.Write("(Regular)");
                        else
                            Console.Write("(Bien Hecho)");

                        Console.WriteLine($"\nGanancias: ${gananciaS[i]}");
                        Console.WriteLine($"Empleados: {empleados[i]}\n");
                    }
                }
                Console.WriteLine($"Ganancia total de la empresa: ${gananciasT}");
            }
        }
    }
}
