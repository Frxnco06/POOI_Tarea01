using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Tarea01
{
    internal class Celular
    {
        public int numero {  get; set; }
        public string usuario {  get; set; }
        public int sConsumidos {  get; set; }
        public double pSegundo {  get; set; }

        public Celular(int numero, string usuario, int sConsumidos, double pSegundo)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.sConsumidos = sConsumidos;
            this.pSegundo = pSegundo;
        }

        public double costoConsumo() {
            return sConsumidos*pSegundo;
        }
        public double igv() { 
            return costoConsumo()*0.18;
        }
        public double totalPagar() { 
            return costoConsumo()+igv();
        }
    }
}
