using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TipoDatoCaracter
{
    internal class TipoDatoCaracter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 06 - Tipo de Dato Carácter");

            char primeraLetra = 'A'; //char es para caracter y se pone comillas simples
            char letraconNumero = (char)65; //se puede hacer casting porque es un int
            char letraconHexa = '\u006A';

            letraconNumero = (char)(letraconNumero + 1); //si se puede y este hace una suma de 65+1 para así dar como resultado la siguiente letra
            Console.WriteLine($"La primera letra es: {primeraLetra}");
            Console.WriteLine($"El numero 66 representa la letra: {letraconNumero}");
            Console.WriteLine($"La letra con Hexadecimal es: {letraconHexa}");

            Console.ReadLine();
        }
    }
}
