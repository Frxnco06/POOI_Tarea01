using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edificio ed= new Edificio(999999,8,3,19000);

            Console.WriteLine("Codigo: "+ed.codigo);
            Console.WriteLine("Numero de departamentos: "+ed.numeroDeDeportamentos);
            Console.WriteLine("Cantidad de pisos del edificio: " + ed.cantidadPisos);
            Console.WriteLine("Precio departamentos en dolares: "+ed.precioDepaDolares);

            Console.WriteLine("**************************");

            Console.WriteLine("Precio en Dolares del edificio: " + ed.precioDolares());
            ed.precioDepaDolares *= 1.20;

            Console.WriteLine("**************************");

            Console.WriteLine("Después de un incremento del 20% en el precio del departamento:");

            Console.WriteLine("Nuevo precio departamentos en dólares: " + ed.precioDepaDolares);
        }
    }
}
