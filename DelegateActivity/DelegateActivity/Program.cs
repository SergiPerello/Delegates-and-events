using System;

namespace DelegateActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("Chupa de cuero", 100);
            cambiar c = descuento;
            p.cambiarPrecio(c);
            Console.WriteLine(p.name + " " + p.price);
            c = aumento;
            p.cambiarPrecio(c);
            p.cambiarPrecio(c);
            Console.WriteLine(p.name + " " + p.price);
        }

        static double descuento(double value)
        {
            return value*0.9;
        }

        static double aumento(double value)
        {
            return value*1.05;
        }

        static double rebaja(double value)
        {
            return value/2;
        }
    }
}
