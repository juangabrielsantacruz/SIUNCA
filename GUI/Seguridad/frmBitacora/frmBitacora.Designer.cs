namespace GUI.Seguridad.frmBitacora
{
    partial class frmBitacora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoras)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBitacoras
            // 
            this.dgvBitacoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacoras.Location = new System.Drawing.Point(87, 372);
            this.dgvBitacoras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBitacoras.Name = "dgvBitacoras";
            this.dgvBitacoras.RowHeadersWidth = 51;
            this.dgvBitacoras.Size = new System.Drawing.Size(828, 294);
            this.dgvBitacoras.TabIndex = 50;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(923, 487);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(189, 66);
            this.button8.TabIndex = 49;
            this.button8.Text = "Eliminar todo";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Location = new System.Drawing.Point(923, 412);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(189, 68);
            this.Button1.TabIndex = 48;
            this.Button1.Text = "Volver";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(87, 212);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(277, 63);
            this.btnAgregar.TabIndex = 47;
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
            this.groupBox2.Location = new System.Drawing.Point(615, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(497, 292);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Location = new System.Drawing.Point(180, 235);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(308, 38);
            this.btnFiltrar.TabIndex = 40;
            this.btnFiltrar.Text = "Filtrar bitacoras comprobando DV";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnFiltrar1
            // 
            this.btnFiltrar1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFiltrar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar1.Location = new System.Drawing.Point(275, 129);
            this.btnFiltrar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrar1.Name = "btnFiltrar1";
            this.btnFiltrar1.Size = new System.Drawing.Size(212, 38);
            this.btnFiltrar1.TabIndex = 39;
            this.btnFiltrar1.Text = "Filtrar";
            this.btnFiltrar1.UseVisualStyleBackColor = false;
            this.btnFiltrar1.Click += new System.EventHandler(this.btnFiltrar1_Click);
            // 
            // cbEvento
            // 
            this.cbEvento.FormattingEnabled = true;
            this.cbEvento.Location = new System.Drawing.Point(180, 194);
            this.cbEvento.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbEvento.Name = "cbEvento";
            this.cbEvento.Size = new System.Drawing.Size(305, 24);
            this.cbEvento.TabIndex = 11;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 52);
            this.Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 17);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Criticidad TB";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(11, 204);
            this.Label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(76, 17);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Evento (D)";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(11, 96);
            this.Label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(57, 17);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Usuario";
            // 
            // cbCriticidad
            // 
            this.cbCriticidad.FormattingEnabled = true;
            this.cbCriticidad.Location = new System.Drawing.Point(180, 42);
            this.cbCriticidad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbCriticidad.Name = "cbCriticidad";
            this.cbCriticidad.Size = new System.Drawing.Size(305, 24);
            this.cbCriticidad.TabIndex = 6;
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(180, 86);
            this.cbUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(305, 24);
            this.cbUsuario.TabIndex = 8;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(81, 128);
            this.Label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(81, 17);
            this.Label5.TabIndex = 45;
            this.Label5.Text = "Fecha Final";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(81, 59);
            this.Label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 17);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "Fecha Inicial";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(87, 89);
            this.dtpFechaInicial.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(451, 22);
            this.dtpFechaInicial.TabIndex = 43;
            this.dtpFechaInicial.Value = new System.DateTime(2015, 7, 11, 16, 23, 0, 0);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(87, 155);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(451, 22);
            this.dtpFechaFinal.TabIndex = 42;
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 702);
            this.Controls.Add(this.dgvBitacoras);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.dtpFechaFinal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBitacora";
            this.Text = "frmBitacora";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoras)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBitacoras;
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
    }
}