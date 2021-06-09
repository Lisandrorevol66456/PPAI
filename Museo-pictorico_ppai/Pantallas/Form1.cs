using Museo_pictorico_ppai.Repositorios;
using Museo_pictorico_ppai.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museo_pictorico_ppai
{
    public partial class Form1 : Form
    {
        ValidateTextBox v;
        EntradaRepositorio _entradaRepo;

        public Form1()
        {
            InitializeComponent();
            _entradaRepo = new EntradaRepositorio();
            v = new ValidateTextBox();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void validatenumber(object sender, KeyPressEventArgs e)
        {
            v.ValidateSoloNumeros(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CargarComboTipos();
            txtSede.Text = "01";
        }

        private void CargarComboTipos()
        {
            var tipoEntrada = _entradaRepo.ObtenerTiposEntradas();
            cmbTipos.ValueMember = "idTipo";
            cmbTipos.DisplayMember = "nombre";
            cmbTipos.DataSource = tipoEntrada;
        }















        private void validateNumeros(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtSede_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
