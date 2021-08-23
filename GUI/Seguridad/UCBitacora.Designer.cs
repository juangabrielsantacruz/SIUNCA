namespace GUI.Seguridad
{
    partial class UCBitacora
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBitacoras = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnFiltrar1 = new System.Windows.Forms.Button();
            this.cbEvento = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.cbCriticidad = new System.Windows.Forms.ComboBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoras)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 638);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bitacora";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBitacoras);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.Button1);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Label5);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.dtpFechaInicial);
            this.groupBox1.Controls.Add(this.dtpFechaFinal);
            this.groupBox1.Location = new System.Drawing.Point(15, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 593);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitacora";
            // 
            // dgvBitacoras
            // 
            this.dgvBitacoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacoras.Location = new System.Drawing.Point(19, 302);
            this.dgvBitacoras.Name = "dgvBitacoras";
            this.dgvBitacoras.Size = new System.Drawing.Size(621, 239);
            this.dgvBitacoras.TabIndex = 41;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(646, 396);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(142, 54);
            this.button8.TabIndex = 40;
            this.button8.Text = "Eliminar todo";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Location = new System.Drawing.Point(646, 335);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(142, 55);
            this.Button1.TabIndex = 39;
            this.Button1.Text = "Volver";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(19, 172);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(208, 51);
            this.btnAgregar.TabIndex = 38;
            this.btnAgregar.Text = "Probar agregar Bitacora ";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFiltrar);
            this.groupBox2.Controls.Add(this.btnFiltrar1);
            this.groupBox2.Controls.Add(this.cbEvento);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.Label4);
            this.groupBox2.Controls.Add(this.cbCriticidad);
            this.groupBox2.Controls.Add(this.cbUsuario);
            this.groupBox2.Location = new System.Drawing.Point(418, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(373, 237);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Location = new System.Drawing.Point(207, 191);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(159, 31);
            this.btnFiltrar.TabIndex = 40;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnFiltrar1
            // 
            this.btnFiltrar1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFiltrar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar1.Location = new System.Drawing.Point(206, 105);
            this.btnFiltrar1.Name = "btnFiltrar1";
            this.btnFiltrar1.Size = new System.Drawing.Size(159, 31);
            this.btnFiltrar1.TabIndex = 39;
            this.btnFiltrar1.Text = "Filtrar";
            this.btnFiltrar1.UseVisualStyleBackColor = false;
            this.btnFiltrar1.Click += new System.EventHandler(this.btnFiltrar1_Click);
            // 
            // cbEvento
            // 
            this.cbEvento.FormattingEnabled = true;
            this.cbEvento.Location = new System.Drawing.Point(135, 158);
            this.cbEvento.Margin = new System.Windows.Forms.Padding(4);
            this.cbEvento.Name = "cbEvento";
            this.cbEvento.Size = new System.Drawing.Size(230, 28);
            this.cbEvento.TabIndex = 11;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 42);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(111, 20);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Criticidad TB";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 166);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 20);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Evento (D)";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 78);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(71, 20);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Usuario";
            // 
            // cbCriticidad
            // 
            this.cbCriticidad.FormattingEnabled = true;
            this.cbCriticidad.Location = new System.Drawing.Point(135, 34);
            this.cbCriticidad.Margin = new System.Windows.Forms.Padding(4);
            this.cbCriticidad.Name = "cbCriticidad";
            this.cbCriticidad.Size = new System.Drawing.Size(230, 28);
            this.cbCriticidad.TabIndex = 6;
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(135, 70);
            this.cbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(230, 28);
            this.cbUsuario.TabIndex = 8;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(15, 104);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(103, 20);
            this.Label5.TabIndex = 33;
            this.Label5.Text = "Fecha Final";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(15, 48);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(111, 20);
            this.Label2.TabIndex = 32;
            this.Label2.Text = "Fecha Inicial";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(19, 72);
            this.dtpFechaInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(339, 26);
            this.dtpFechaInicial.TabIndex = 31;
            this.dtpFechaInicial.Value = new System.DateTime(2015, 7, 11, 16, 23, 0, 0);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(19, 126);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(339, 26);
            this.dtpFechaFinal.TabIndex = 30;
            // 
            // UCBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UCBitacora";
            this.Size = new System.Drawing.Size(854, 638);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoras)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnFiltrar1;
        internal System.Windows.Forms.ComboBox cbEvento;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cbCriticidad;
        internal System.Windows.Forms.ComboBox cbUsuario;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker dtpFechaInicial;
        internal System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DataGridView dgvBitacoras;
    }
}
