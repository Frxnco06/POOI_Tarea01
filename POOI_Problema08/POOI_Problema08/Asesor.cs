using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema08
{
    internal class Asesor
    {
        public int codigo {  get; set; }
        public string nombre {  get; set; }
        public int horasTrabajadas {  get; set; }
        public double tarifaxHora {  get; set; }

        public Asesor(int codigo, string nombre, int horasTrabajadas, double tarifaxHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaxHora = tarifaxHora;
        }

        public double sueldoBruto() { 
            return horasTrabajadas*tarifaxHora;
        }
        public double descuento() {
            return sueldoBruto() * 0.15;
        }
        public double sueldoNeto() { 
            return sueldoBruto()-descuento();
        }
    }
}
