using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor ases = new Asesor(22342, "Rodrigo Martinez", 8, 45);

            Console.WriteLine("Codigo: "+ases.codigo);
            Console.WriteLine("Nombre: "+ases.nombre);
            Console.WriteLine("Horas Trabajadas: "+ases.horasTrabajadas);
            Console.WriteLine("Tarifa por hora: " + ases.tarifaxHora);

            Console.WriteLine("");

            Console.WriteLine("Sueldo Bruto: " + ases.sueldoBruto());
            Console.WriteLine("Descuento: " + ases.descuento());
            Console.WriteLine("Sueldo Neto: "+ases.sueldoNeto());

            ases.horasTrabajadas +=10;
            ases.tarifaxHora *= 0.85;


            Console.WriteLine("\nDatos actualizados");
            Console.WriteLine("Horas Trabajadas: " + ases.horasTrabajadas);
            Console.WriteLine("Tarifa por hora: " + ases.tarifaxHora);

            Console.WriteLine("\nSueldo Bruto: " + ases.sueldoBruto());
            Console.WriteLine("Descuento: " + ases.descuento());
            Console.WriteLine("Sueldo Neto: " + ases.sueldoNeto());
            Console.ReadKey();
        }
    }
}
