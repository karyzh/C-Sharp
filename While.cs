using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EstructuraRepeticionWhile
{
    internal class While
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 12 - Estructura repetición While");

            double saldo = 1000;
            double interes = 0.75 / 100; //0.75% por mes.
            int iNumMes = 1;

            // MIENTRAS QUE ( CONDICIÓN )
            while (iNumMes <= 12)
            {
                //saldo = saldo + saldo * interes; // 1000 + 1000 * 0.75 / 100
                saldo += saldo * interes; //para que se vea mejor
                Console.WriteLine($"El saldo luego del {iNumMes} mes {saldo}");
                
                // contadores
                iNumMes++;
                //iNumMes = iNumMes + 1;
                //iNumMes = +1;
            }
            

            


            Console.ReadLine();
        }
    }
}
