namespace GUI.Seguridad.frmPatente
{
    partial class frmModificarPatente
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtModDescPatente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModPatente = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.dgvModPatente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModPatente)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Descripcion";
            // 
            // txtModDescPatente
            // 
            this.txtModDescPatente.Location = new System.Drawing.Point(500, 101);
            this.txtModDescPatente.Margin = new System.Windows.Forms.Padding(2);
            this.txtModDescPatente.Name = "txtModDescPatente";
            this.txtModDescPatente.Size = new System.Drawing.Size(259, 20);
            this.txtModDescPatente.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Patentes";
            // 
            // btnModPatente
            // 
            this.btnModPatente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModPatente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModPatente.Location = new System.Drawing.Point(501, 244);
            this.btnModPatente.Name = "btnModPatente";
            this.btnModPatente.Size = new System.Drawing.Size(258, 36);
            this.btnModPatente.TabIndex = 64;
            this.btnModPatente.Text = "Modificar seleccionada";
            this.btnModPatente.UseVisualStyleBackColor = false;
            this.btnModPatente.Click += new System.EventHandler(this.btnModPatente_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.DodgerBlue;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button28.Location = new System.Drawing.Point(45, 286);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(230, 36);
            this.button28.TabIndex = 63;
            this.button28.Text = "Recargar";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.DodgerBlue;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button29.Location = new System.Drawing.Point(45, 356);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(166, 46);
            this.button29.TabIndex = 62;
            this.button29.Text = "Volver";
            this.button29.UseVisualStyleBackColor = false;
            // 
            // dgvModPatente
            // 
            this.dgvModPatente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvModPatente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModPatente.Location = new System.Drawing.Point(45, 75);
            this.dgvModPatente.Name = "dgvModPatente";
            this.dgvModPatente.RowHeadersWidth = 57;
            this.dgvModPatente.Size = new System.Drawing.Size(450, 205);
            this.dgvModPatente.TabIndex = 61;
            // 
            // frmModificarPatente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtModDescPatente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModPatente);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.dgvModPatente);
            this.Name = "frmModificarPatente";
            this.Text = "frmModificarPatente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModPatente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModDescPatente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModPatente;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.DataGridView dgvModPatente;
    }
}