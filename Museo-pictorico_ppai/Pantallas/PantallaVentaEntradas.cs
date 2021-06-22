using Museo_pictorico_ppai.Entidades;
using Museo_pictorico_ppai.Gestores.Entidades;
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
    public partial class PantallaVentaEntradas : Form // clase de la pantalla para registrar nueva entrada(S)
    {
        private int tarifaSeleccionada { get; set; }
        private int cantEntradas { get; set; }

        ValidateTextBox v;
        GestorVentaEntradas _gestorVentaEntrada;
        Sede _sede;

        public PantallaVentaEntradas(Sesion sesion)
        {
            InitializeComponent();
            _gestorVentaEntrada = new GestorVentaEntradas(sesion,this);
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
            txtSede.Text = "1";
            txtCantentradas.Enabled = false;
            BtnCheckear.Enabled = false;
            checkedLogo.Visible = false;
            labelCantEntradas.Enabled = false;
            labelWarnincupo.Visible = false;
            btnConfirmar.Visible = false;
            LblDetalleVenta.Visible = false;
            LblCantEntradas.Visible = false;
            LblCantEntradasNum.Visible = false;
            LblPrecioEntrada.Visible = false;
            LblPrecioEntradaNum.Visible = false;
            LblMontoTotal.Visible = false;
            LblMontoTotalNum.Visible = false;
            _gestorVentaEntrada.opcionVtaEntrada();


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

        //funcion click del boton (?) verifica que la cantidad ingresada no supere cupo
        public void tomarCantidadEntradas(object sender, EventArgs e)
        {
            if (RbguiaSi.Checked || RbGuiaNo.Checked)
            {

                try
                {
                    if (txtCantentradas.Text == "" || Convert.ToInt32(txtCantentradas.Text) == 0)
                        throw new ApplicationException("complete campo cantidad de entradas");
                    else
                    {
                        var cant = Convert.ToInt32(txtCantentradas.Text);
                        _gestorVentaEntrada.tomarCantidadEntradas(cant);
                        checkedLogo.Visible = true;
                    }

                }
                catch (ApplicationException mens)
                {
                    MessageBox.Show(mens.Message);
                    txtCantentradas.Focus();
                }

            }
            else { MessageBox.Show("Seleccione si desea un guía o no."); }
        }
        //funcion que capta los datos ingresados y retorna la tarifa correspondiente
        public void tomarSeleccionTarifa()
        {
            if (dgvTarifas.SelectedRows.Count == 1)
            {
                bool conGuia = false;
                Tarifa tarifaSelec = new Tarifa()
                {
                    idTarifa = Convert.ToInt32(dgvTarifas.SelectedRows[0].Cells["id"].Value.ToString()),
                    tipoDeEntradaTarifa = new TipoDeEntrada() { nombreTipoDeEntrada = dgvTarifas.SelectedRows[0].Cells["tipoEntrada"].Value.ToString() },
                    tipoVisitaTarifa = new TipoVisita() { Nombre = dgvTarifas.SelectedRows[0].Cells["tipoVisita"].Value.ToString() },
                    montoTarifa = Convert.ToInt32(dgvTarifas.SelectedRows[0].Cells["precio"].Value.ToString())
                };
                if (RbguiaSi.Checked)
                    conGuia = true;
                _gestorVentaEntrada.tomarTarifasSeleccionadas(tarifaSelec, conGuia);
            }
            else
                MessageBox.Show("Debe seleccionar solo una tarifa");
        }

        public void solicitarCantidadEntradas()
        {
            txtCantentradas.Enabled = true;
            labelCantEntradas.Enabled = true;
            BtnCheckear.Enabled = true;
        }

        public void mostrarDetalleVenta(int cantEntradas, int precioEntrada, int montoTotal)
        {
            label5.Visible = false;
            dgvTarifas.Visible = false;
            LblDetalleVenta.Visible = true;
            LblCantEntradas.Visible = true;
            LblCantEntradasNum.Visible = true;
            LblCantEntradasNum.Text = cantEntradas.ToString();
            LblPrecioEntrada.Visible = true;
            LblPrecioEntradaNum.Visible = true;
            LblPrecioEntradaNum.Text = precioEntrada.ToString();
            LblMontoTotal.Visible = true;
            LblMontoTotalNum.Visible = true;
            LblMontoTotalNum.Text = montoTotal.ToString();
        }

        public void solicitarConfirmacion()
        {
            btnConfirmar.Visible = true;
            btnConfirmar.Enabled = true;
        }
      
        //funcion para confirmar los datos ingresados
        public void tomarConfirmacionVenta(object sender, EventArgs e)
        {
            _gestorVentaEntrada.tomarConfirmacionVenta();
             MessageBox.Show("Se registro la venta con exito");
             btnConfirmar.Enabled = false;
            

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
            groupBox1.Enabled = true;
            checkedLogo.Visible = false;
            labelWarnincupo.Visible = false;
            btnConfirmar.Enabled = false;
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

        public void mostrarTarifasVigentes(DataTable tarifas)
        {
            dgvTarifas.DataSource = tarifas;
            
        }

        private void dgvTarifas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tomarSeleccionTarifa();
        }

    }
}
