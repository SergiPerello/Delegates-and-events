using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos_Lambda
{
    class Tanque : IGiros,IAtaque
    {
        private int posicion = 0;
        public event ManagerDisparo listaDisparo;
        public int Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        public void girarDerecha()
        {
            Posicion += 15;
            Posicion %= 360;
        }

        public void girarIzquierda()
        {
            Posicion -= 15;
            Posicion += 360;
            Posicion %= 360;
        }

        public void Disparar()
        {
            listaDisparo?.Invoke(this, new Disparo(Posicion, 400));
        }
    }
}
