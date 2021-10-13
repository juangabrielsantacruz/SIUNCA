namespace GUI.Seguridad.frmFamilia
{
    partial class frmAltaFamilia
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
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdFamilia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescripcionFamilia = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.dgvAltaFamilias = new System.Windows.Forms.DataGridView();
            this.button16 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltaFamilias)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(505, 154);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 67;
            this.label13.Text = "Descripcion";
            // 
            // txtIdFamilia
            // 
            this.txtIdFamilia.Location = new System.Drawing.Point(505, 95);
            this.txtIdFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdFamilia.Name = "txtIdFamilia";
            this.txtIdFamilia.Size = new System.Drawing.Size(259, 20);
            this.txtIdFamilia.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(502, 73);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "Id de Familia";
            // 
            // txtDescripcionFamilia
            // 
            this.txtDescripcionFamilia.Location = new System.Drawing.Point(504, 176);
            this.txtDescripcionFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionFamilia.Name = "txtDescripcionFamilia";
            this.txtDescripcionFamilia.Size = new System.Drawing.Size(259, 20);
            this.txtDescripcionFamilia.TabIndex = 64;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "Familias";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DodgerBlue;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Location = new System.Drawing.Point(40, 286);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(230, 36);
            this.button12.TabIndex = 62;
            this.button12.Text = "Recargar";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.DodgerBlue;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Location = new System.Drawing.Point(40, 356);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(166, 46);
            this.button13.TabIndex = 61;
            this.button13.Text = "Volver";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // dgvAltaFamilias
            // 
            this.dgvAltaFamilias.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAltaFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAltaFamilias.Location = new System.Drawing.Point(40, 75);
            this.dgvAltaFamilias.Name = "dgvAltaFamilias";
            this.dgvAltaFamilias.RowHeadersWidth = 57;
            this.dgvAltaFamilias.Size = new System.Drawing.Size(450, 205);
            this.dgvAltaFamilias.TabIndex = 60;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.DodgerBlue;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Location = new System.Drawing.Point(505, 244);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(258, 36);
            this.button16.TabIndex = 59;
            this.button16.Text = "Crear";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // frmAltaFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtIdFamilia);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDescripcionFamilia);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.dgvAltaFamilias);
            this.Controls.Add(this.button16);
            this.Name = "frmAltaFamilia";
            this.Text = "frmAltaFamilia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltaFamilias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIdFamilia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDescripcionFamilia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DataGridView dgvAltaFamilias;
        private System.Windows.Forms.Button button16;
    }
}