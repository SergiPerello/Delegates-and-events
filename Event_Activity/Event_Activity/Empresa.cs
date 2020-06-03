using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Activity
{
    class Empresa
    {
        List<Empleado> listaEmpleados = new List<Empleado>();

        public delegate void b(Empleado despedido);
        public event b despedir;

        public void Contratar(Empleado a)
        {
            listaEmpleados.Add(a);
        }

        public void Despedir(Empleado a)
        {
            if (listaEmpleados.Contains(a))
            {
                listaEmpleados.Remove(a);
                despedir?.Invoke(a);
            }
        }

    }
}
