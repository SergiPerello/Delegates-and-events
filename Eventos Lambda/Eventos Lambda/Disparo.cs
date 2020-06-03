using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos_Lambda
{
    public class Disparo
    {
        public Disparo(int direccion, int potencia)
        {
            this.direccion = direccion;
            this.potencia = potencia;
        }

        public int direccion { get; set; }
        public int potencia { get; set; }

    }
}
