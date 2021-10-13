namespace GUI.Seguridad.frmFamilia
{
    partial class frmModificarFamilia
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
            this.label23 = new System.Windows.Forms.Label();
            this.txtModDescripcionFamilia = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.dgvModFamilias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModFamilias)).BeginInit();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(500, 75);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 67;
            this.label23.Text = "Descripcion";
            // 
            // txtModDescripcionFamilia
            // 
            this.txtModDescripcionFamilia.Location = new System.Drawing.Point(500, 101);
            this.txtModDescripcionFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.txtModDescripcionFamilia.Name = "txtModDescripcionFamilia";
            this.txtModDescripcionFamilia.Size = new System.Drawing.Size(259, 20);
            this.txtModDescripcionFamilia.TabIndex = 66;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(41, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 65;
            this.label24.Text = "Familias";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DodgerBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Location = new System.Drawing.Point(501, 244);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(258, 36);
            this.button11.TabIndex = 64;
            this.button11.Text = "Modificar seleccionada";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.DodgerBlue;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button33.Location = new System.Drawing.Point(45, 286);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(230, 36);
            this.button33.TabIndex = 63;
            this.button33.Text = "Recargar";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.DodgerBlue;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button34.Location = new System.Drawing.Point(45, 356);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(166, 46);
            this.button34.TabIndex = 62;
            this.button34.Text = "Volver";
            this.button34.UseVisualStyleBackColor = false;
            // 
            // dgvModFamilias
            // 
            this.dgvModFamilias.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvModFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModFamilias.Location = new System.Drawing.Point(45, 75);
            this.dgvModFamilias.Name = "dgvModFamilias";
            this.dgvModFamilias.RowHeadersWidth = 57;
            this.dgvModFamilias.Size = new System.Drawing.Size(450, 205);
            this.dgvModFamilias.TabIndex = 61;
            // 
            // frmModificarFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtModDescripcionFamilia);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.dgvModFamilias);
            this.Name = "frmModificarFamilia";
            this.Text = "frmModificarFamilia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModFamilias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtModDescripcionFamilia;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.DataGridView dgvModFamilias;
    }
}