using System;

namespace DelegateCalls
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaCorriente cuenta = new CuentaCorriente();
            cuenta.listaAlerta = aviso;
            cuenta.Name = "cuenta";
            cuenta.Saldo = -100;
            
            cuenta.Saldo = 123;
        }

        public static void aviso(string value)
        {
            Console.WriteLine(value);
        }
    }
}
