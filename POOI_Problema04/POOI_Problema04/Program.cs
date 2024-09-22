using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obrero ob = new Obrero(12032, "Jose Perez", 12, 50);

            Console.WriteLine("Codigo: " + ob.codigo);
            Console.WriteLine("Nombre: " + ob.nombre);
            Console.WriteLine("Horas Trabajadas: " + ob.horasTrabajadas);
            Console.WriteLine("Tarifa por hora: " + ob.tarifaxHora);

            Console.WriteLine("***************************************");

            Console.WriteLine("Sueldo bruto: " + ob.sueldoBruto());
            Console.WriteLine("Descuento AFP: " + ob.descuentoAfp());
            Console.WriteLine("Descuento EPS: " + ob.descuentoEps());
            Console.WriteLine("Sueldo Neto: " + ob.sueldoNeto());

            ob.horasTrabajadas += 8;

            ob.tarifaxHora *= 0.985;

            Console.WriteLine("***************************************");


            Console.WriteLine("Después de aumentar 8 horas trabajadas y disminuir 1.5% la tarifa por hora:");

            Console.WriteLine("Sueldo bruto: " + ob.sueldoBruto());
            Console.WriteLine("Descuento AFP: " + ob.descuentoAfp());
            Console.WriteLine("Descuento EPS: " + ob.descuentoEps());
            Console.WriteLine("Sueldo Neto: " + ob.sueldoNeto());


            Console.ReadKey();
        
        }
    }
}
