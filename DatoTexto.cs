using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_TipoDatoTexto
{
    internal class DatoTexto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 07 - Tipo de Dato Texto");

            char primeraLetra = '\n'; //char es para caracter y se pone comillas simples y no se puede dejar vacío
            char letraconNumero = (char)65; //se puede hacer casting porque es un int
            //char letraconHexa = '\u006A';
            char segundaLetra = '\t'; //columna

            letraconNumero = (char)(letraconNumero + 1); //si se puede y este hace una suma de 65+1 para así dar como resultado la siguiente letra

            Console.WriteLine($"Ejemplo de uso del carácter especial <enter> {primeraLetra}");

            Console.WriteLine($"Col1 {segundaLetra} Col2 {segundaLetra}  Col3");
            Console.WriteLine($"Col1b {segundaLetra} Col2b {segundaLetra} Col3b");

            string nombreCurso = @"Estoy en el curso de: 
                C# Primeros Pasos";
            Console.WriteLine(nombreCurso);
            


            Console.ReadLine();
        }
    }
}
