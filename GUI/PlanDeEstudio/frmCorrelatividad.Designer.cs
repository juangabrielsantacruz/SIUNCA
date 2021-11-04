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
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDetallesPlan
            // 
            this.dgDetallesPlan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgDetallesPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetallesPlan.Location = new System.Drawing.Point(111, 173);
            this.dgDetallesPlan.Name = "dgDetallesPlan";
            this.dgDetallesPlan.Size = new System.Drawing.Size(536, 149);
            this.dgDetallesPlan.TabIndex = 41;
            // 
            // dgDetallesDetalle
            // 
            this.dgDetallesDetalle.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgDetallesDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetallesDetalle.Location = new System.Drawing.Point(111, 355);
            this.dgDetallesDetalle.Name = "dgDetallesDetalle";
            this.dgDetallesDetalle.Size = new System.Drawing.Size(536, 191);
            this.dgDetallesDetalle.TabIndex = 43;
            // 
            // btnAgregarCorrelativa
            // 
            this.btnAgregarCorrelativa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarCorrelativa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCorrelativa.Location = new System.Drawing.Point(653, 402);
            this.btnAgregarCorrelativa.Name = "btnAgregarCorrelativa";
            this.btnAgregarCorrelativa.Size = new System.Drawing.Size(162, 69);
            this.btnAgregarCorrelativa.TabIndex = 44;
            this.btnAgregarCorrelativa.Text = "Agregar correlativa (selected item del DG1 y agrego materia)";
            this.btnAgregarCorrelativa.UseVisualStyleBackColor = false;
            this.btnAgregarCorrelativa.Click += new System.EventHandler(this.btnAgregarCorrelativa_Click);
            // 
            // cbPlan
            // 
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(111, 18);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(121, 21);
            this.cbPlan.TabIndex = 46;
            this.cbPlan.Text = "Seleccionar plan";
            this.cbPlan.SelectedIndexChanged += new System.EventHandler(this.cbPlan_SelectedIndexChanged);
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(653, 355);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(121, 21);
            this.cbMateria.TabIndex = 47;
            this.cbMateria.Text = "Seleccionar materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Traigo los detalles del plan";
            // 
            // btnGuardarCorrelativas
            // 
            this.btnGuardarCorrelativas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarCorrelativas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarCorrelativas.Location = new System.Drawing.Point(653, 477);
            this.btnGuardarCorrelativas.Name = "btnGuardarCorrelativas";
            this.btnGuardarCorrelativas.Size = new System.Drawing.Size(162, 69);
            this.btnGuardarCorrelativas.TabIndex = 49;
            this.btnGuardarCorrelativas.Text = "GUARDAR";
            this.btnGuardarCorrelativas.UseVisualStyleBackColor = false;
            // 
            // frmCorrelatividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 558);
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
    }
}