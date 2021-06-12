namespace Museo_pictorico_ppai
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.Nro_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.labelCantEntradas = new System.Windows.Forms.Label();
            this.txtCantentradas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSede = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCantEntradas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoVisita = new System.Windows.Forms.ComboBox();
            this.BtnCheckear = new System.Windows.Forms.Button();
            this.checkedLogo = new System.Windows.Forms.PictureBox();
            this.labelWarnincupo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(863, 294);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 55);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.AllowUserToDeleteRows = false;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_Entrada,
            this.fechaventa,
            this.horaVenta,
            this.monto,
            this.Tarifa,
            this.sede});
            this.dgvEntradas.Location = new System.Drawing.Point(381, 77);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.Size = new System.Drawing.Size(538, 211);
            this.dgvEntradas.TabIndex = 3;
            // 
            // Nro_Entrada
            // 
            this.Nro_Entrada.Frozen = true;
            this.Nro_Entrada.HeaderText = "Nro Entrada";
            this.Nro_Entrada.Name = "Nro_Entrada";
            this.Nro_Entrada.ReadOnly = true;
            // 
            // fechaventa
            // 
            this.fechaventa.Frozen = true;
            this.fechaventa.HeaderText = "Fecha venta";
            this.fechaventa.Name = "fechaventa";
            this.fechaventa.ReadOnly = true;
            // 
            // horaVenta
            // 
            this.horaVenta.Frozen = true;
            this.horaVenta.HeaderText = "Hora";
            this.horaVenta.Name = "horaVenta";
            this.horaVenta.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.Frozen = true;
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // Tarifa
            // 
            this.Tarifa.Frozen = true;
            this.Tarifa.HeaderText = "Tarifa ";
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.ReadOnly = true;
            // 
            // sede
            // 
            this.sede.Frozen = true;
            this.sede.HeaderText = "Sede";
            this.sede.Name = "sede";
            this.sede.ReadOnly = true;
            // 
            // cmbTipos
            // 
            this.cmbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Location = new System.Drawing.Point(182, 281);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(135, 23);
            this.cmbTipos.TabIndex = 4;
            // 
            // labelCantEntradas
            // 
            this.labelCantEntradas.AutoSize = true;
            this.labelCantEntradas.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantEntradas.Location = new System.Drawing.Point(61, 365);
            this.labelCantEntradas.Name = "labelCantEntradas";
            this.labelCantEntradas.Size = new System.Drawing.Size(114, 16);
            this.labelCantEntradas.TabIndex = 5;
            this.labelCantEntradas.Text = "cantidad de entradas:";
            // 
            // txtCantentradas
            // 
            this.txtCantentradas.Location = new System.Drawing.Point(182, 362);
            this.txtCantentradas.MaxLength = 5;
            this.txtCantentradas.Name = "txtCantentradas";
            this.txtCantentradas.Size = new System.Drawing.Size(135, 22);
            this.txtCantentradas.TabIndex = 6;
            this.txtCantentradas.TextChanged += new System.EventHandler(this.txtCantentradas_TextChanged);
            this.txtCantentradas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validatenumber);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipos de entrada:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(213, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(707, 137);
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
            this.btnCancelar.Location = new System.Drawing.Point(801, 294);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(56, 55);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialRadioButton2);
            this.groupBox1.Controls.Add(this.materialRadioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 114);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guía:";
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(16, 65);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(47, 30);
            this.materialRadioButton2.TabIndex = 1;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "No";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(16, 30);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(41, 30);
            this.materialRadioButton1.TabIndex = 0;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Sí";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sede:";
            // 
            // txtSede
            // 
            this.txtSede.Location = new System.Drawing.Point(181, 80);
            this.txtSede.MaxLength = 5;
            this.txtSede.Name = "txtSede";
            this.txtSede.ReadOnly = true;
            this.txtSede.Size = new System.Drawing.Size(136, 22);
            this.txtSede.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 41);
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
            // btnCantEntradas
            // 
            this.btnCantEntradas.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantEntradas.Location = new System.Drawing.Point(81, 310);
            this.btnCantEntradas.Name = "btnCantEntradas";
            this.btnCantEntradas.Size = new System.Drawing.Size(236, 27);
            this.btnCantEntradas.TabIndex = 16;
            this.btnCantEntradas.Text = "Seleccione cantidad de entradas";
            this.btnCantEntradas.UseVisualStyleBackColor = true;
            this.btnCantEntradas.Click += new System.EventHandler(this.btnCantEntradas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipos de visita:";
            // 
            // cmbTipoVisita
            // 
            this.cmbTipoVisita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVisita.FormattingEnabled = true;
            this.cmbTipoVisita.Location = new System.Drawing.Point(181, 111);
            this.cmbTipoVisita.Name = "cmbTipoVisita";
            this.cmbTipoVisita.Size = new System.Drawing.Size(135, 23);
            this.cmbTipoVisita.TabIndex = 17;
            // 
            // BtnCheckear
            // 
            this.BtnCheckear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCheckear.BackgroundImage")));
            this.BtnCheckear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCheckear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckear.Location = new System.Drawing.Point(322, 356);
            this.BtnCheckear.Name = "BtnCheckear";
            this.BtnCheckear.Size = new System.Drawing.Size(43, 32);
            this.BtnCheckear.TabIndex = 19;
            this.BtnCheckear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckear.UseVisualStyleBackColor = true;
            this.BtnCheckear.Click += new System.EventHandler(this.BtnCheckear_Click);
            // 
            // checkedLogo
            // 
            this.checkedLogo.Image = ((System.Drawing.Image)(resources.GetObject("checkedLogo.Image")));
            this.checkedLogo.Location = new System.Drawing.Point(371, 353);
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
            this.labelWarnincupo.Location = new System.Drawing.Point(181, 391);
            this.labelWarnincupo.Name = "labelWarnincupo";
            this.labelWarnincupo.Size = new System.Drawing.Size(142, 15);
            this.labelWarnincupo.TabIndex = 21;
            this.labelWarnincupo.Text = "*Excede cupo visitantes ";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(63, 409);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(154, 30);
            this.btnConfirmar.TabIndex = 22;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.BackColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(223, 409);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 30);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 606);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.labelWarnincupo);
            this.Controls.Add(this.checkedLogo);
            this.Controls.Add(this.BtnCheckear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoVisita);
            this.Controls.Add(this.btnCantEntradas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSede);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantentradas);
            this.Controls.Add(this.labelCantEntradas);
            this.Controls.Add(this.cmbTipos);
            this.Controls.Add(this.dgvEntradas);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de entrada - Museo Pictórico Córdoba";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.Label labelCantEntradas;
        private System.Windows.Forms.TextBox txtCantentradas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSede;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCantEntradas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoVisita;
        private System.Windows.Forms.Button BtnCheckear;
        private System.Windows.Forms.PictureBox checkedLogo;
        private System.Windows.Forms.Label labelWarnincupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sede;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

