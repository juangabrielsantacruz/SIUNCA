namespace GUI.Seguridad
{
    partial class frmGestionFamilias
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
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvFamiliaSinPatente = new System.Windows.Forms.DataGridView();
            this.dgvFamiliaSinFamilia = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.dgvFamiliaPatente = new System.Windows.Forms.DataGridView();
            this.dgvFamiliaFamilia = new System.Windows.Forms.DataGridView();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.dgvFamilias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliaSinPatente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliaSinFamilia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliaPatente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliaFamilia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 13);
            this.label18.TabIndex = 75;
            this.label18.Text = "Familias existentes";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(298, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 36);
            this.button1.TabIndex = 83;
            this.button1.Text = "Actualizar grilla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Patentes que no tiene familia";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(578, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 29);
            this.button2.TabIndex = 81;
            this.button2.Text = "Agregar patente a familia";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(578, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 32);
            this.button3.TabIndex = 80;
            this.button3.Text = "Agregar familia a familia";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvFamiliaSinPatente
            // 
            this.dgvFamiliaSinPatente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFamiliaSinPatente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamiliaSinPatente.Location = new System.Drawing.Point(578, 363);
            this.dgvFamiliaSinPatente.Name = "dgvFamiliaSinPatente";
            this.dgvFamiliaSinPatente.RowHeadersWidth = 57;
            this.dgvFamiliaSinPatente.Size = new System.Drawing.Size(258, 166);
            this.dgvFamiliaSinPatente.TabIndex = 79;
            // 
            // dgvFamiliaSinFamilia
            // 
            this.dgvFamiliaSinFamilia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFamiliaSinFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamiliaSinFamilia.Location = new System.Drawing.Point(578, 93);
            this.dgvFamiliaSinFamilia.Name = "dgvFamiliaSinFamilia";
            this.dgvFamiliaSinFamilia.RowHeadersWidth = 57;
            this.dgvFamiliaSinFamilia.Size = new System.Drawing.Size(258, 174);
            this.dgvFamiliaSinFamilia.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Familias que no tiene familia";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(294, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 76;
            this.label16.Text = "Patentes familia";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 270);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 68;
            this.label17.Text = "Familias familia";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(298, 538);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(258, 26);
            this.button7.TabIndex = 74;
            this.button7.Text = "Quitar patente a familia";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dgvFamiliaPatente
            // 
            this.dgvFamiliaPatente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFamiliaPatente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamiliaPatente.Location = new System.Drawing.Point(298, 290);
            this.dgvFamiliaPatente.Name = "dgvFamiliaPatente";
            this.dgvFamiliaPatente.RowHeadersWidth = 57;
            this.dgvFamiliaPatente.Size = new System.Drawing.Size(258, 239);
            this.dgvFamiliaPatente.TabIndex = 73;
            // 
            // dgvFamiliaFamilia
            // 
            this.dgvFamiliaFamilia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFamiliaFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamiliaFamilia.Location = new System.Drawing.Point(31, 290);
            this.dgvFamiliaFamilia.Name = "dgvFamiliaFamilia";
            this.dgvFamiliaFamilia.RowHeadersWidth = 57;
            this.dgvFamiliaFamilia.Size = new System.Drawing.Size(258, 239);
            this.dgvFamiliaFamilia.TabIndex = 72;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DodgerBlue;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.Location = new System.Drawing.Point(298, 221);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(230, 36);
            this.button21.TabIndex = 71;
            this.button21.Text = "Descartar cambios";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.DodgerBlue;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Location = new System.Drawing.Point(298, 179);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(230, 36);
            this.button22.TabIndex = 70;
            this.button22.Text = "Guardar cambios";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.DodgerBlue;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Location = new System.Drawing.Point(298, 112);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(249, 36);
            this.button23.TabIndex = 69;
            this.button23.Text = "Cargar familia seleccionada";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.DodgerBlue;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button24.Location = new System.Drawing.Point(31, 538);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(258, 26);
            this.button24.TabIndex = 67;
            this.button24.Text = "Quitar familia a familia";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // dgvFamilias
            // 
            this.dgvFamilias.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilias.Location = new System.Drawing.Point(27, 70);
            this.dgvFamilias.Name = "dgvFamilias";
            this.dgvFamilias.RowHeadersWidth = 57;
            this.dgvFamilias.Size = new System.Drawing.Size(258, 197);
            this.dgvFamilias.TabIndex = 66;
            // 
            // frmGestionFamilias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 605);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvFamiliaSinPatente);
            this.Controls.Add(this.dgvFamiliaSinFamilia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dgvFamiliaPatente);
            this.Controls.Add(this.dgvFamiliaFamilia);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.dgvFamilias);
            this.Name = "frmGestionFamilias";
            this.Text = "frmGestionFamilias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliaSinPatente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliaSinFamilia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliaPatente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliaFamilia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvFamiliaSinPatente;
        private System.Windows.Forms.DataGridView dgvFamiliaSinFamilia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dgvFamiliaPatente;
        private System.Windows.Forms.DataGridView dgvFamiliaFamilia;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.DataGridView dgvFamilias;
    }
}