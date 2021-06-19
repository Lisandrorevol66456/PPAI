using Museo_pictorico_ppai.Modelos;
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
        GestorPantallaEntrada _gestorVentaEntrada;
        Sede _sede;

        public Form1()
        {
            InitializeComponent();
            _gestorVentaEntrada = new GestorPantallaEntrada();
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
            this.CargarDGVTarifas();
            btnConfirmar.Enabled = false;
            btnGuardar.Enabled = false;
            cmbTipoEntrada.SelectedIndex = -1;
            cmbTipoVisita.SelectedIndex = -1;


        }

        private void CargarCompoTipoVisita()
        {
            var tipoVisita = _gestorVentaEntrada.ObtenerTiposVisita();
            cmbTipoVisita.ValueMember = "idTipo";
            cmbTipoVisita.DisplayMember = "nombre";
            cmbTipoVisita.DataSource = tipoVisita;
        }


        private void CargarComboTipos()
        {
            var tipoEntrada = _gestorVentaEntrada.ObtenerTiposEntradas();
            cmbTipoEntrada.ValueMember = "idTipo";
            cmbTipoEntrada.DisplayMember = "nombre";
            cmbTipoEntrada.DataSource = tipoEntrada;
        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show($"¿Seguro desea cancelar la operación?",
                 "Cancelar operación",
                   MessageBoxButtons.YesNo);
            if (confirmacion.Equals(DialogResult.No))
                return;
            this.Dispose();
        }

        private void btnCantEntradas_Click(object sender, EventArgs e)
        {
            txtCantentradas.Visible = true;
            labelCantEntradas.Visible = true;
            BtnCheckear.Visible = true;
        }

        private void CargarDGVTarifas()
        {
            dgvTarifas.Rows.Clear();
            var tarifas = _gestorVentaEntrada.BuscarTarifas().Rows;
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
        private int TomarSeleccionTarifa()
        {         
            if (cmbTipoVisita.SelectedIndex == 0)
            {
                if(cmbTipoEntrada.SelectedIndex == 0)
                {
                    return 1;
                }
                if (cmbTipoEntrada.SelectedIndex == 1)
                {
                    return 2;
                }
                if (cmbTipoEntrada.SelectedIndex == 2)
                {
                    return 3;
                }
                if (cmbTipoEntrada.SelectedIndex == 3)
                {
                    return 4;
                }

            }
            if (cmbTipoVisita.SelectedIndex == 1)
            {
                if (cmbTipoEntrada.SelectedIndex == 0)
                {
                    return 5;
                }
                if (cmbTipoEntrada.SelectedIndex == 1)
                {
                    return 6;
                }
                if (cmbTipoEntrada.SelectedIndex == 2)
                {
                    return 7;
                }
                if (cmbTipoEntrada.SelectedIndex == 3)
                {
                    return 8;
                }
            }
                return -1;
        }

        public void btnGuardar_Click(object sender, EventArgs e) {
            var porcGuia = 50;
            var idSede = Int32.Parse(txtSede.Text);
            var tarifa = this.TomarSeleccionTarifa();
            var fechaHoraVenta = DateTime.Now;
            var cantidadVisita  = Int32.Parse(txtCantentradas.Text);
            if (tarifa == -1)
            {
                MessageBox.Show("error en tarifa");
                return;
            }
            var monto = this._gestorVentaEntrada.calcularMonto(tarifa);
            if(materialRadioButton1.Checked)
                monto = monto + porcGuia;

            var cantentradas = txtCantentradas.Text;
            var total = monto * Int32.Parse(txtCantentradas.Text);

            var confirmacion = MessageBox.Show($"Cantidad entradas:{cantentradas}" + "\n\r" +
                $" Sede: {idSede}" + "\n\r" +
                $" Precio: ${monto}" + "\n\r" +
                $" total: ${total}" + "\n\r" +
                $"\n\r" +
                $"\n\r" +
                $"                ¿Confirma?",
                 "Confirmar operación",
                   MessageBoxButtons.YesNo);
            if (confirmacion.Equals(DialogResult.No))
                return;

            for (var i = 1; i <= Int32.Parse(txtCantentradas.Text); i++)
            {
                var entrada = this._gestorVentaEntrada.CrearEntrada(); 
                entrada.fechaHoraVenta = fechaHoraVenta;
                entrada.monto = monto;
                entrada.tarifa = tarifa;
                entrada.idSede = idSede;

                if (_gestorVentaEntrada.Guardar(entrada)) ;
                //    i++;
            } MessageBox.Show("Entradas registradas correctamente");
            limpiarCampos();
            _gestorVentaEntrada.ActualizarVisitantes(cantidadVisita, idSede);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (true)
            {
                txtCantentradas.Enabled = false;
                cmbTipoEntrada.Enabled = false;
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
            cmbTipoEntrada.Enabled = true;
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

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show($"Se volverá a 0 el valor 'Cantidad de visitantes'",
                 "Confirmar operación",
                   MessageBoxButtons.YesNo);
            if (confirmacion.Equals(DialogResult.No))
                return;
            _gestorVentaEntrada.ResetearVisitantes(_sede.idSede);
            MessageBox.Show("Se reseteó valor 'Cantidad de visitantes' ");
        }
    }
}
