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
            this.ComboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumeroMateria = new System.Windows.Forms.Label();
            this.txtNumeroMateria = new System.Windows.Forms.TextBox();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.ComboObligatoriedad = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgPEMaterias = new System.Windows.Forms.DataGridView();
            this.button11 = new System.Windows.Forms.Button();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblObligatoriedad = new System.Windows.Forms.Label();
            this.lblMatConCorr = new System.Windows.Forms.Label();
            this.ComboMaterias1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // 
            // lblNombrePlan
            // 
            this.lblNombrePlan.AutoSize = true;
            this.lblNombrePlan.Location = new System.Drawing.Point(69, 76);
            this.lblNombrePlan.Name = "lblNombrePlan";
            this.lblNombrePlan.Size = new System.Drawing.Size(84, 13);
            this.lblNombrePlan.TabIndex = 12;
            this.lblNombrePlan.Text = "Nombre del plan";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(112, 108);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(41, 13);
            this.lblCarrera.TabIndex = 18;
            this.lblCarrera.Text = "Carrera";
            // 
            // ComboBox3
            // 
            this.ComboBox3.FormattingEnabled = true;
            this.ComboBox3.Location = new System.Drawing.Point(181, 102);
            this.ComboBox3.Name = "ComboBox3";
            this.ComboBox3.Size = new System.Drawing.Size(121, 21);
            this.ComboBox3.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblNumeroMateria
            // 
            this.lblNumeroMateria.AutoSize = true;
            this.lblNumeroMateria.Location = new System.Drawing.Point(377, 169);
            this.lblNumeroMateria.Name = "lblNumeroMateria";
            this.lblNumeroMateria.Size = new System.Drawing.Size(99, 13);
            this.lblNumeroMateria.TabIndex = 14;
            this.lblNumeroMateria.Text = "Numero De Materia";
            // 
            // txtNumeroMateria
            // 
            this.txtNumeroMateria.Location = new System.Drawing.Point(482, 167);
            this.txtNumeroMateria.Name = "txtNumeroMateria";
            this.txtNumeroMateria.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroMateria.TabIndex = 4;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(482, 136);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(121, 20);
            this.txtCargaHoraria.TabIndex = 3;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(482, 106);
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
            this.ComboObligatoriedad.Location = new System.Drawing.Point(482, 72);
            this.ComboObligatoriedad.Name = "ComboObligatoriedad";
            this.ComboObligatoriedad.Size = new System.Drawing.Size(121, 21);
            this.ComboObligatoriedad.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(848, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 42);
            this.button5.TabIndex = 34;
            this.button5.Text = "Quitar materia";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(848, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 62);
            this.button4.TabIndex = 35;
            this.button4.Text = "Agregar materia";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dgPEMaterias
            // 
            this.dgPEMaterias.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgPEMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPEMaterias.Location = new System.Drawing.Point(50, 282);
            this.dgPEMaterias.Name = "dgPEMaterias";
            this.dgPEMaterias.Size = new System.Drawing.Size(776, 301);
            this.dgPEMaterias.TabIndex = 40;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DodgerBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Location = new System.Drawing.Point(848, 540);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(207, 43);
            this.button11.TabIndex = 34;
            this.button11.Text = "Agregar correlativas";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Location = new System.Drawing.Point(404, 138);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(72, 13);
            this.lblCargaHoraria.TabIndex = 23;
            this.lblCargaHoraria.Text = "Carga Horaria";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(450, 107);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 22;
            this.lblAño.Text = "Año";
            // 
            // lblObligatoriedad
            // 
            this.lblObligatoriedad.AutoSize = true;
            this.lblObligatoriedad.Location = new System.Drawing.Point(401, 75);
            this.lblObligatoriedad.Name = "lblObligatoriedad";
            this.lblObligatoriedad.Size = new System.Drawing.Size(75, 13);
            this.lblObligatoriedad.TabIndex = 21;
            this.lblObligatoriedad.Text = "Obligatoriedad";
            // 
            // lblMatConCorr
            // 
            this.lblMatConCorr.AutoSize = true;
            this.lblMatConCorr.Location = new System.Drawing.Point(434, 203);
            this.lblMatConCorr.Name = "lblMatConCorr";
            this.lblMatConCorr.Size = new System.Drawing.Size(42, 13);
            this.lblMatConCorr.TabIndex = 43;
            this.lblMatConCorr.Text = "Materia";
            // 
            // ComboMaterias1
            // 
            this.ComboMaterias1.FormattingEnabled = true;
            this.ComboMaterias1.Location = new System.Drawing.Point(482, 200);
            this.ComboMaterias1.Name = "ComboMaterias1";
            this.ComboMaterias1.Size = new System.Drawing.Size(121, 21);
            this.ComboMaterias1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Aca Agrego los detalles";
            // 
            // frmPlanDeEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 630);
            this.Controls.Add(this.lblNombrePlan);
            this.Controls.Add(this.lblCargaHoraria);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.ComboMaterias1);
            this.Controls.Add(this.ComboBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMatConCorr);
            this.Controls.Add(this.lblObligatoriedad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumeroMateria);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.txtNumeroMateria);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.dgPEMaterias);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.ComboObligatoriedad);
            this.Controls.Add(this.btnGuardarPE);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Name = "frmPlanDeEstudio";
            this.Text = "frmPlanDeEstudio";
            ((System.ComponentModel.ISupportInitialize)(this.dgPEMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Button btnGuardarPE;
        private System.Windows.Forms.Label lblNombrePlan;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox ComboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNumeroMateria;
        private System.Windows.Forms.TextBox txtNumeroMateria;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.ComboBox ComboObligatoriedad;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgPEMaterias;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblObligatoriedad;
        private System.Windows.Forms.Label lblMatConCorr;
        private System.Windows.Forms.ComboBox ComboMaterias1;
        private System.Windows.Forms.Label label1;
    }
}