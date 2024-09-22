using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema04
{
    internal class Obrero
    {
        public int codigo {  get; set; }
        public string nombre {  get; set; }
        public int horasTrabajadas {  get; set; }
        public double tarifaxHora {  get; set; }

        public Obrero(int codigo, string nombre, int horasTrabajadas, double tarifaxHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaxHora = tarifaxHora;
        }

        public double sueldoBruto() { 
            return horasTrabajadas * tarifaxHora;
        }
        public double descuentoAfp() { 
            return sueldoBruto()*0.10;
        }
        public double descuentoEps() {
            return sueldoBruto() * 0.05;
        }
        public double sueldoNeto() { 
            return sueldoBruto()-descuentoAfp()-descuentoEps();
        }
    }
}
