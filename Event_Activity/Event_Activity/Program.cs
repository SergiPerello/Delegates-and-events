using System;

namespace Event_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();
            Empleado a = new Empleado("Edu");
            Empleado b = new Empleado("Adri");
            Empleado c = new Empleado("Zaka");
            empresa.despedir += aviso;
            empresa.Contratar(a);
            empresa.Contratar(b);
            empresa.Despedir(b);
            
        }
        public static void aviso(Empleado a)
        {
            Console.WriteLine("{0} despedido!", a.Name);
        }
    }
}
