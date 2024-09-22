using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota pel= new Pelota("Adidas",12.2,5.10,35,78);

            Console.WriteLine("Marca: "+pel.marca);
            Console.WriteLine("Peso en gramos: "+pel.pesoGramos);
            Console.WriteLine("Presion en libras: "+pel.presionLibras);
            Console.WriteLine("Diametro en centimetros: "+pel.diametroCentimetros);
            Console.WriteLine("Precio: " + pel.precio);

            Console.WriteLine("Radio: " + pel.radio());
            Console.WriteLine("Volumen del balon: " + pel.volumenBalon());
            Console.WriteLine("Descuento: " + pel.descuento());
            Console.WriteLine("Importe a pagar: "+pel.importePagar());

            pel.precio*=0.75;
            pel.diametroCentimetros += 1;

            Console.WriteLine("\n\nDatos Actualizados: ");

            Console.WriteLine("Diametro en centimetros: " + pel.diametroCentimetros);
            Console.WriteLine("Precio: " + pel.precio);

            Console.WriteLine("Radio: " + pel.radio());
            Console.WriteLine("Volumen del balon: " + pel.volumenBalon());
            Console.WriteLine("Descuento: " + pel.descuento());
            Console.WriteLine("Importe a pagar: " + pel.importePagar());

            Console.ReadKey();
        }
    }
}
