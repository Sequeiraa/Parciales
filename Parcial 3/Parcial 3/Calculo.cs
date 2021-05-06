using System;
using System.IO;

namespace Desafio_Practico_III
{
    class CalculoSalario
    {
        public static double[] AFP = new double[3];
        public static double[] ISSS = new double[3];
        public static double[] renta = new double[3];
        public static double[] salarioXhora(string[,] horas)
        {
            double[] salario = new double[3];
            for (int i = 0; i < 3; i++)
            {
                if (Convert.ToDouble(horas[i, 3]) <= 160)
                {
                    salario[i] = Convert.ToDouble(horas[i, 3]) * 9.75;
                }
                else
                {
                    salario[i] = 160 * 9.75 + (Convert.ToDouble(horas[i, 3]) - 160) * 11.50;
                }
            }

            double[] descuento = new double[3];            

            for (int i = 0; i < 3; i++)
            {
                AFP[i] = Math.Round(salario[i] * 0.0688);
                ISSS[i] = Math.Round(salario[i] * 0.0525);
                renta[i] = Math.Round(salario[i] * 0.10);                
                descuento[i] = Math.Round(salario[i] - (AFP[i] + ISSS[i] + renta[i]), 2);
            }
        }
    }
}
