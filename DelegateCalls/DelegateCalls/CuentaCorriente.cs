using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateCalls
{
    public class CuentaCorriente
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set
            {
                saldo = value;
                if (!(listaAlerta is null))
                {
                    listaAlerta("Saldo cambiado");
                }
            }
        }

        public delegate void alerta(string value);
        public alerta listaAlerta;

    }
}
