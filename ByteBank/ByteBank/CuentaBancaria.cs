using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class CuentaBancaria
    {
        //Propiedades
        public string nombreCliente;
        public string numeroCuenta;
        public string numeroAgencia;
        public double saldo;
        public double tasaInteres;
        public double limiteSobregiro;

        //Métodos
        public bool RetirarDinero(double valorRetirar)
        {
            if (saldo < valorRetirar)
            {
                Console.WriteLine("No hay saldo suficiente");
                return false;
            } else if(valorRetirar <= 0)
            {
                Console.WriteLine("El valor a retirar debe ser mayor a 0");
                return false;
            } 

            //saldo = saldo - valorRetirar;
            saldo-= valorRetirar;
            return true;

        }

    }
}
