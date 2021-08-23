using GUI.UserControlProfesor;

namespace GUI
{
    partial class frmProfesor
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfesor));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnFinales = new System.Windows.Forms.Button();
            this.btnRecuperatorios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.slideMenu = new System.Windows.Forms.Panel();
            this.btnParciales = new System.Windows.Forms.Button();
            this.btnAsistencias = new System.Windows.Forms.Button();
            this.panelHeader1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader2 = new System.Windows.Forms.Panel();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelHeader1.SuspendLayout();
            this.panelHeader2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.panelMenu.Controls.Add(this.btnFinales);
            this.panelMenu.Controls.Add(this.btnRecuperatorios);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.slideMenu);
            this.panelMenu.Controls.Add(this.btnParciales);
            this.panelMenu.Controls.Add(this.btnAsistencias);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(203, 566);
            this.panelMenu.TabIndex = 0;
            //this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // btnFinales
            // 
            this.btnFinales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnFinales.FlatAppearance.BorderSize = 0;
            this.btnFinales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinales.Location = new System.Drawing.Point(0, 273);
            this.btnFinales.Name = "btnFinales";
            this.btnFinales.Size = new System.Drawing.Size(188, 44);
            this.btnFinales.TabIndex = 6;
            this.btnFinales.Text = "Finales";
            this.btnFinales.UseVisualStyleBackColor = false;
            this.btnFinales.Click += new System.EventHandler(this.btnFinales_Click);
            // 
            // btnRecuperatorios
            // 
            this.btnRecuperatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnRecuperatorios.FlatAppearance.BorderSize = 0;
            this.btnRecuperatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperatorios.Location = new System.Drawing.Point(0, 223);
            this.btnRecuperatorios.Name = "btnRecuperatorios";
            this.btnRecuperatorios.Size = new System.Drawing.Size(188, 44);
            this.btnRecuperatorios.TabIndex = 5;
            this.btnRecuperatorios.Text = "Recuperatorios";
            this.btnRecuperatorios.UseVisualStyleBackColor = false;
            this.btnRecuperatorios.Click += new System.EventHandler(this.btnRecuperatorios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "SIUNCA";
            // 
            // slideMenu
            // 
            this.slideMenu.BackColor = System.Drawing.Color.Black;
            this.slideMenu.Location = new System.Drawing.Point(188, 123);
            this.slideMenu.Name = "slideMenu";
            this.slideMenu.Size = new System.Drawing.Size(15, 44);
            this.slideMenu.TabIndex = 2;
            // 
            // btnParciales
            // 
            this.btnParciales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnParciales.FlatAppearance.BorderSize = 0;
            this.btnParciales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParciales.Location = new System.Drawing.Point(0, 173);
            this.btnParciales.Name = "btnParciales";
            this.btnParciales.Size = new System.Drawing.Size(188, 44);
            this.btnParciales.TabIndex = 4;
            this.btnParciales.Text = "Parciales";
            this.btnParciales.UseVisualStyleBackColor = false;
            this.btnParciales.Click += new System.EventHandler(this.btnParciales_Click);
            // 
            // btnAsistencias
            // 
            this.btnAsistencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAsistencias.FlatAppearance.BorderSize = 0;
            this.btnAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencias.Location = new System.Drawing.Point(0, 123);
            this.btnAsistencias.Name = "btnAsistencias";
            this.btnAsistencias.Size = new System.Drawing.Size(188, 44);
            this.btnAsistencias.TabIndex = 3;
            this.btnAsistencias.Text = "Asistencias";
            this.btnAsistencias.UseVisualStyleBackColor = false;
            this.btnAsistencias.Click += new System.EventHandler(this.btnAsistencias_Click);
            // 
            // panelHeader1
            // 
            this.panelHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.panelHeader1.Controls.Add(this.btnMinimizar);
            this.panelHeader1.Controls.Add(this.btnMaximizar);
            this.panelHeader1.Controls.Add(this.btnClose);
            this.panelHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader1.Location = new System.Drawing.Point(203, 0);
            this.panelHeader1.Name = "panelHeader1";
            this.panelHeader1.Size = new System.Drawing.Size(848, 30);
            this.panelHeader1.TabIndex = 1;
            this.panelHeader1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader1_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(743, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 26);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(777, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(26, 26);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(809, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelHeader2
            // 
            this.panelHeader2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panelHeader2.Controls.Add(this.lblNombreProfesor);
            this.panelHeader2.Controls.Add(this.lblProfesor);
            this.panelHeader2.Controls.Add(this.btnLogOut);
            this.panelHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader2.Location = new System.Drawing.Point(203, 30);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(848, 61);
            this.panelHeader2.TabIndex = 2;
            this.panelHeader2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader2_MouseMove);
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProfesor.Location = new System.Drawing.Point(119, 19);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(141, 20);
            this.lblNombreProfesor.TabIndex = 7;
            this.lblNombreProfesor.Text = "nombre profesor";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.Location = new System.Drawing.Point(26, 19);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(87, 20);
            this.lblProfesor.TabIndex = 6;
            this.lblProfesor.Text = "Profesor: ";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(751, 15);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(80, 29);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoSize = true;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(203, 91);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(848, 475);
            this.panelContenedor.TabIndex = 3;
            // 
            // frmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 566);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelHeader2);
            this.Controls.Add(this.panelHeader1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelHeader1.ResumeLayout(false);
            this.panelHeader2.ResumeLayout(false);
            this.panelHeader2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHeader1;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelHeader2;
        private System.Windows.Forms.Button btnAsistencias;
        private System.Windows.Forms.Button btnParciales;
        private System.Windows.Forms.Panel panelContenedor;
        private UCAsistencias UCAsistencia;
        private UCParciales UCNotas;
        private System.Windows.Forms.Panel slideMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.Button btnRecuperatorios;
        private System.Windows.Forms.Button btnFinales;
    }
}

