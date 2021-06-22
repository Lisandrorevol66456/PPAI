namespace Museo_pictorico_ppai
{
    partial class PantallaVentaEntradas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaVentaEntradas));
            this.dgvTarifas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCantEntradas = new System.Windows.Forms.Label();
            this.txtCantentradas = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbGuiaNo = new MaterialSkin.Controls.MaterialRadioButton();
            this.RbguiaSi = new MaterialSkin.Controls.MaterialRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSede = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnCheckear = new System.Windows.Forms.Button();
            this.checkedLogo = new System.Windows.Forms.PictureBox();
            this.labelWarnincupo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblDetalleVenta = new System.Windows.Forms.Label();
            this.LblCantEntradas = new System.Windows.Forms.Label();
            this.LblPrecioEntrada = new System.Windows.Forms.Label();
            this.LblMontoTotal = new System.Windows.Forms.Label();
            this.LblCantEntradasNum = new System.Windows.Forms.Label();
            this.LblPrecioEntradaNum = new System.Windows.Forms.Label();
            this.LblMontoTotalNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTarifas
            // 
            this.dgvTarifas.AllowUserToAddRows = false;
            this.dgvTarifas.AllowUserToDeleteRows = false;
            this.dgvTarifas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TipoVisita,
            this.TipoEntrada,
            this.precio});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarifas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTarifas.Location = new System.Drawing.Point(498, 111);
            this.dgvTarifas.Name = "dgvTarifas";
            this.dgvTarifas.ReadOnly = true;
            this.dgvTarifas.RowHeadersWidth = 51;
            this.dgvTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarifas.Size = new System.Drawing.Size(351, 223);
            this.dgvTarifas.TabIndex = 3;
            this.dgvTarifas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarifas_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            this.id.Frozen = true;
            this.id.HeaderText = "#";
            this.id.MaxInputLength = 3;
            this.id.MinimumWidth = 3;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 40;
            // 
            // TipoVisita
            // 
            this.TipoVisita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TipoVisita.DataPropertyName = "tipoVisita";
            this.TipoVisita.Frozen = true;
            this.TipoVisita.HeaderText = "Tipo de visita";
            this.TipoVisita.MinimumWidth = 6;
            this.TipoVisita.Name = "TipoVisita";
            this.TipoVisita.ReadOnly = true;
            this.TipoVisita.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoVisita.Width = 110;
            // 
            // TipoEntrada
            // 
            this.TipoEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TipoEntrada.DataPropertyName = "tipoEntrada";
            this.TipoEntrada.Frozen = true;
            this.TipoEntrada.HeaderText = "Tipo de entrada";
            this.TipoEntrada.MinimumWidth = 6;
            this.TipoEntrada.Name = "TipoEntrada";
            this.TipoEntrada.ReadOnly = true;
            this.TipoEntrada.Width = 90;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.precio.DataPropertyName = "precio";
            this.precio.Frozen = true;
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precio.Width = 60;
            // 
            // labelCantEntradas
            // 
            this.labelCantEntradas.AutoSize = true;
            this.labelCantEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantEntradas.Location = new System.Drawing.Point(8, 318);
            this.labelCantEntradas.Name = "labelCantEntradas";
            this.labelCantEntradas.Size = new System.Drawing.Size(140, 16);
            this.labelCantEntradas.TabIndex = 5;
            this.labelCantEntradas.Text = "Cantidad de entradas:";
            // 
            // txtCantentradas
            // 
            this.txtCantentradas.Location = new System.Drawing.Point(154, 318);
            this.txtCantentradas.MaxLength = 5;
            this.txtCantentradas.Name = "txtCantentradas";
            this.txtCantentradas.Size = new System.Drawing.Size(135, 21);
            this.txtCantentradas.TabIndex = 6;
            this.txtCantentradas.TextChanged += new System.EventHandler(this.TxtCantentradas_TextChanged);
            this.txtCantentradas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validatenumber);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(213, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(4, 27);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(56, 55);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbGuiaNo);
            this.groupBox1.Controls.Add(this.RbguiaSi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 114);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guía:";
            // 
            // RbGuiaNo
            // 
            this.RbGuiaNo.AutoSize = true;
            this.RbGuiaNo.Depth = 0;
            this.RbGuiaNo.Font = new System.Drawing.Font("Roboto", 10F);
            this.RbGuiaNo.Location = new System.Drawing.Point(16, 65);
            this.RbGuiaNo.Margin = new System.Windows.Forms.Padding(0);
            this.RbGuiaNo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RbGuiaNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.RbGuiaNo.Name = "RbGuiaNo";
            this.RbGuiaNo.Ripple = true;
            this.RbGuiaNo.Size = new System.Drawing.Size(47, 30);
            this.RbGuiaNo.TabIndex = 1;
            this.RbGuiaNo.TabStop = true;
            this.RbGuiaNo.Text = "No";
            this.RbGuiaNo.UseVisualStyleBackColor = true;
            // 
            // RbguiaSi
            // 
            this.RbguiaSi.AutoSize = true;
            this.RbguiaSi.Depth = 0;
            this.RbguiaSi.Font = new System.Drawing.Font("Roboto", 10F);
            this.RbguiaSi.Location = new System.Drawing.Point(16, 30);
            this.RbguiaSi.Margin = new System.Windows.Forms.Padding(0);
            this.RbguiaSi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RbguiaSi.MouseState = MaterialSkin.MouseState.HOVER;
            this.RbguiaSi.Name = "RbguiaSi";
            this.RbguiaSi.Ripple = true;
            this.RbguiaSi.Size = new System.Drawing.Size(41, 30);
            this.RbguiaSi.TabIndex = 0;
            this.RbguiaSi.TabStop = true;
            this.RbguiaSi.Text = "Sí";
            this.RbguiaSi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sede:";
            // 
            // txtSede
            // 
            this.txtSede.Location = new System.Drawing.Point(181, 80);
            this.txtSede.MaxLength = 5;
            this.txtSede.Name = "txtSede";
            this.txtSede.ReadOnly = true;
            this.txtSede.Size = new System.Drawing.Size(136, 21);
            this.txtSede.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 42);
            this.label4.TabIndex = 14;
            this.label4.Text = "Registro de entradas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 460);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // BtnCheckear
            // 
            this.BtnCheckear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCheckear.BackgroundImage")));
            this.BtnCheckear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCheckear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCheckear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckear.Location = new System.Drawing.Point(295, 312);
            this.BtnCheckear.Name = "BtnCheckear";
            this.BtnCheckear.Size = new System.Drawing.Size(43, 32);
            this.BtnCheckear.TabIndex = 19;
            this.BtnCheckear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckear.UseVisualStyleBackColor = true;
            this.BtnCheckear.Click += new System.EventHandler(this.tomarCantidadEntradas);
            // 
            // checkedLogo
            // 
            this.checkedLogo.Image = ((System.Drawing.Image)(resources.GetObject("checkedLogo.Image")));
            this.checkedLogo.Location = new System.Drawing.Point(344, 312);
            this.checkedLogo.Name = "checkedLogo";
            this.checkedLogo.Size = new System.Drawing.Size(35, 35);
            this.checkedLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.checkedLogo.TabIndex = 20;
            this.checkedLogo.TabStop = false;
            // 
            // labelWarnincupo
            // 
            this.labelWarnincupo.AutoSize = true;
            this.labelWarnincupo.ForeColor = System.Drawing.Color.Red;
            this.labelWarnincupo.Location = new System.Drawing.Point(151, 356);
            this.labelWarnincupo.Name = "labelWarnincupo";
            this.labelWarnincupo.Size = new System.Drawing.Size(163, 15);
            this.labelWarnincupo.TabIndex = 21;
            this.labelWarnincupo.Text = "*Excede cupo visitantes ";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(503, 279);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(154, 30);
            this.btnConfirmar.TabIndex = 22;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.tomarConfirmacionVenta);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.BackColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(747, 424);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 30);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 33);
            this.label5.TabIndex = 24;
            this.label5.Text = "Listado de tarifas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(495, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "*El servicio de guía tiene un cargo extra de $50 sobre el valor de la entrada.";
            // 
            // LblDetalleVenta
            // 
            this.LblDetalleVenta.AutoSize = true;
            this.LblDetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.LblDetalleVenta.Location = new System.Drawing.Point(497, 75);
            this.LblDetalleVenta.Name = "LblDetalleVenta";
            this.LblDetalleVenta.Size = new System.Drawing.Size(250, 33);
            this.LblDetalleVenta.TabIndex = 25;
            this.LblDetalleVenta.Text = "Detalle De Venta";
            this.LblDetalleVenta.Visible = false;
            // 
            // LblCantEntradas
            // 
            this.LblCantEntradas.AutoSize = true;
            this.LblCantEntradas.Location = new System.Drawing.Point(503, 122);
            this.LblCantEntradas.Name = "LblCantEntradas";
            this.LblCantEntradas.Size = new System.Drawing.Size(149, 15);
            this.LblCantEntradas.TabIndex = 26;
            this.LblCantEntradas.Text = "Cantidad de Entradas:";
            this.LblCantEntradas.Visible = false;
            // 
            // LblPrecioEntrada
            // 
            this.LblPrecioEntrada.AutoSize = true;
            this.LblPrecioEntrada.Location = new System.Drawing.Point(500, 159);
            this.LblPrecioEntrada.Name = "LblPrecioEntrada";
            this.LblPrecioEntrada.Size = new System.Drawing.Size(131, 15);
            this.LblPrecioEntrada.TabIndex = 27;
            this.LblPrecioEntrada.Text = "Precio por Entrada:";
            this.LblPrecioEntrada.Visible = false;
            // 
            // LblMontoTotal
            // 
            this.LblMontoTotal.AutoSize = true;
            this.LblMontoTotal.Location = new System.Drawing.Point(500, 194);
            this.LblMontoTotal.Name = "LblMontoTotal";
            this.LblMontoTotal.Size = new System.Drawing.Size(141, 15);
            this.LblMontoTotal.TabIndex = 28;
            this.LblMontoTotal.Text = "Monto Total a Pagar:";
            // 
            // LblCantEntradasNum
            // 
            this.LblCantEntradasNum.AutoSize = true;
            this.LblCantEntradasNum.Location = new System.Drawing.Point(658, 122);
            this.LblCantEntradasNum.Name = "LblCantEntradasNum";
            this.LblCantEntradasNum.Size = new System.Drawing.Size(0, 15);
            this.LblCantEntradasNum.TabIndex = 29;
            this.LblCantEntradasNum.Visible = false;
            // 
            // LblPrecioEntradaNum
            // 
            this.LblPrecioEntradaNum.AutoSize = true;
            this.LblPrecioEntradaNum.Location = new System.Drawing.Point(638, 159);
            this.LblPrecioEntradaNum.Name = "LblPrecioEntradaNum";
            this.LblPrecioEntradaNum.Size = new System.Drawing.Size(0, 15);
            this.LblPrecioEntradaNum.TabIndex = 30;
            this.LblPrecioEntradaNum.Visible = false;
            // 
            // LblMontoTotalNum
            // 
            this.LblMontoTotalNum.AutoSize = true;
            this.LblMontoTotalNum.Location = new System.Drawing.Point(648, 194);
            this.LblMontoTotalNum.Name = "LblMontoTotalNum";
            this.LblMontoTotalNum.Size = new System.Drawing.Size(0, 15);
            this.LblMontoTotalNum.TabIndex = 31;
            this.LblMontoTotalNum.Visible = false;
            // 
            // PantallaVentaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 606);
            this.Controls.Add(this.LblMontoTotalNum);
            this.Controls.Add(this.LblPrecioEntradaNum);
            this.Controls.Add(this.LblCantEntradasNum);
            this.Controls.Add(this.LblMontoTotal);
            this.Controls.Add(this.LblPrecioEntrada);
            this.Controls.Add(this.LblCantEntradas);
            this.Controls.Add(this.LblDetalleVenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.labelWarnincupo);
            this.Controls.Add(this.checkedLogo);
            this.Controls.Add(this.BtnCheckear);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSede);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCantentradas);
            this.Controls.Add(this.labelCantEntradas);
            this.Controls.Add(this.dgvTarifas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaVentaEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de entrada - Museo Pictórico Córdoba";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTarifas;
        private System.Windows.Forms.Label labelCantEntradas;
        private System.Windows.Forms.TextBox txtCantentradas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton RbGuiaNo;
        private MaterialSkin.Controls.MaterialRadioButton RbguiaSi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSede;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnCheckear;
        private System.Windows.Forms.PictureBox checkedLogo;
        private System.Windows.Forms.Label labelWarnincupo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Label LblDetalleVenta;
        private System.Windows.Forms.Label LblCantEntradas;
        private System.Windows.Forms.Label LblPrecioEntrada;
        private System.Windows.Forms.Label LblMontoTotal;
        private System.Windows.Forms.Label LblCantEntradasNum;
        private System.Windows.Forms.Label LblPrecioEntradaNum;
        private System.Windows.Forms.Label LblMontoTotalNum;
    }
}

