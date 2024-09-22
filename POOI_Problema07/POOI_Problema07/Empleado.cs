using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema07
{
    internal class Empleado
    {
        public int codigo {  get; set; }
        public string nombre {  get; set; }
        public int numcelular {  get; set; }
        public double sueldoSoles {  get; set; }

        public Empleado(int codigo, string nombre, int numcelular, double sueldoSoles)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.numcelular = numcelular;
            this.sueldoSoles = sueldoSoles;
        }
        public string DatoSueldo() {
            if (sueldoSoles > 3500)
            {
                return "Mayor a 3500";
            }
            else if (sueldoSoles < 3500)
            {
                return "Menor a 3500";
            }
            else {
                return "Igual a 3500";
            }
        }
    }
}
