namespace GUI
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelSeguridad = new System.Windows.Forms.Panel();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.btnPerfiles = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.panelProfesor = new System.Windows.Forms.Panel();
            this.btnFinales = new System.Windows.Forms.Button();
            this.btnRecuperatorios = new System.Windows.Forms.Button();
            this.btnParciales = new System.Windows.Forms.Button();
            this.btnAsistencias = new System.Windows.Forms.Button();
            this.btnProfesor = new System.Windows.Forms.Button();
            this.panelSecretario = new System.Windows.Forms.Panel();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnPlanEstudios = new System.Windows.Forms.Button();
            this.btnSecretario = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            this.Tagg = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelSeguridad.SuspendLayout();
            this.panelProfesor.SuspendLayout();
            this.panelSecretario.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.panelSeguridad);
            this.panelSideMenu.Controls.Add(this.btnSeguridad);
            this.panelSideMenu.Controls.Add(this.panelProfesor);
            this.panelSideMenu.Controls.Add(this.btnProfesor);
            this.panelSideMenu.Controls.Add(this.panelSecretario);
            this.panelSideMenu.Controls.Add(this.btnSecretario);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(249, 785);
            this.panelSideMenu.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 728);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(249, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Tag = "Salir";
            this.btnExit.Text = "Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelSeguridad
            // 
            this.panelSeguridad.BackColor = System.Drawing.Color.SteelBlue;
            this.panelSeguridad.Controls.Add(this.btnBackup);
            this.panelSeguridad.Controls.Add(this.btnBitacora);
            this.panelSeguridad.Controls.Add(this.btnPerfiles);
            this.panelSeguridad.Controls.Add(this.btnUsuarios);
            this.panelSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeguridad.Location = new System.Drawing.Point(0, 561);
            this.panelSeguridad.Name = "panelSeguridad";
            this.panelSeguridad.Size = new System.Drawing.Size(249, 167);
            this.panelSeguridad.TabIndex = 7;
            // 
            // btnBackup
            // 
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.Color.Silver;
            this.btnBackup.Location = new System.Drawing.Point(1, 120);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBackup.Size = new System.Drawing.Size(221, 46);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Tag = "Backup";
            this.btnBackup.Text = "Backups";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.FlatAppearance.BorderSize = 0;
            this.btnBitacora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnBitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacora.ForeColor = System.Drawing.Color.Silver;
            this.btnBitacora.Location = new System.Drawing.Point(1, 80);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBitacora.Size = new System.Drawing.Size(221, 40);
            this.btnBitacora.TabIndex = 2;
            this.btnBitacora.Tag = "Bitacora";
            this.btnBitacora.Text = "Bitacora";
            this.btnBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitacora.UseVisualStyleBackColor = true;
            this.btnBitacora.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnPerfiles
            // 
            this.btnPerfiles.FlatAppearance.BorderSize = 0;
            this.btnPerfiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnPerfiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfiles.ForeColor = System.Drawing.Color.Silver;
            this.btnPerfiles.Location = new System.Drawing.Point(1, 40);
            this.btnPerfiles.Name = "btnPerfiles";
            this.btnPerfiles.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPerfiles.Size = new System.Drawing.Size(221, 40);
            this.btnPerfiles.TabIndex = 1;
            this.btnPerfiles.Tag = "Perfiles";
            this.btnPerfiles.Text = "Perfiles";
            this.btnPerfiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfiles.UseVisualStyleBackColor = true;
            this.btnPerfiles.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.Silver;
            this.btnUsuarios.Location = new System.Drawing.Point(1, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(221, 40);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Tag = "Usuarios";
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeguridad.FlatAppearance.BorderSize = 0;
            this.btnSeguridad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridad.ForeColor = System.Drawing.Color.Black;
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(0, 516);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSeguridad.Size = new System.Drawing.Size(249, 45);
            this.btnSeguridad.TabIndex = 6;
            this.btnSeguridad.Tag = "Seguridad";
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeguridad.UseVisualStyleBackColor = false;
            // 
            // panelProfesor
            // 
            this.panelProfesor.BackColor = System.Drawing.Color.SteelBlue;
            this.panelProfesor.Controls.Add(this.btnFinales);
            this.panelProfesor.Controls.Add(this.btnRecuperatorios);
            this.panelProfesor.Controls.Add(this.btnParciales);
            this.panelProfesor.Controls.Add(this.btnAsistencias);
            this.panelProfesor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfesor.Location = new System.Drawing.Point(0, 351);
            this.panelProfesor.Name = "panelProfesor";
            this.panelProfesor.Size = new System.Drawing.Size(249, 165);
            this.panelProfesor.TabIndex = 4;
            // 
            // btnFinales
            // 
            this.btnFinales.FlatAppearance.BorderSize = 0;
            this.btnFinales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnFinales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnFinales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinales.ForeColor = System.Drawing.Color.Silver;
            this.btnFinales.Location = new System.Drawing.Point(0, 120);
            this.btnFinales.Name = "btnFinales";
            this.btnFinales.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFinales.Size = new System.Drawing.Size(233, 40);
            this.btnFinales.TabIndex = 3;
            this.btnFinales.Tag = "Finales";
            this.btnFinales.Text = "Finales";
            this.btnFinales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinales.UseVisualStyleBackColor = true;
            // 
            // btnRecuperatorios
            // 
            this.btnRecuperatorios.FlatAppearance.BorderSize = 0;
            this.btnRecuperatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnRecuperatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnRecuperatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperatorios.ForeColor = System.Drawing.Color.Silver;
            this.btnRecuperatorios.Location = new System.Drawing.Point(0, 80);
            this.btnRecuperatorios.Name = "btnRecuperatorios";
            this.btnRecuperatorios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRecuperatorios.Size = new System.Drawing.Size(233, 40);
            this.btnRecuperatorios.TabIndex = 2;
            this.btnRecuperatorios.Tag = "Recuperatorios";
            this.btnRecuperatorios.Text = "Recuperatorios";
            this.btnRecuperatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecuperatorios.UseVisualStyleBackColor = true;
            // 
            // btnParciales
            // 
            this.btnParciales.FlatAppearance.BorderSize = 0;
            this.btnParciales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnParciales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnParciales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParciales.ForeColor = System.Drawing.Color.Silver;
            this.btnParciales.Location = new System.Drawing.Point(0, 40);
            this.btnParciales.Name = "btnParciales";
            this.btnParciales.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnParciales.Size = new System.Drawing.Size(233, 40);
            this.btnParciales.TabIndex = 1;
            this.btnParciales.Tag = "Parciales";
            this.btnParciales.Text = "Parciales";
            this.btnParciales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParciales.UseVisualStyleBackColor = true;
            // 
            // btnAsistencias
            // 
            this.btnAsistencias.FlatAppearance.BorderSize = 0;
            this.btnAsistencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAsistencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencias.ForeColor = System.Drawing.Color.Silver;
            this.btnAsistencias.Location = new System.Drawing.Point(0, 0);
            this.btnAsistencias.Name = "btnAsistencias";
            this.btnAsistencias.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAsistencias.Size = new System.Drawing.Size(233, 40);
            this.btnAsistencias.TabIndex = 0;
            this.btnAsistencias.Tag = "Asistencias";
            this.btnAsistencias.Text = "Asistencias";
            this.btnAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencias.UseVisualStyleBackColor = true;
            // 
            // btnProfesor
            // 
            this.btnProfesor.BackColor = System.Drawing.Color.SkyBlue;
            this.btnProfesor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfesor.FlatAppearance.BorderSize = 0;
            this.btnProfesor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnProfesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesor.ForeColor = System.Drawing.Color.Black;
            this.btnProfesor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfesor.Location = new System.Drawing.Point(0, 306);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProfesor.Size = new System.Drawing.Size(249, 45);
            this.btnProfesor.TabIndex = 3;
            this.btnProfesor.Tag = "Profesor";
            this.btnProfesor.Text = "Profesor";
            this.btnProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfesor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfesor.UseVisualStyleBackColor = false;
            // 
            // panelSecretario
            // 
            this.panelSecretario.BackColor = System.Drawing.Color.SteelBlue;
            this.panelSecretario.Controls.Add(this.btnAlumnos);
            this.panelSecretario.Controls.Add(this.btnCursos);
            this.panelSecretario.Controls.Add(this.btnMaterias);
            this.panelSecretario.Controls.Add(this.btnPlanEstudios);
            this.panelSecretario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSecretario.Location = new System.Drawing.Point(0, 141);
            this.panelSecretario.Name = "panelSecretario";
            this.panelSecretario.Size = new System.Drawing.Size(249, 165);
            this.panelSecretario.TabIndex = 2;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.ForeColor = System.Drawing.Color.Silver;
            this.btnAlumnos.Location = new System.Drawing.Point(0, 120);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAlumnos.Size = new System.Drawing.Size(233, 40);
            this.btnAlumnos.TabIndex = 3;
            this.btnAlumnos.Tag = "Alumnos";
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.UseVisualStyleBackColor = true;
            // 
            // btnCursos
            // 
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.ForeColor = System.Drawing.Color.Silver;
            this.btnCursos.Location = new System.Drawing.Point(0, 80);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCursos.Size = new System.Drawing.Size(233, 40);
            this.btnCursos.TabIndex = 2;
            this.btnCursos.Tag = "Cursos";
            this.btnCursos.Text = "Cursos";
            this.btnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursos.UseVisualStyleBackColor = true;
            // 
            // btnMaterias
            // 
            this.btnMaterias.FlatAppearance.BorderSize = 0;
            this.btnMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterias.ForeColor = System.Drawing.Color.Silver;
            this.btnMaterias.Location = new System.Drawing.Point(0, 40);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMaterias.Size = new System.Drawing.Size(233, 40);
            this.btnMaterias.TabIndex = 1;
            this.btnMaterias.Tag = "Materias";
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterias.UseVisualStyleBackColor = true;
            // 
            // btnPlanEstudios
            // 
            this.btnPlanEstudios.FlatAppearance.BorderSize = 0;
            this.btnPlanEstudios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnPlanEstudios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnPlanEstudios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanEstudios.ForeColor = System.Drawing.Color.Silver;
            this.btnPlanEstudios.Location = new System.Drawing.Point(0, 0);
            this.btnPlanEstudios.Name = "btnPlanEstudios";
            this.btnPlanEstudios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPlanEstudios.Size = new System.Drawing.Size(233, 40);
            this.btnPlanEstudios.TabIndex = 0;
            this.btnPlanEstudios.Tag = "Plan de estudio";
            this.btnPlanEstudios.Text = "Plan de estudio";
            this.btnPlanEstudios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanEstudios.UseVisualStyleBackColor = true;
            this.btnPlanEstudios.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnSecretario
            // 
            this.btnSecretario.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSecretario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecretario.FlatAppearance.BorderSize = 0;
            this.btnSecretario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnSecretario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnSecretario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecretario.ForeColor = System.Drawing.Color.Black;
            this.btnSecretario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecretario.Location = new System.Drawing.Point(0, 96);
            this.btnSecretario.Name = "btnSecretario";
            this.btnSecretario.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSecretario.Size = new System.Drawing.Size(249, 45);
            this.btnSecretario.TabIndex = 1;
            this.btnSecretario.Tag = "Secretario";
            this.btnSecretario.Text = "Secretario";
            this.btnSecretario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecretario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSecretario.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(249, 96);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(62, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbIdioma
            // 
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Location = new System.Drawing.Point(1063, 4);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(121, 21);
            this.cbIdioma.TabIndex = 9;
            this.cbIdioma.SelectedValueChanged += new System.EventHandler(this.cbIdioma_SelectedValueChanged);
            // 
            // Tagg
            // 
            this.Tagg.AutoSize = true;
            this.Tagg.Location = new System.Drawing.Point(963, 9);
            this.Tagg.Name = "Tagg";
            this.Tagg.Size = new System.Drawing.Size(96, 13);
            this.Tagg.TabIndex = 10;
            this.Tagg.Text = "Seleccionar idioma";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 785);
            this.Controls.Add(this.Tagg);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.panelSideMenu);
            this.IsMdiContainer = true;
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSeguridad.ResumeLayout(false);
            this.panelProfesor.ResumeLayout(false);
            this.panelSecretario.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelSeguridad;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.Button btnPerfiles;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Panel panelProfesor;
        private System.Windows.Forms.Button btnFinales;
        private System.Windows.Forms.Button btnRecuperatorios;
        private System.Windows.Forms.Button btnParciales;
        private System.Windows.Forms.Button btnAsistencias;
        private System.Windows.Forms.Button btnProfesor;
        private System.Windows.Forms.Panel panelSecretario;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnPlanEstudios;
        private System.Windows.Forms.Button btnSecretario;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbIdioma;
        private System.Windows.Forms.Label Tagg;
    }
}