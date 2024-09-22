using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Problema05
{
    internal class Video
    {
        public int codigo {  get; set; }
        public string nomVideo {  get; set; }
        public double duracion {  get; set; }
        public double pSoles {  get; set; }
        public double tipoCambio {  get; set; }

        public Video(int codigo, string nomVideo, double duracion, double pSoles, double tipoCambio)
        {
            this.codigo = codigo;
            this.nomVideo = nomVideo;
            this.duracion = duracion;
            this.pSoles = pSoles;
            this.tipoCambio = tipoCambio;
        }

        public double videoDolares() { 
            return pSoles * tipoCambio;
        }
    }
}
