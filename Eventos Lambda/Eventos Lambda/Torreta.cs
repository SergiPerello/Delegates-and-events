﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos_Lambda
{
    class Torreta : IGiros
    {
        private int posicion;
        public event ManagerDisparo disparo;
        public int Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        public void girarDerecha()
        {
            Posicion+=90;
            Posicion %= 360;
        }

        public void girarIzquierda()
        {
            Posicion-=90;
            Posicion += 360;
            Posicion %= 360;
        }
    }
}
