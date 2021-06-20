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
    public partial class Form1 : Form // clase de la pantalla para registrar nueva entrada(S)
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

        //funcion para validar que lo que se ingresa sea solo numeros. // utils - validateTextBox

        public void Validatenumber(object sender, KeyPressEventArgs e)
        {
            v.ValidateSoloNumeros(sender, e);
        }
        //carga el formulario al iniciar con los datos por default
        public void Form1_Load(object sender, EventArgs e)
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
        // funcion para carar el combobox correspondiente al tipo de visita

        public void CargarCompoTipoVisita()
        {
            var tipoVisita = _gestorVentaEntrada.ObtenerTiposVisita();
            cmbTipoVisita.ValueMember = "idTipo";
            cmbTipoVisita.DisplayMember = "nombre";
            cmbTipoVisita.DataSource = tipoVisita;
        }

        // funcion para carar el combobox correspondiente al tipo de entrada

        public void CargarComboTipos()
        {
            var tipoEntrada = _gestorVentaEntrada.ObtenerTiposEntradas();
            cmbTipoEntrada.ValueMember = "idTipo";
            cmbTipoEntrada.DisplayMember = "nombre";
            cmbTipoEntrada.DataSource = tipoEntrada;
        }

        //funcion click del boton cancelar (X)

        public void BtnCancelar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show($"¿Seguro que desea cancelar la operación?",
                 "Cancelar operación",
                   MessageBoxButtons.YesNo);
            if (confirmacion.Equals(DialogResult.No))
                return;
            this.Dispose();
        }
        //funcion click del boton cantidad de entradas, habilita el txt cantidad de entradas 
        public void BtnCantEntradas_Click(object sender, EventArgs e)
        {
            txtCantentradas.Visible = true;
            labelCantEntradas.Visible = true;
            BtnCheckear.Visible = true;
        }
        //funcion para llenar el data grid con datos de tarifas
        public void CargarDGVTarifas()
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
                   
                };
                dgvTarifas.Rows.Add(fila);
            } 
        }
        

        //funcion click del boton (?) verifica que la cantidad ingresada no supere cupo
        public void BtnCheckear_Click(object sender, EventArgs e)
        {
            if (txtCantentradas.Text != "" )
            {
                _gestorVentaEntrada.TomarCantidadEntradas(int.Parse(txtCantentradas.Text));
                if (materialRadioButton1.Checked || materialRadioButton2.Checked)
                {
                    if (_gestorVentaEntrada.ValidarCantidadVisitantes())
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
        //funcion que capta los datos ingresados y retorna la tarifa correspondiente
        public int TomarSeleccionTarifa()
        {         
            int tarifa = -1;
            if (cmbTipoVisita.SelectedIndex == 0)
            {
                if(cmbTipoEntrada.SelectedIndex == 0)
                {
                    tarifa= 1;
                }
                if (cmbTipoEntrada.SelectedIndex == 1)
                {
                    tarifa = 2;
                }
                if (cmbTipoEntrada.SelectedIndex == 2)
                {
                    tarifa = 3;
                }
                if (cmbTipoEntrada.SelectedIndex == 3)
                {
                    tarifa = 4;
                }

            }
            if (cmbTipoVisita.SelectedIndex == 1)
            {
                if (cmbTipoEntrada.SelectedIndex == 0)
                {
                    tarifa = 5;
                }
                if (cmbTipoEntrada.SelectedIndex == 1)
                {
                    tarifa = 6;
                }
                if (cmbTipoEntrada.SelectedIndex == 2)
                {
                    tarifa = 7;
                }
                if (cmbTipoEntrada.SelectedIndex == 3)
                {
                    tarifa = 8;
                }
            }
            _gestorVentaEntrada.TomarSeleccionTarifa(tarifa);
                return tarifa;
        }
        public int TomarCantidadEntradas()
        {
            int cantidadEntradas = Int32.Parse(txtCantentradas.Text);
            return cantidadEntradas;
        }
        //funcion del evento click del boton guardar
        public void BtnGuardar_Click(object sender, EventArgs e) {
            var porcGuia = 50;
            var guia = false;
            var g = "NO";
            var idSede = Int32.Parse(txtSede.Text);
            var tarifa = this.TomarSeleccionTarifa();
            var fechaHoraVenta = DateTime.Now;
            var cantidadVisita  = this.TomarCantidadEntradas();
            if (tarifa == -1)
            {
                MessageBox.Show("error en tarifa");
                return;
            }
           
            if (materialRadioButton1.Checked){
                guia = true;
                g = "SI";   };

            var monto = this._gestorVentaEntrada.CalcularTotalaPagar(tarifa,guia);
            //monto = monto + porcGuia;

            var cantentradas = txtCantentradas.Text;
            var total = monto * Int32.Parse(txtCantentradas.Text);

            var confirmacion = MessageBox.Show($"Cantidad entradas:{cantentradas}" + "\n\r" +
                $" Sede: {idSede}" + "\n\r" +
                $" Precio por entrada: ${monto}" + "\n\r" +
                $" Total: ${total}" + "\n\r" +
                $" Guía: {g}" + "\n\r" +
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

                _gestorVentaEntrada.Guardar(entrada);
                //    i++;
            } MessageBox.Show("Entradas registradas correctamente");
            LimpiarCampos();
            _gestorVentaEntrada.ActualizarVisitantes(cantidadVisita, idSede);

        }
        //funcion para confirmar los datos ingresados previos al guardar
        public void BtnConfirmar_Click(object sender, EventArgs e)
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
        // si se cambia algo del txt cant entradas se deshabilita el confirmar, pues hay que verificar nuevamente 
        private void TxtCantentradas_TextChanged(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = false;
        }
        // reseteo del formulario
        public void LimpiarCampos()
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
        //evento click del boton limpiar
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }
        // se crea esta funcion para resetar la cantidad de visitantes, llama a la funcion del gestor y vuelve a 0 la cant de visitas
        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
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
