using Museo_pictorico_ppai.Modelos;
using Museo_pictorico_ppai.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museo_pictorico_ppai.Pantallas
{
    public partial class PantallaSala : Form
    {
        Sede _sede = new Sede();
        GestorVentaEntradas _gestor = new GestorVentaEntradas();


        public PantallaSala()
        {
            InitializeComponent();
            _sede.cantidadMaximaVisitantesSede = 500;            
        }

        private void PantallaSala_Load(object sender, EventArgs e)
        {
            lblCapacidad.Text = _sede.cantidadMaximaVisitantesSede.ToString();
            actualizarCantVisitantes();
        }
        public void actualizarCantVisitantes()
        {
            lblVisitantes.Text = _sede.calcularOcupacion(DateTime.Now).ToString();
        }
        

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
