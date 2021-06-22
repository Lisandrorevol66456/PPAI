using Museo_pictorico_ppai.Entidades;
using Museo_pictorico_ppai.Modelos;
using Museo_pictorico_ppai.Pantallas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museo_pictorico_ppai.Forms
{
    public partial class PantallaPrincipal : Form
    {
        Sesion _sesion;
        Sede _sede = new Sede();
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void InicioForm_Load(object sender, EventArgs e)
        {
            //Sesion hardcodeada
            Usuario _us = new Usuario();
            _sesion = new Sesion()
            {
                FechaInicio = System.DateTime.Now.Date.ToString(),
                HoraInicio = System.DateTime.Now.Hour.ToString() + System.DateTime.Now.Minute.ToString() + System.DateTime.Now.Second.ToString(),
                usuarioSesion = _us.sesionhardcodeada()
            };
            actualizarCantVisitantes();
        }

        private void BtnRegistrarVenta_Click(object sender, EventArgs e)
        {
            PantallaVentaEntradas ventana = new PantallaVentaEntradas(_sesion);
            ventana.ShowDialog();
            this.Close();
        }

        private void BtnPantallaSala_Click(object sender, EventArgs e)
        {
            PantallaSala ventana = new PantallaSala();
            ventana.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show($"                      ¿Salir?",
                 "Finalizar aplicación",
                   MessageBoxButtons.YesNo);
            if (confirmacion.Equals(DialogResult.No))
                return;
            this.Dispose();
        }
        public void actualizarCantVisitantes()
        {
            labelVisitantes.Text = _sede.calcularOcupacion(DateTime.Now).ToString();
            this.Refresh();
        }
    }
}
