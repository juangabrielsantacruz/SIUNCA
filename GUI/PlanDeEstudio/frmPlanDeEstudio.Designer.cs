namespace GUI.PlanDeEstudio
{
    partial class frmPlanDeEstudio
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
            this.labelMensaje = new System.Windows.Forms.Label();
            this.btnGuardarPE = new System.Windows.Forms.Button();
            this.lblNombrePlan = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.txtCuatrimestre = new System.Windows.Forms.TextBox();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.ComboObligatoriedad = new System.Windows.Forms.ComboBox();
            this.btnQuitarMateria = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.dgPEMaterias = new System.Windows.Forms.DataGridView();
            this.btnAgregarCorrelativas = new System.Windows.Forms.Button();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblObligatoriedad = new System.Windows.Forms.Label();
            this.lblMatConCorr = new System.Windows.Forms.Label();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroMateria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPEMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Location = new System.Drawing.Point(957, 405);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(98, 13);
            this.labelMensaje.TabIndex = 39;
            this.labelMensaje.Text = "Mensaje validacion";
            this.labelMensaje.Visible = false;
            // 
            // btnGuardarPE
            // 
            this.btnGuardarPE.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarPE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarPE.Location = new System.Drawing.Point(848, 436);
            this.btnGuardarPE.Name = "btnGuardarPE";
            this.btnGuardarPE.Size = new System.Drawing.Size(207, 98);
            this.btnGuardarPE.TabIndex = 36;
            this.btnGuardarPE.Text = "Guardar plan de estudio";
            this.btnGuardarPE.UseVisualStyleBackColor = false;
            this.btnGuardarPE.Click += new System.EventHandler(this.btnGuardarPE_Click);
            // 
            // lblNombrePlan
            // 
            this.lblNombrePlan.AutoSize = true;
            this.lblNombrePlan.Location = new System.Drawing.Point(52, 120);
            this.lblNombrePlan.Name = "lblNombrePlan";
            this.lblNombrePlan.Size = new System.Drawing.Size(84, 13);
            this.lblNombrePlan.TabIndex = 12;
            this.lblNombrePlan.Text = "Nombre del plan";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(95, 152);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(41, 13);
            this.lblCarrera.TabIndex = 18;
            this.lblCarrera.Text = "Carrera";
            // 
            // cbCarrera
            // 
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Location = new System.Drawing.Point(164, 146);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(121, 21);
            this.cbCarrera.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(539, 142);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(65, 13);
            this.lblCuatrimestre.TabIndex = 14;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // txtCuatrimestre
            // 
            this.txtCuatrimestre.Location = new System.Drawing.Point(610, 140);
            this.txtCuatrimestre.Name = "txtCuatrimestre";
            this.txtCuatrimestre.Size = new System.Drawing.Size(121, 20);
            this.txtCuatrimestre.TabIndex = 4;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(610, 171);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(121, 20);
            this.txtCargaHoraria.TabIndex = 3;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(610, 111);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(121, 20);
            this.txtAño.TabIndex = 5;
            // 
            // ComboObligatoriedad
            // 
            this.ComboObligatoriedad.FormattingEnabled = true;
            this.ComboObligatoriedad.Items.AddRange(new object[] {
            "Obligatoria",
            "Opcional"});
            this.ComboObligatoriedad.Location = new System.Drawing.Point(408, 144);
            this.ComboObligatoriedad.Name = "ComboObligatoriedad";
            this.ComboObligatoriedad.Size = new System.Drawing.Size(121, 21);
            this.ComboObligatoriedad.TabIndex = 20;
            // 
            // btnQuitarMateria
            // 
            this.btnQuitarMateria.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQuitarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitarMateria.Location = new System.Drawing.Point(848, 360);
            this.btnQuitarMateria.Name = "btnQuitarMateria";
            this.btnQuitarMateria.Size = new System.Drawing.Size(207, 42);
            this.btnQuitarMateria.TabIndex = 34;
            this.btnQuitarMateria.Text = "Quitar materia";
            this.btnQuitarMateria.UseVisualStyleBackColor = false;
            this.btnQuitarMateria.Click += new System.EventHandler(this.btnQuitarMateria_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarMateria.Location = new System.Drawing.Point(848, 292);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(207, 62);
            this.btnAgregarMateria.TabIndex = 35;
            this.btnAgregarMateria.Text = "Agregar materia";
            this.btnAgregarMateria.UseVisualStyleBackColor = false;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // dgPEMaterias
            // 
            this.dgPEMaterias.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgPEMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPEMaterias.Location = new System.Drawing.Point(50, 239);
            this.dgPEMaterias.Name = "dgPEMaterias";
            this.dgPEMaterias.Size = new System.Drawing.Size(776, 344);
            this.dgPEMaterias.TabIndex = 40;
            // 
            // btnAgregarCorrelativas
            // 
            this.btnAgregarCorrelativas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarCorrelativas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCorrelativas.Location = new System.Drawing.Point(848, 540);
            this.btnAgregarCorrelativas.Name = "btnAgregarCorrelativas";
            this.btnAgregarCorrelativas.Size = new System.Drawing.Size(207, 43);
            this.btnAgregarCorrelativas.TabIndex = 34;
            this.btnAgregarCorrelativas.Text = "Agregar correlativas";
            this.btnAgregarCorrelativas.UseVisualStyleBackColor = false;
            this.btnAgregarCorrelativas.Click += new System.EventHandler(this.btnAgregarCorrelativas_Click);
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Location = new System.Drawing.Point(535, 174);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(72, 13);
            this.lblCargaHoraria.TabIndex = 23;
            this.lblCargaHoraria.Text = "Carga Horaria";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(578, 112);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 22;
            this.lblAño.Text = "Año";
            // 
            // lblObligatoriedad
            // 
            this.lblObligatoriedad.AutoSize = true;
            this.lblObligatoriedad.Location = new System.Drawing.Point(327, 147);
            this.lblObligatoriedad.Name = "lblObligatoriedad";
            this.lblObligatoriedad.Size = new System.Drawing.Size(75, 13);
            this.lblObligatoriedad.TabIndex = 21;
            this.lblObligatoriedad.Text = "Obligatoriedad";
            // 
            // lblMatConCorr
            // 
            this.lblMatConCorr.AutoSize = true;
            this.lblMatConCorr.Location = new System.Drawing.Point(360, 117);
            this.lblMatConCorr.Name = "lblMatConCorr";
            this.lblMatConCorr.Size = new System.Drawing.Size(42, 13);
            this.lblMatConCorr.TabIndex = 43;
            this.lblMatConCorr.Text = "Materia";
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(408, 114);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(121, 21);
            this.cbMateria.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Aca Agrego los detalles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Numero de materia";
            // 
            // txtNumeroMateria
            // 
            this.txtNumeroMateria.Location = new System.Drawing.Point(408, 174);
            this.txtNumeroMateria.Name = "txtNumeroMateria";
            this.txtNumeroMateria.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroMateria.TabIndex = 45;
            // 
            // frmPlanDeEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 630);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroMateria);
            this.Controls.Add(this.lblNombrePlan);
            this.Controls.Add(this.lblCargaHoraria);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.cbCarrera);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMatConCorr);
            this.Controls.Add(this.lblObligatoriedad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.btnAgregarCorrelativas);
            this.Controls.Add(this.txtCuatrimestre);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.dgPEMaterias);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.ComboObligatoriedad);
            this.Controls.Add(this.btnGuardarPE);
            this.Controls.Add(this.btnQuitarMateria);
            this.Controls.Add(this.btnAgregarMateria);
            this.Name = "frmPlanDeEstudio";
            this.Text = "frmPlanDeEstudio";
            this.Load += new System.EventHandler(this.frmPlanDeEstudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPEMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Button btnGuardarPE;
        private System.Windows.Forms.Label lblNombrePlan;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.TextBox txtCuatrimestre;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.ComboBox ComboObligatoriedad;
        private System.Windows.Forms.Button btnQuitarMateria;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.DataGridView dgPEMaterias;
        private System.Windows.Forms.Button btnAgregarCorrelativas;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblObligatoriedad;
        private System.Windows.Forms.Label lblMatConCorr;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroMateria;
    }
}