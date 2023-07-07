using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_VariablesBooleanas
{
    internal class VariablesBooleanas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 10 - Variables Booleanas");

            // Determinar si la persona puede entrar al parque

            int edadPersona = 16;
            bool acompanado = true;

            if (edadPersona >= 18) //mayor o más 
            {
                Console.WriteLine("La persona puede entrar al parque");
            }
            else  
            {
                if (acompanado)
                {
                    Console.WriteLine("La persona puede entrar al parque porque está acompañado");
                }
                else
                {
                    Console.WriteLine("La persona no puede entrar al parque porque no va acompañado");
                }
            }
        

            Console.ReadLine();
        }
    }
}

/* int edadLeonardo = 40;
           int edadMaria = 40;
           bool casado = false;

           // && = YY
           // || = O
           // ! = NO ; ejemplo: !acompanado

           if (edadLeonardo > edadMaria && casado)
           {
               Console.WriteLine("La edad de Leonardo es MAYOR a la edad de María y esta casado");
           }
           else
           {
               if (edadLeonardo < edadMaria && !casado) // && ! = significa negación 
               {
                   Console.WriteLine("La edad de Leonardo es MENOR a la edad de María y no esta casado");
               } else
               {
                   Console.WriteLine("La edad de Leonardo es IGUAL a la edad de María");
               }
           } */