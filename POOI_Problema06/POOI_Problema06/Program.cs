using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente pa = new Paciente("Juan", "Perez", 19, 1.80, 71);

            Console.WriteLine("Nombre: " + pa.nombre);
            Console.WriteLine("Apellido: "+pa.apellido);
            Console.WriteLine("Edad: " + pa.edad);
            Console.WriteLine("Talla: "+pa.talla);
            Console.WriteLine("Peso: "+pa.peso);

            Console.WriteLine("********************************");
            Console.WriteLine(pa.getEdad());


            Console.ReadKey();
        }
    }
}
