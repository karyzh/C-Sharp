using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_TrabajandoConCondiciones
{
    internal class Condiciones
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 09 - Trabajando con condiciones");

            int edadLeonardo = 43;
            int edadMaria = 39;

            //Operadodores condicionales:

            //Igual a:
            /*
            if (edadLeonardo == edadMaria) {
                Console.WriteLine("La edad de Leonardo es igual a la edad de María");
            }
            else
            {
                Console.WriteLine("La edad de Leonardo no es igual a la edad de María");
            }*/

            //Diferente de:

            /*if (edadLeonardo != edadMaria) {
                Console.WriteLine("La edad de Leonardo es diferente a la edad de María");
            }
            else
            {
                Console.WriteLine("La edad de Leonardo es IGUAL a la edad de María");
            }*/

            //Mayor que:

            if (edadLeonardo > edadMaria)
            {
                Console.WriteLine("La edad de Leonardo es MAYOR a la edad de María");
            }
            else
            {
                Console.WriteLine("La edad de Leonardo no es mayor a la edad de María");
            }

            //Menor que:

            if (edadLeonardo < edadMaria)
            {
                Console.WriteLine("La edad de Leonardo es MENOR a la edad de María");
            }
            else
            {
                Console.WriteLine("La edad de Leonardo no es menor a la edad de María");
            }

            Console.ReadLine();
        }
    }
}
