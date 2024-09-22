using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema06
{
    internal class Paciente
    {
        public string nombre {  get; set; }
        public string apellido {  get; set; }
        public int edad {  get; set; }
        public double talla {  get; set; }
        public double peso {  get; set; }

        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.talla = talla;
            this.peso = peso;
        }

        public string getEdad() {
            if (edad >= 18)
            {
                 return "mayor de edad";
            }
            else
            {
                return "menor de edad";
            }

        }
    }
}
