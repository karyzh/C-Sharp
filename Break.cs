using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_PalabraReservada_Break
{
    internal class Break
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 15 - Palabra reservada BREAK");

            double saldo = 1000;
            double interes = 0.75 / 100; //0.75% por mes.

            for (int iNumAso = 1; iNumAso <= 5; iNumAso++) //Año del 1 al 5
            {
                Console.WriteLine($"Año: {iNumAso}");

                if (iNumAso >= 5) //si es mayor a 5 años, se incrementará el interés
                {
                    interes = 0.90 / 100;
                }
                else if (iNumAso >= 3) //si es mayor a 3 años, se incrementará el interés
                {
                    interes = 0.85 / 100;
                }


                //valor de partida; condición de finalización; valor de avance;
                for (int iNumMes = 1; iNumMes <= 12; iNumMes++)
                {
                    //saldo = saldo + saldo * interes; // 1000 + 1000 * 0.75 / 100
                    saldo += saldo * interes; //para que se vea mejor
                    if (saldo > 1200) 
                        break;
                    Console.WriteLine($"El saldo luego del {iNumMes} mes {saldo}");

                    // contadores
                    //iNumMes++; si se le deja el contador dos veces dentro del programa lo que hace es saltarse, contarlo doblemente
                    //iNumMes = iNumMes + 1;
                    //iNumMes = +1;
                }
                if (saldo > 1200)
                    break;
            }


            Console.ReadLine();
        }
    }
}
