using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema02
{
    internal class Computadora
    {
        public int codigo {  get; set; }
        public string marca {  get; set; }
        public string color {  get; set; }
        public double pDolares {  get; set; }

        public Computadora(int codigo, string marca, string color, double pDolares)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.pDolares = pDolares;
        }
        public double PrecioSoles() {
            return pDolares * 3.35;
        }
        public double PrecioEuros() {
            return pDolares * 1.20;
        }

    }
}
