using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema03
{
    internal class Edificio
    { 
        public int codigo {  get; set; }
        public int numeroDeDeportamentos {  get; set; }
        public int cantidadPisos {  get; set; }
        public double precioDepaDolares {  get; set; }

        public Edificio(int codigo, int numeroDeDeportamentos, int cantidadPisos, double precioDepaDolares)
        {
            this.codigo = codigo;
            this.numeroDeDeportamentos = numeroDeDeportamentos;
            this.cantidadPisos = cantidadPisos;
            this.precioDepaDolares = precioDepaDolares;
        }

        public double precioDolares() {
            return numeroDeDeportamentos * precioDepaDolares;
        }

    }
}
