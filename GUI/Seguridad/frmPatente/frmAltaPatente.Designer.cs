namespace GUI.Seguridad.frmPatente
{
    partial class frmAltaPatente
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcionPatente = new System.Windows.Forms.TextBox();
            this.lblIdPatente = new System.Windows.Forms.Label();
            this.txtIdPatente = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.dgvPatentes = new System.Windows.Forms.DataGridView();
            this.button32 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Descripcion";
            // 
            // txtDescripcionPatente
            // 
            this.txtDescripcionPatente.Location = new System.Drawing.Point(506, 181);
            this.txtDescripcionPatente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionPatente.Name = "txtDescripcionPatente";
            this.txtDescripcionPatente.Size = new System.Drawing.Size(259, 20);
            this.txtDescripcionPatente.TabIndex = 66;
            // 
            // lblIdPatente
            // 
            this.lblIdPatente.AutoSize = true;
            this.lblIdPatente.Location = new System.Drawing.Point(503, 74);
            this.lblIdPatente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPatente.Name = "lblIdPatente";
            this.lblIdPatente.Size = new System.Drawing.Size(71, 13);
            this.lblIdPatente.TabIndex = 65;
            this.lblIdPatente.Text = "Id de Patente";
            // 
            // txtIdPatente
            // 
            this.txtIdPatente.Location = new System.Drawing.Point(506, 105);
            this.txtIdPatente.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdPatente.Name = "txtIdPatente";
            this.txtIdPatente.Size = new System.Drawing.Size(259, 20);
            this.txtIdPatente.TabIndex = 64;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(36, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 63;
            this.label22.Text = "Patentes";
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.DodgerBlue;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button30.Location = new System.Drawing.Point(40, 286);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(230, 36);
            this.button30.TabIndex = 62;
            this.button30.Text = "Recargar";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.DodgerBlue;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button31.Location = new System.Drawing.Point(40, 356);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(166, 46);
            this.button31.TabIndex = 61;
            this.button31.Text = "Volver";
            this.button31.UseVisualStyleBackColor = false;
            // 
            // dgvPatentes
            // 
            this.dgvPatentes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPatentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatentes.Location = new System.Drawing.Point(40, 75);
            this.dgvPatentes.Name = "dgvPatentes";
            this.dgvPatentes.RowHeadersWidth = 57;
            this.dgvPatentes.Size = new System.Drawing.Size(450, 205);
            this.dgvPatentes.TabIndex = 60;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.DodgerBlue;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button32.Location = new System.Drawing.Point(506, 244);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(258, 36);
            this.button32.TabIndex = 59;
            this.button32.Text = "Crear";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // frmAltaPatente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescripcionPatente);
            this.Controls.Add(this.lblIdPatente);
            this.Controls.Add(this.txtIdPatente);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.dgvPatentes);
            this.Controls.Add(this.button32);
            this.Name = "frmAltaPatente";
            this.Text = "frmAltaPatente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcionPatente;
        private System.Windows.Forms.Label lblIdPatente;
        private System.Windows.Forms.TextBox txtIdPatente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.DataGridView dgvPatentes;
        private System.Windows.Forms.Button button32;
    }
}