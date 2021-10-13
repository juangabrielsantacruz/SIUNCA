namespace GUI.Seguridad.frmPatente
{
    partial class frmBajaPatente
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
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dgvBajaPatentes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajaPatentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Patentes";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(501, 244);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(258, 36);
            this.button8.TabIndex = 58;
            this.button8.Text = "Eliminar seleccionada";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DodgerBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(45, 286);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(230, 36);
            this.button9.TabIndex = 57;
            this.button9.Text = "Recargar";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DodgerBlue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(45, 356);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(166, 46);
            this.button10.TabIndex = 56;
            this.button10.Text = "Volver";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // dgvBajaPatentes
            // 
            this.dgvBajaPatentes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBajaPatentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBajaPatentes.Location = new System.Drawing.Point(45, 75);
            this.dgvBajaPatentes.Name = "dgvBajaPatentes";
            this.dgvBajaPatentes.RowHeadersWidth = 57;
            this.dgvBajaPatentes.Size = new System.Drawing.Size(450, 205);
            this.dgvBajaPatentes.TabIndex = 55;
            // 
            // frmBajaPatente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.dgvBajaPatentes);
            this.Name = "frmBajaPatente";
            this.Text = "frmBajaPatente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajaPatentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dgvBajaPatentes;
    }
}