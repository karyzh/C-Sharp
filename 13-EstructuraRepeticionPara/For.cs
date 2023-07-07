using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_EstructuraRepeticionPara
{
    internal class For
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 12 - Estructura repetición FOR");

            double saldo = 1000;
            double interes = 0.75 / 100; //0.75% por mes.

            //valor de partida; condición de finalización; valor de avance;
            for (int iNumMes = 1; iNumMes <= 12; iNumMes++)
            {
                //saldo = saldo + saldo * interes; // 1000 + 1000 * 0.75 / 100
                saldo += saldo * interes; //para que se vea mejor
                Console.WriteLine($"El saldo luego del {iNumMes} mes {saldo}");

                // contadores
                //iNumMes++; si se le deja el contador dos veces dentro del programa lo que hace es saltarse, contarlo doblemente
                //iNumMes = iNumMes + 1;
                //iNumMes = +1;
            }




            Console.ReadLine();
        }
    }
}
