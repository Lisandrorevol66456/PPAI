using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Gestores.Entidades
{
    class Obra
    {
        private int alto;
        private int ancho;
        private int codigoSensor;
        private string descripcion;
        private int duracionExtendida;
        private int duracionResumida;
        private DateTime fechaCreacion;
        private DateTime fechaPrimerIngreso;
        private string nombreObra;
        private int peso;
        private float valuacion;

        public Obra()
        {

        }


       
        public int Alto 
        { 
          get => alto; 
          set => alto = value; 
        }
        public int Ancho { get => ancho; set => ancho = value; }
        public int CodigoSensor { get => codigoSensor; set => codigoSensor = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int DuracionExtendida { get => duracionExtendida; set => duracionExtendida = value; }
        public int DuracionResumida { get => duracionResumida; set => duracionResumida = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public DateTime FechaPrimerIngreso { get => fechaPrimerIngreso; set => fechaPrimerIngreso = value; }
        public string NombreObra { get => nombreObra; set => nombreObra = value; }
        public int Peso { get => peso; set => peso = value; }
        public float Valuacion { get => valuacion; set => valuacion = value; }
    }
}
