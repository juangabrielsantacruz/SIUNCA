namespace GUI.Seguridad.frmFamilia
{
    partial class frmBajaFamilia
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
            this.label25 = new System.Windows.Forms.Label();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.dgvBajaFamilias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajaFamilias)).BeginInit();
            this.SuspendLayout();
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(41, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 13);
            this.label25.TabIndex = 59;
            this.label25.Text = "Familias";
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.DodgerBlue;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button35.Location = new System.Drawing.Point(501, 244);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(258, 36);
            this.button35.TabIndex = 58;
            this.button35.Text = "Eliminar seleccionada";
            this.button35.UseVisualStyleBackColor = false;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.DodgerBlue;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button36.Location = new System.Drawing.Point(45, 286);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(230, 36);
            this.button36.TabIndex = 57;
            this.button36.Text = "Recargar";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.DodgerBlue;
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button37.Location = new System.Drawing.Point(45, 356);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(166, 46);
            this.button37.TabIndex = 56;
            this.button37.Text = "Volver";
            this.button37.UseVisualStyleBackColor = false;
            // 
            // dgvBajaFamilias
            // 
            this.dgvBajaFamilias.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBajaFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBajaFamilias.Location = new System.Drawing.Point(45, 75);
            this.dgvBajaFamilias.Name = "dgvBajaFamilias";
            this.dgvBajaFamilias.RowHeadersWidth = 57;
            this.dgvBajaFamilias.Size = new System.Drawing.Size(450, 205);
            this.dgvBajaFamilias.TabIndex = 55;
            // 
            // frmBajaFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.dgvBajaFamilias);
            this.Name = "frmBajaFamilia";
            this.Text = "frmBajaFamilia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajaFamilias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.DataGridView dgvBajaFamilias;
    }
}