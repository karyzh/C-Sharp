using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OtrosTipoDatosNumericos
{
    internal class TiposDatosNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 04 - Otros Tipos de Datos Numericos");

            byte cantidadLetras = 28; // sbyte almacena desde -128 a 127 y byte de 0 a 255

            Console.WriteLine($"Cantidad letras {cantidadLetras}");

            short cantidadPaises = 1000; // -32 768 a 32 767

            Console.WriteLine($"Cantidad paises {cantidadPaises}");

            int cantidadEspecies = 20; // millones

            Console.WriteLine($"Cantidad especies {cantidadEspecies}");

            long unNumeroMuyGrande = 100000000000000000; // 2,147,483,647 a -2,147,483,648.

            Console.WriteLine($"Cantidad numero muy grande {unNumeroMuyGrande}");

            float decimalPequeño = 120.09f; //agregarle f al final para que lo acepte con decimal

            Console.WriteLine($"Cantidad decimal pequeño {decimalPequeño}");

            double salario = 250.01;

            Console.WriteLine($"Cantidad salario {salario}");

            decimal decimalGrande = 1287444.102483m; //agregar m al final para que acepte un decimal grande ya que si no se agrega, lo toma como double

            Console.WriteLine($"Cantidad decimal grande {decimalGrande}");

            Console.ReadLine();
        }
    }
}
