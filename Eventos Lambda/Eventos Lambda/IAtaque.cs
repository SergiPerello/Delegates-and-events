using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos_Lambda
{
    public delegate void ManagerDisparo(object Sender, Disparo a);
    interface IAtaque
    {
        void Disparar();
    }
}
