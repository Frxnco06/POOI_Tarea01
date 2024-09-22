using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Tarea01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular cel = new Celular(983763835, "Franco", 120, 200);

            Console.WriteLine("Numero: " + cel.numero);
            Console.WriteLine("Usuario: " + cel.usuario);
            Console.WriteLine("Segundos consumidos: " + cel.sConsumidos);
            Console.WriteLine("Precio por segundo: "+cel.pSegundo);

            Console.WriteLine("IGV: " + cel.igv());
            Console.WriteLine("Costo de consumo: " + cel.costoConsumo());
            Console.WriteLine("Total a pagar: " + cel.totalPagar());

            cel.sConsumidos += 20;
            cel.pSegundo *= 0.95;

            Console.WriteLine("\nDatos actualizados: ");

            Console.WriteLine("Segundos consumidos: " + cel.sConsumidos);
            Console.WriteLine("Precio por segundo: " + cel.pSegundo);

            Console.WriteLine("IGV: " + cel.igv());
            Console.WriteLine("Costo de consumo: " + cel.costoConsumo());
            Console.WriteLine("Total a pagar: " + cel.totalPagar());

            Console.ReadKey();

        }
    }
}
