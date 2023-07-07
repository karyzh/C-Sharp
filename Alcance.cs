using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Alcance
{
    internal class Alcance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 11 - Alcance");

            // Determinar si la persona puede entrar al parque

            int edadPersona = 123;
            bool acompanado = true;

            if(edadPersona >= 18 && acompanado)
            {
                Console.WriteLine("La persona puede entrar al parque");

            } else {
                if (edadPersona < 18)
                {
                    Console.WriteLine("La persona no tiene edad suficiente");
                } 
                else if(!acompanado)
                {
                    Console.WriteLine("La persona no puede entrar porque no va acompañado");
                }

                    }


            Console.ReadLine();
        }
    }
}
