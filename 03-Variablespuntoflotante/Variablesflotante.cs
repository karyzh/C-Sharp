using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Variablespuntoflotante
{
    internal class Variablesflotante
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ejecutando el proyecto 03-Variables de punto flotantes");
            Console.WriteLine("\n");

            double saldoCuenta;  //double es flotante
            saldoCuenta = 9876.23; //saldoCuenta = 5.0 / 3.0; así es como double sabe que el resultado es punto decimal, si se pone entero el resultado será entero aunque se declare como double

            Console.WriteLine($"El saldo en la cuenta es: {saldoCuenta}");
            Console.ReadLine();
        }
    }
}
