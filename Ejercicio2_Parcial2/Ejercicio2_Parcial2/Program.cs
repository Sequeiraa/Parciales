using System;

namespace Ejercicio2_Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            int multi3, multi5, multi3y5, valor, x;
            multi3 = 0;
            multi5 = 0;
            multi3y5 = 0;

            int[] veces = new int[10];
            for (x = 1; x <= 10; x++)
            {
                Console.WriteLine("Ingrese un valor:");
                valor = int.Parse(Console.ReadLine());
                while (valor < 0 || valor > 500)
                {
                    Console.WriteLine("El valor ingresado es inválido.");
                    Console.Write($"Ingrese un valor: ");
                    valor = int.Parse(Console.ReadLine());

                }
                if (valor % 3 == 0)
                {
                    multi3 = multi3 + 1;
                }
                if (valor % 5 == 0)
                {
                    multi5 = multi5 + 1;
                }
                else if(valor % 3 == 0 || valor % 5 ==0)
                {
                    multi3y5 = multi3y5 + 1; 
                }
            }
            Console.WriteLine("Cantidad de valores ingresados múltiplos de 3:" + multi3);
            Console.WriteLine("Cantidad de valores ingresados múltiplos de 5:" + multi5);
            Console.WriteLine("Cantidad de valores ingresados múltiplos de 3 y 5:" + multi3y5);
        }
    }
}
