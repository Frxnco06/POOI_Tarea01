using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema09
{
    internal class Pelota
    {
        public string marca {  get; set; }
        public double pesoGramos {  get; set; }
        public double presionLibras {  get; set; }
        public double diametroCentimetros { get; set; }
        public double precio {  get; set; }

        public Pelota(string marca, double pesoGramos, double presionLibras, double diametroCentimetros, double precio)
        {
            this.marca = marca;
            this.pesoGramos = pesoGramos;
            this.presionLibras = presionLibras;
            this.diametroCentimetros = diametroCentimetros;
            this.precio = precio;
        }

        public double radio() {
            return diametroCentimetros / 2;
        }
        public double volumenBalon() { 
            return 4*3.1416*radio()*radio()*radio()/3;
        }
        public double descuento() {
            return precio * 0.10;
        }
        public double importePagar() {
            return precio-descuento();
        }
    }
}
