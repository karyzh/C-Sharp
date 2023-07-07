﻿using System;
using System.Collections.Generic;

namespace EsencialEjemplos
{
    class Program
    {
        public class Coordenadas { public int x; public int y; }
        static void Main(string[] args)
        {
            #region tipos genericos
            var lista = new List<string>();
            var str = new Concatenar<int>();
            str.Agregar(5);
            str.Agregar(9);
            Console.WriteLine("str {0}", str.resultado);

            var strBool = new Concatenar<bool>();
            strBool.Agregar(false);
            strBool.Agregar(true);
            Console.WriteLine("strBool {0}", strBool.resultado);
            #endregion
        }

    }
}