namespace GUI.Seguridad
{
    partial class UCBackups
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbBD = new System.Windows.Forms.ComboBox();
            this.btnBasesDeDatos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbSQL = new System.Windows.Forms.RadioButton();
            this.rbWindows = new System.Windows.Forms.RadioButton();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnProbar = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 638);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(846, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backups";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.btnProbar);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.btnRestaurar);
            this.groupBox1.Location = new System.Drawing.Point(15, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 593);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion de backups";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Black;
            this.txtStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.White;
            this.txtStatus.Location = new System.Drawing.Point(19, 262);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatus.Size = new System.Drawing.Size(783, 170);
            this.txtStatus.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.cbBD);
            this.panel4.Controls.Add(this.btnBasesDeDatos);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtContrasenia);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtUser);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.rbSQL);
            this.panel4.Controls.Add(this.rbWindows);
            this.panel4.Controls.Add(this.txtServidor);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(19, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(783, 200);
            this.panel4.TabIndex = 45;
            // 
            // cbBD
            // 
            this.cbBD.FormattingEnabled = true;
            this.cbBD.Location = new System.Drawing.Point(521, 10);
            this.cbBD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBD.Name = "cbBD";
            this.cbBD.Size = new System.Drawing.Size(210, 28);
            this.cbBD.TabIndex = 64;
            // 
            // btnBasesDeDatos
            // 
            this.btnBasesDeDatos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBasesDeDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBasesDeDatos.Location = new System.Drawing.Point(521, 54);
            this.btnBasesDeDatos.Name = "btnBasesDeDatos";
            this.btnBasesDeDatos.Size = new System.Drawing.Size(172, 57);
            this.btnBasesDeDatos.TabIndex = 28;
            this.btnBasesDeDatos.Text = "Buscar bases de datos";
            this.btnBasesDeDatos.UseVisualStyleBackColor = false;
            this.btnBasesDeDatos.Click += new System.EventHandler(this.BtnBasesDeDatos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Base de datos:";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(143, 154);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(208, 26);
            this.txtContrasenia.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(143, 124);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(208, 26);
            this.txtUser.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Usuario:";
            // 
            // rbSQL
            // 
            this.rbSQL.AutoSize = true;
            this.rbSQL.Location = new System.Drawing.Point(70, 85);
            this.rbSQL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSQL.Name = "rbSQL";
            this.rbSQL.Size = new System.Drawing.Size(177, 24);
            this.rbSQL.TabIndex = 57;
            this.rbSQL.TabStop = true;
            this.rbSQL.Text = "Autenticacion SQL";
            this.rbSQL.UseVisualStyleBackColor = true;
            // 
            // rbWindows
            // 
            this.rbWindows.AutoSize = true;
            this.rbWindows.Location = new System.Drawing.Point(70, 54);
            this.rbWindows.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbWindows.Name = "rbWindows";
            this.rbWindows.Size = new System.Drawing.Size(238, 24);
            this.rbWindows.TabIndex = 56;
            this.rbWindows.TabStop = true;
            this.rbWindows.Text = "Autenticacion de Windows";
            this.rbWindows.UseVisualStyleBackColor = true;
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(143, 12);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(208, 26);
            this.txtServidor.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Servidor:";
            // 
            // btnProbar
            // 
            this.btnProbar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProbar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProbar.Location = new System.Drawing.Point(19, 451);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(170, 46);
            this.btnProbar.TabIndex = 27;
            this.btnProbar.Text = "Probar conexion";
            this.btnProbar.UseVisualStyleBackColor = false;
            this.btnProbar.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackup.Location = new System.Drawing.Point(615, 454);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(186, 57);
            this.btnBackup.TabIndex = 26;
            this.btnBackup.Text = "Realizar backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestaurar.Location = new System.Drawing.Point(615, 518);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(186, 55);
            this.btnRestaurar.TabIndex = 22;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // UCBackups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UCBackups";
            this.Size = new System.Drawing.Size(854, 638);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBasesDeDatos;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSQL;
        private System.Windows.Forms.RadioButton rbWindows;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.ComboBox cbBD;
        internal System.Windows.Forms.TextBox txtStatus;
    }
}
