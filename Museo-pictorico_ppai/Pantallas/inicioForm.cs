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
    public partial class InicioForm : Form
    {
        public object PantRegEntrada { get; private set; }

        public InicioForm()
        {
            InitializeComponent();
        }

        private void InicioForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrarVenta_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
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
    }
}
