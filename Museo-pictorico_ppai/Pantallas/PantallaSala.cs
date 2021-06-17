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
        GestorPantallaEntrada _gestor = new GestorPantallaEntrada();


        public PantallaSala()
        {
            InitializeComponent();
        }

        private void PantallaSala_Load(object sender, EventArgs e)
        {
            lblCapacidad.Text = _sede.Cupo.ToString();
            lblVisitantes.Text = _gestor.MostrarVisitantes().ToString();
        }

        
    }
}
