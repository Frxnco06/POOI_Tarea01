using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado emp= new Empleado(120,"Jose",983243567,3500);

            Console.WriteLine("Código: " + emp.codigo);
            Console.WriteLine("Nombre: " + emp.nombre);
            Console.WriteLine("Número de celular: " + emp.numcelular);
            Console.WriteLine("Sueldo en soles: " + emp.sueldoSoles);
            Console.WriteLine("Evaluación del sueldo: " + emp.DatoSueldo());

            emp.numcelular = 999888777;
            emp.sueldoSoles += 200;

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Datos actualizados:");
            Console.WriteLine("Número de celular: " + emp.numcelular);
            Console.WriteLine("Sueldo en soles: " + emp.sueldoSoles);
            Console.WriteLine("Evaluación del sueldo: " + emp.DatoSueldo());

            Console.ReadKey();

        }
    }
}
