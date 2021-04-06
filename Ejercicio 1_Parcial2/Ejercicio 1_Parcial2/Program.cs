using System;

namespace Ejercicio_1_Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Notas de 5 estudiantes";
            String[] nombre = nombres();
            double[,] notas = notasEstudiantes(nombre);
            double[] promedioAlumnos = Promedio(notas);
            resultados(nombre, promedioAlumnos);

            static string[] nombres()
            {
                Console.WriteLine("Ingrese el nombre de los estudiantes\n");
                int i;
                string[] nombres = new string[5];

                for (i = 0; i < nombres.Length; i++)
                {
                    Console.Write("Nombre del estudiante: ");
                    nombres[i] = Console.ReadLine();
                }
                return nombres;
            }

            static double[,] notasEstudiantes(String[] nombres)
            {
                Console.Clear();
                int i, x;
                double[,] notas = new double[5, 5];
                Console.Write("Digite las notas\n\n");

                for (i = 0; i < notas.GetLength(0); i++)
                {
                    for (x = 0; x < notas.GetLength(1); x++)
                    {
                        Console.Write($" Ingrese las notas del estudiante {nombres[i]}: ");
                        Console.Write($"\nDigita la nota {x + 1}: ");
                        notas[i, x] = double.Parse(Console.ReadLine());

                        while (notas[i, x] < 0 || notas[i, x] > 10)
                        {
                            Console.WriteLine("No se aceptan ese tipo de datos.");

                            Console.Write($"Digita la nota {x + 1}: ");
                            notas[i, x] = double.Parse(Console.ReadLine());
                        }
                    }
                    Console.Write("\n");
                }
                return notas;
            }
            static double[] Promedio(double[,] promedioNotas)
            {
                int i, x;
                double[] promedio = new double[5];

                for (i = 0; i < promedioNotas.GetLength(0); i++)
                {
                    for (x = 0; x < promedioNotas.GetLength(1); x++)
                    {
                        promedio[i] += Math.Round((promedioNotas[i, x] / 5), 2);
                    }
                }
                return promedio;
            }
            static void resultados(string[] nombres, double[] promedio)
            {
                Console.Clear();
                Console.Write("Resultados\n");
                int i = 0;
                double mayorPro = promedio[i], menorPro = promedio[i];
                for (i = 0; i < promedio.Length; i++)
                {
                    if (promedio[i] > mayorPro)
                        mayorPro = promedio[i];
                    if (promedio[i] < menorPro)
                        menorPro = promedio[i];
                }
                for (i = 0; i < 5; i++)
                {
                    Console.Write($"\nEstudiante: ");
                    Console.Write($"{nombres[i]}\n ");

                    if (promedio[i] >= 7)
                    {
                        Console.Write("Aprobado\n");
                    }
                    else if (promedio[i] >= 4 && promedio[i] < 7)
                    {
                        Console.Write("Regular\n");
                    }
                    else
                    {
                        Console.Write("Reprobado\n");
                        Console.Write($"\nPromedio: {Math.Round(promedio[i], 2)} ");
                    }
                    if (mayorPro == promedio[i])
                    {
                        Console.Write(" (Mayor Promedio)");
                        Console.Write("\n");
                    }
                    if (menorPro == promedio[i])
                    {
                        Console.Write(" (Menor promedio)");
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}