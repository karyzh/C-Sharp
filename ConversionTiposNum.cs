using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ConversionTiposNumericos
{
    internal class ConversionTiposNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 05 - Conversion Tipos Numericos");

            //Type casting es para hacer conversión explicita poniendo el tipo de dato que se convertirá

            //short cantidadPaises = 1000;
            //byte cantidadLetras = cantidadPaises; es EXPLICITO porque no puede convertir del mas grande al mas pequeño por el rango

            byte cantidadLetras = 28; // sbyte almacena desde -128 a 127 y byte de 0 a 255

            Console.WriteLine($"Cantidad letras {cantidadLetras}");

            short cantidadPaises = 1000; // -32 768 a 32 767
            //short cantidadPaises = cantidadLetras; si puede ya que es implicitamente quiere decir que de menor a mayor puede convertir

            Console.WriteLine($"Cantidad paises {cantidadPaises}");

            
            float decimalPequeño = 120.09f; //agregarle f al final para que lo acepte con decimal

            Console.WriteLine($"Cantidad decimal pequeño {decimalPequeño}");

            double salario = 250.01;

            Console.WriteLine($"Cantidad salario {salario}");

            int salarioEnEnteros = (int)salario; // millones , -conversion explicita

            Console.WriteLine($"Salario en Enteros {salarioEnEnteros}");

            decimal decimalGrande = 1287444.102483m; //agregar m al final para que acepte un decimal grande ya que si no se agrega, lo toma como double

            Console.WriteLine($"Cantidad decimal grande {decimalGrande}");

            long unNumeroMuyGrande = (long)decimalGrande; // 2,147,483,647 a -2,147,483,648.
                                        //conversion explicita poniendo al principio entre parentesis el tipo de dato que se quiere convertir
            Console.WriteLine($"Cantidad numero muy grande {unNumeroMuyGrande}");

            Console.ReadLine();
        }
    }
}
