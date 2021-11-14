namespace GUI.PlanDeEstudio
{
    partial class frmCorrelatividad
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
            this.dgDetallesPlan = new System.Windows.Forms.DataGridView();
            this.dgDetallesDetalle = new System.Windows.Forms.DataGridView();
            this.btnAgregarCorrelativa = new System.Windows.Forms.Button();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarCorrelativas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDetallesPlan
            // 
            this.dgDetallesPlan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgDetallesPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetallesPlan.Location = new System.Drawing.Point(77, 77);
            this.dgDetallesPlan.Name = "dgDetallesPlan";
            this.dgDetallesPlan.Size = new System.Drawing.Size(536, 149);
            this.dgDetallesPlan.TabIndex = 41;
            // 
            // dgDetallesDetalle
            // 
            this.dgDetallesDetalle.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgDetallesDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetallesDetalle.Location = new System.Drawing.Point(46, 338);
            this.dgDetallesDetalle.Name = "dgDetallesDetalle";
            this.dgDetallesDetalle.Size = new System.Drawing.Size(283, 191);
            this.dgDetallesDetalle.TabIndex = 43;
            // 
            // btnAgregarCorrelativa
            // 
            this.btnAgregarCorrelativa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarCorrelativa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCorrelativa.Location = new System.Drawing.Point(180, 302);
            this.btnAgregarCorrelativa.Name = "btnAgregarCorrelativa";
            this.btnAgregarCorrelativa.Size = new System.Drawing.Size(121, 30);
            this.btnAgregarCorrelativa.TabIndex = 44;
            this.btnAgregarCorrelativa.Text = "Agregar correlativa";
            this.btnAgregarCorrelativa.UseVisualStyleBackColor = false;
            this.btnAgregarCorrelativa.Click += new System.EventHandler(this.btnAgregarCorrelativa_Click);
            // 
            // cbPlan
            // 
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(41, 18);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(121, 21);
            this.cbPlan.TabIndex = 46;
            this.cbPlan.Text = "Seleccionar plan";
            this.cbPlan.SelectedIndexChanged += new System.EventHandler(this.cbPlan_SelectedIndexChanged);
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(46, 308);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(121, 21);
            this.cbMateria.TabIndex = 47;
            this.cbMateria.Text = "Seleccionar materia";
            this.cbMateria.SelectedIndexChanged += new System.EventHandler(this.cbMateria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Traigo los detalles del plan";
            // 
            // btnGuardarCorrelativas
            // 
            this.btnGuardarCorrelativas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarCorrelativas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarCorrelativas.Location = new System.Drawing.Point(104, 535);
            this.btnGuardarCorrelativas.Name = "btnGuardarCorrelativas";
            this.btnGuardarCorrelativas.Size = new System.Drawing.Size(162, 41);
            this.btnGuardarCorrelativas.TabIndex = 49;
            this.btnGuardarCorrelativas.Text = "GUARDAR";
            this.btnGuardarCorrelativas.UseVisualStyleBackColor = false;
            this.btnGuardarCorrelativas.Click += new System.EventHandler(this.btnGuardarCorrelativas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Seleccione la materia a la que desea agregarle correlativas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(277, 191);
            this.dataGridView1.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Coreelativas que posee la materia seleccionada:";
            // 
            // frmCorrelatividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarCorrelativas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.cbPlan);
            this.Controls.Add(this.btnAgregarCorrelativa);
            this.Controls.Add(this.dgDetallesDetalle);
            this.Controls.Add(this.dgDetallesPlan);
            this.Name = "frmCorrelatividad";
            this.Text = "frmCorrelatividad";
            this.Load += new System.EventHandler(this.frmCorrelatividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDetallesPlan;
        private System.Windows.Forms.DataGridView dgDetallesDetalle;
        private System.Windows.Forms.Button btnAgregarCorrelativa;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarCorrelativas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}