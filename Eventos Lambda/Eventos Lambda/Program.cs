using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Regimiento<Tanque> r = new Regimiento<Tanque>();
            Regimiento<Torreta> t = new Regimiento<Torreta>();
            r.add(new Tanque());
            t.add(new Torreta());

            Tanque tank = new Tanque();
            tank.listaDisparo += disparar;

            tank.Disparar();
            tank.girarDerecha();
            tank.Disparar();
            Console.WriteLine(tank.Posicion);
        }

        public static void disparar(Object a,Disparo b)
        {
            Console.WriteLine("{0} Fire in a hole!");
        }
    }
}
