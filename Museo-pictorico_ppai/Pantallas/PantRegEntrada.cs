﻿using Museo_pictorico_ppai.Modelos;
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
        Sede _sede;

        public Form1()
        {
            InitializeComponent();
            _entradaRepo = new EntradaRepositorio();
            v = new ValidateTextBox();
            _sede = new Sede();
        }



        private void validatenumber(object sender, KeyPressEventArgs e)
        {
            v.ValidateSoloNumeros(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CargarComboTipos();
            this.CargarCompoTipoVisita();
            txtSede.Text = "1";
            txtCantentradas.Visible = false;
            BtnCheckear.Visible = false;
            checkedLogo.Visible = false;
            labelCantEntradas.Visible = false;
            labelWarnincupo.Visible = false;
            this.ActualizarTarifas();
            btnConfirmar.Enabled = false;
            btnGuardar.Enabled = false;


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

        private void ActualizarTarifas()
        {
            dgvTarifas.Rows.Clear();
            var tarifas = _entradaRepo.ObtenerTarifas().Rows;
            var filas = new List<DataGridViewRow>();
            foreach (DataRow tar in tarifas)
            {
                if (tar.HasErrors)
                    continue;
                var fila = new string[]
                {
                    tar.ItemArray[0].ToString(),
                    tar.ItemArray[1].ToString(),
                    tar.ItemArray[2].ToString(),
                    tar.ItemArray[3].ToString(),
                    //tar.ItemArray[4].ToString(),
                };
                dgvTarifas.Rows.Add(fila);
            } 
        }
       


        private void BtnCheckear_Click(object sender, EventArgs e)
        {
            if (txtCantentradas.Text != "" )
            {
                if (materialRadioButton1.Checked || materialRadioButton2.Checked)
                {
                    if (_sede.CheckearCupo(long.Parse(txtCantentradas.Text)))
                    {

                        checkedLogo.Visible = true;
                        labelWarnincupo.Visible = false;
                        btnConfirmar.Enabled = true;
                    }
                    else
                    {
                        checkedLogo.Visible = false;
                        labelWarnincupo.Visible = true;
                        btnConfirmar.Enabled = false;
                    }
                }else
                {
                    MessageBox.Show("complete campo guía");
                    groupBox1.Focus();
                }

            }else
            {
                MessageBox.Show("complete campo cantidad de entradas");
                txtCantentradas.Focus();
            }
            
        }
        private int calcularTarifa()
        {
            return 1;
        }

        public void btnGuardar_Click(object sender, EventArgs e) { 

            var idSede = Int32.Parse(txtSede.Text);
            var tarifa = this.calcularTarifa();
            var fechaHoraVenta = DateTime.Now;
            var monto = this.calcularMonto();
            var cantentradas = txtCantentradas.Text;

            var confirmacion = MessageBox.Show($"¿Confirma registro de la(s) {cantentradas} entrada(s), para la sede {idSede} por el monto {monto} ?",
                 "Confirmar operación",
                   MessageBoxButtons.YesNo);
            if (confirmacion.Equals(DialogResult.No))
                return;

            for (var i = 0; i <= Int32.Parse(txtCantentradas.Text); i++)
            {
                var entrada = new Entrada();
                entrada.fechaHoraVenta = fechaHoraVenta;
                entrada.monto = monto;
                entrada.tarifa = tarifa;
                entrada.idSede = idSede;             
                                
                //if (_entradaRepo.Guardar(entrada))
                //    i++;
            } MessageBox.Show("Entradas registradas correctamente");
            limpiarCampos();




        }
        private float calcularMonto()
        {
            float monto = 333;

            return monto;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (true)
            {
                txtCantentradas.Enabled = false;
                cmbTipos.Enabled = false;
                cmbTipoVisita.Enabled = false;
                groupBox1.Enabled = false;
                btnGuardar.Enabled = true;

            }
        }

        private void txtCantentradas_TextChanged(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = false;
        }
        private void limpiarCampos()
        {
            txtCantentradas.Enabled = true;
            txtCantentradas.Clear();
            cmbTipos.Enabled = true;
            cmbTipoVisita.Enabled = true;
            groupBox1.Enabled = true;
            checkedLogo.Visible = false;
            labelWarnincupo.Visible = false;
            btnConfirmar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();

        }
    }
}
