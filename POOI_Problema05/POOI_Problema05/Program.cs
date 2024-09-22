using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video vid = new Video(230,"Breaking bad",1.30,30,3.70);

            Console.WriteLine("Codigo: "+vid.codigo);
            Console.WriteLine("Nombre de la pelicula: "+vid.nomVideo);
            Console.WriteLine("Duracion: "+vid.duracion);
            Console.WriteLine("Precio en soles: "+vid.pSoles);
            Console.WriteLine("Precio en Dólares: " + vid.videoDolares());
            Console.WriteLine("Tipo de cambio: "+vid.tipoCambio);

            Console.WriteLine("*********************************");

            vid.pSoles += 5.50;

            Console.WriteLine("Precio en Soles: S/" + vid.pSoles);
            Console.WriteLine("Tipo de Cambio: S/" + vid.tipoCambio);
            Console.WriteLine("Precio en Dólares: " + vid.videoDolares());
       
            Console.ReadKey();
        }
    }
}
