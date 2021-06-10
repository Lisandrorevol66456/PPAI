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



        private void validatenumber(object sender, KeyPressEventArgs e)
        {
            v.ValidateSoloNumeros(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CargarComboTipos();
            this.CargarCompoTipoVisita();
            txtSede.Text = "01";
            txtCantentradas.Visible = false;
            BtnCheckear.Visible = false;
            checkedLogo.Visible = false;
            labelCantEntradas.Visible = false;
            labelWarnincupo.Visible = false;
            this.ActualizarEntradas();

        }

        private void CargarCompoTipoVisita()
        {
            var tipoVisita = _entradaRepo.ObtenerTiposVisita();
            cmbTipoVisita.ValueMember = "idTipo";
            cmbTipoVisita.DisplayMember = "nombre";
            cmbTipoVisita.DataSource = tipoVisita;
        }


        private void CargarComboTipos()
        {
            var tipoEntrada = _entradaRepo.ObtenerTiposEntradas();
            cmbTipos.ValueMember = "idTipo";
            cmbTipos.DisplayMember = "nombre";
            cmbTipos.DataSource = tipoEntrada;
        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCantEntradas_Click(object sender, EventArgs e)
        {
            txtCantentradas.Visible = true;
            labelCantEntradas.Visible = true;
            BtnCheckear.Visible = true;
        }

        private void ActualizarEntradas()
        {
            dgvEntradas.Rows.Clear();
            var entradas = _entradaRepo.ObtenerEntradas().Rows;
            var filas = new List<DataGridViewRow>();
            foreach (DataRow entr in entradas)
            {
                if (entr.HasErrors)
                    continue;
                var fila = new string[]
                {
                    entr.ItemArray[0].ToString(),
                    entr.ItemArray[1].ToString(),
                    entr.ItemArray[2].ToString(),
                    entr.ItemArray[3].ToString(),
                    entr.ItemArray[4].ToString(),
                };
                dgvEntradas.Rows.Add(fila);
            } 
        }

        private void BtnCheckear_Click(object sender, EventArgs e)
        {
            checkedLogo.Visible = true;
            labelWarnincupo.Visible = false;
        }
    }
}
