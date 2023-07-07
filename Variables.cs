using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Variables
    {
        static void Main(string[] args)
        {
            int valor;
            valor = 24 * 3 + 10;
            Console.WriteLine(valor);
            //1era forma de concatenar
            Console.WriteLine("El resultado de la operación es " + valor);

            //2da forma de concatenar
            Console.WriteLine($"El resultado de la operación es {valor}");

            //3era forma de concatenar
            Console.Write("El resultado de la operación es ");
            Console.WriteLine(valor);

            Console.ReadLine();
        }
    }
}
