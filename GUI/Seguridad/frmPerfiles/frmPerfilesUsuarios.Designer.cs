namespace GUI.Seguridad
{
    partial class frmPerfilesUsuarios
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
            this.button38 = new System.Windows.Forms.Button();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            this.button20 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvUsuarioSinPatentes = new System.Windows.Forms.DataGridView();
            this.dgvUsuarioSinFamilias = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvUsuarioPatenteFamilia = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.dgvPatentesUsuario = new System.Windows.Forms.DataGridView();
            this.dgvFamiliasUsuario = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.dgvUsuariosGestion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioSinPatentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioSinFamilias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioPatenteFamilia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatentesUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliasUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosGestion)).BeginInit();
            this.SuspendLayout();
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(414, 22);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(135, 23);
            this.button38.TabIndex = 91;
            this.button38.Tag = "Tagg";
            this.button38.Text = "button38";
            this.button38.UseVisualStyleBackColor = true;
            // 
            // cbIdioma
            // 
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Location = new System.Drawing.Point(151, 25);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(121, 21);
            this.cbIdioma.TabIndex = 90;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(273, 22);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(135, 23);
            this.button20.TabIndex = 89;
            this.button20.Tag = "Tagg";
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(563, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 13);
            this.label12.TabIndex = 87;
            this.label12.Text = "Patentes que no tiene usuario";
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.DodgerBlue;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Location = new System.Drawing.Point(567, 525);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(258, 29);
            this.button18.TabIndex = 86;
            this.button18.Text = "Agregar patente a usuario";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(565, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(258, 32);
            this.button4.TabIndex = 85;
            this.button4.Text = "Agregar familia a usuario";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvUsuarioSinPatentes
            // 
            this.dgvUsuarioSinPatentes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsuarioSinPatentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioSinPatentes.Location = new System.Drawing.Point(567, 353);
            this.dgvUsuarioSinPatentes.Name = "dgvUsuarioSinPatentes";
            this.dgvUsuarioSinPatentes.RowHeadersWidth = 57;
            this.dgvUsuarioSinPatentes.Size = new System.Drawing.Size(258, 166);
            this.dgvUsuarioSinPatentes.TabIndex = 84;
            // 
            // dgvUsuarioSinFamilias
            // 
            this.dgvUsuarioSinFamilias.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsuarioSinFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioSinFamilias.Location = new System.Drawing.Point(565, 60);
            this.dgvUsuarioSinFamilias.Name = "dgvUsuarioSinFamilias";
            this.dgvUsuarioSinFamilias.RowHeadersWidth = 57;
            this.dgvUsuarioSinFamilias.Size = new System.Drawing.Size(258, 164);
            this.dgvUsuarioSinFamilias.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(561, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "Familias que no tiene usuario";
            // 
            // dgvUsuarioPatenteFamilia
            // 
            this.dgvUsuarioPatenteFamilia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsuarioPatenteFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioPatenteFamilia.Location = new System.Drawing.Point(285, 283);
            this.dgvUsuarioPatenteFamilia.Name = "dgvUsuarioPatenteFamilia";
            this.dgvUsuarioPatenteFamilia.RowHeadersWidth = 57;
            this.dgvUsuarioPatenteFamilia.Size = new System.Drawing.Size(265, 271);
            this.dgvUsuarioPatenteFamilia.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "Patentes usuario";
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.DodgerBlue;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Location = new System.Drawing.Point(14, 526);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(258, 28);
            this.button17.TabIndex = 78;
            this.button17.Text = " Quitar patente a usuario";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // dgvPatentesUsuario
            // 
            this.dgvPatentesUsuario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPatentesUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatentesUsuario.Location = new System.Drawing.Point(14, 436);
            this.dgvPatentesUsuario.Name = "dgvPatentesUsuario";
            this.dgvPatentesUsuario.RowHeadersWidth = 57;
            this.dgvPatentesUsuario.Size = new System.Drawing.Size(258, 85);
            this.dgvPatentesUsuario.TabIndex = 76;
            // 
            // dgvFamiliasUsuario
            // 
            this.dgvFamiliasUsuario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFamiliasUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamiliasUsuario.Location = new System.Drawing.Point(14, 283);
            this.dgvFamiliasUsuario.Name = "dgvFamiliasUsuario";
            this.dgvFamiliasUsuario.RowHeadersWidth = 57;
            this.dgvFamiliasUsuario.Size = new System.Drawing.Size(258, 85);
            this.dgvFamiliasUsuario.TabIndex = 75;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(14, 374);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(258, 26);
            this.button5.TabIndex = 70;
            this.button5.Text = "Quitar familia a usuario";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Usuarios";
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.DodgerBlue;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Location = new System.Drawing.Point(285, 60);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(249, 36);
            this.button19.TabIndex = 88;
            this.button19.Text = "Actualizar grilla";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Patentes en Familias del Usuario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Familias usuario";
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.DodgerBlue;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Location = new System.Drawing.Point(285, 211);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(230, 36);
            this.button15.TabIndex = 74;
            this.button15.Text = "Descartar cambios";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(285, 169);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(230, 36);
            this.button6.TabIndex = 73;
            this.button6.Text = "Guardar cambios";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.DodgerBlue;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Location = new System.Drawing.Point(285, 102);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(249, 36);
            this.button14.TabIndex = 72;
            this.button14.Text = "Cargar usuario seleccionado";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // dgvUsuariosGestion
            // 
            this.dgvUsuariosGestion.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsuariosGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosGestion.Location = new System.Drawing.Point(14, 60);
            this.dgvUsuariosGestion.Name = "dgvUsuariosGestion";
            this.dgvUsuariosGestion.RowHeadersWidth = 57;
            this.dgvUsuariosGestion.Size = new System.Drawing.Size(258, 187);
            this.dgvUsuariosGestion.TabIndex = 69;
            // 
            // frmPerfilesUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 575);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvUsuarioSinPatentes);
            this.Controls.Add(this.dgvUsuarioSinFamilias);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvUsuarioPatenteFamilia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.dgvPatentesUsuario);
            this.Controls.Add(this.dgvFamiliasUsuario);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.dgvUsuariosGestion);
            this.Name = "frmPerfilesUsuarios";
            this.Text = "frmPerfilesUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioSinPatentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioSinFamilias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioPatenteFamilia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatentesUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliasUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosGestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.ComboBox cbIdioma;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvUsuarioSinPatentes;
        private System.Windows.Forms.DataGridView dgvUsuarioSinFamilias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvUsuarioPatenteFamilia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.DataGridView dgvPatentesUsuario;
        private System.Windows.Forms.DataGridView dgvFamiliasUsuario;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.DataGridView dgvUsuariosGestion;
    }
}