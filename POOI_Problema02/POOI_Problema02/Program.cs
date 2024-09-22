using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema02
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Computadora compu = new Computadora(29990,"Samsung","Negro",1004);

            Console.WriteLine("Codigo: " + compu.codigo);
            Console.WriteLine("Marca: "+compu.marca);
            Console.WriteLine("Color: " + compu.color);
            Console.WriteLine("Precio en dolares: "+compu.pDolares);

            compu.pDolares *= 0.90;

            Console.WriteLine("***********************************************");
            Console.WriteLine("Precio en dólares: $" + compu.pDolares);
            Console.WriteLine("Precio a soles: "+compu.PrecioSoles());
            Console.WriteLine("Precio a euros: "+compu.PrecioEuros());

            Console.ReadKey();
        }
    }
}
