using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ;
using BIZ.DTOs;
using BLL;
using System.Threading;
using System.Globalization;
using GUI.Idiomas.Profesor.Asistencia;
using Framework.D_2015.Idiomas;
using Framework.D_2015.Cache;


namespace GUI.UserControlProfesor
{
    public partial class UCAsistencias : UserControl
    {
        public UCAsistencias()
        {
            InitializeComponent();
            cargarCboMaterias();
            lblFechaActual.Text = DateTime.Now.ToShortDateString();

            Idioma.cambiarIdioma(Idioma.cacheIdioma, IdiomaPorDefecto);
        }

        private void btnSelMateriaAsistencia_Click(object sender, EventArgs e)
        {
            cargarActaDeasistencias();
        }

        private void btnSelMateriaAsist_Click(object sender, EventArgs e)
        {
            cargarListaAlumnos();
        }

        private void btnGuardarAsist_Click(object sender, EventArgs e)
        {
            guardarRegistroAsistencia();
        }

        /// <summary>
        /// Carga el ComboBox con las materias registradas en la BD correspondientes a cada profesor
        /// usando el iduser del login
        /// </summary>
        void cargarCboMaterias()
        {
            var gestorMateriacc = new GestorMateriaCC();
            var materiascc = gestorMateriacc.TraerListaMateriasCC(CacheUsuario.iduser);

            cboMateriaAsist.DataSource = null;
            cboMateriaAsist.DataSource = materiascc;
            cboMateriaAsist.ValueMember = "IdMateriaCC";
            cboMateriaAsist.DisplayMember = "Nombre";

            cboMateriaRegAsist.DataSource = null;
            cboMateriaRegAsist.DataSource = materiascc;
            cboMateriaRegAsist.ValueMember = "IdMateriaCC";
            cboMateriaRegAsist.DisplayMember = "Nombre";
        }

        /// <summary>
        /// Carga el listado de alumnos del acta de asistencias
        /// en base al combobox de las Materias seleccionado
        /// </summary>
        void cargarActaDeasistencias()
        {
            var gestorAlumno = new GestorAlumno();
            var alumnos = gestorAlumno.traerAlumnos((int)cboMateriaAsist.SelectedValue);

            dgvListadoAlumnos.DataSource = null;
            dgvListadoAlumnos.DataSource = alumnos;

            //oculta columna IdMateriaCC
            dgvListadoAlumnos.Columns[6].Visible = false;
            //Modifica el nombre de las columnas
            dgvListadoAlumnos.Columns[0].HeaderText = "Legajo";
            dgvListadoAlumnos.Columns[3].HeaderText = "Ausentes";
            dgvListadoAlumnos.Columns[4].HeaderText = "Presentes";

            colorFilaActaDeAsistencia();
        }

        /// <summary>
        /// carga el listado de alumnos para registrar las faltas
        /// </summary>
        void cargarListaAlumnos()
        {
            var gestoralumno = new GestorAlumno();
            var alumnos = gestoralumno.traerAlumnos((int)cboMateriaRegAsist.SelectedValue);

            dgvRegistrarAsist.DataSource = null;
            dgvRegistrarAsist.DataSource = alumnos;

            //Modifica el nombre de la columna LegajoAlumno
            dgvRegistrarAsist.Columns[1].HeaderText = "Legajo";

            //Modificacion del orden de las columnas
            dgvRegistrarAsist.Columns["Asistencia"].DisplayIndex = 3;

            //oculta columna Ausentes, Presentes,  Estado, IdMAteriaCC 
            dgvRegistrarAsist.Columns[4].Visible = false;
            dgvRegistrarAsist.Columns[5].Visible = false;
            dgvRegistrarAsist.Columns[6].Visible = false;
            dgvRegistrarAsist.Columns[7].Visible = false;

            colorFilaRegistrarAsistencia();
        }

        void guardarRegistroAsistencia()
        {
            var listadoAsistencia = new List<Asistencia>();

            foreach (DataGridViewRow row in this.dgvRegistrarAsist.Rows)
            {
                var asistencia = new Asistencia();

                asistencia.LegajoAlumno = (int)row.Cells["LegajoAlumno"].Value;
                asistencia.IdMateriaCC = (int)row.Cells["IdMAteriaCC"].Value;

                if (row.Cells["Asistencia"].Value?.ToString() == null)
                {
                    asistencia.Presente = "0";
                    asistencia.Ausente = "0";
                }
                else if (row.Cells["Asistencia"].Value.ToString() == "Presente")
                {
                    asistencia.Presente = "1";
                    asistencia.Ausente = "0";
                }
                else if (row.Cells["Asistencia"].Value.ToString() == "Ausente")
                {
                    asistencia.Presente = "0";
                    asistencia.Ausente = "1";
                }
                

                asistencia.Fecha = DateTime.Today;

                listadoAsistencia.Add(asistencia);
            }

            var gestorAsistencia = new GestorAsistencia();

            gestorAsistencia.guardarAsistencia(listadoAsistencia);

            MessageBox.Show("El registro de asistencias ha sido completado satisfactoriamente");
        }

        /// <summary>
        /// Cambia el color de una fila si las celdas de la columna "Ausente" son mayor igual a 4
        /// </summary>
        void colorFilaActaDeAsistencia()
        {
            for (int i = 0; i < dgvListadoAlumnos.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvListadoAlumnos.Rows[i].Cells["Ausente"].Value.ToString()) >= 4)
                {
                    dgvListadoAlumnos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// Cambia el color de una fila si las celdas de la columna "Ausente" son mayor igual a 4,
        /// tambien desactiva la celda para que no se puedan agregar asistencias
        /// </summary>
        void colorFilaRegistrarAsistencia()
        {
            for (int i = 0; i < dgvRegistrarAsist.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvRegistrarAsist.Rows[i].Cells["Ausente"].Value.ToString()) >= 4)
                {
                    dgvRegistrarAsist.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgvRegistrarAsist.Rows[i].ReadOnly = true;
                }
            }
        }

        void IdiomaPorDefecto()
        {
            btnSelMateriaAsist.Text = Res.btnSelMateriaAsistencia;
            lblFecha.Text = Res.lblFecha;
            gbListaDeAlumnos.Text = Res.gbListaDeAlumnos;
            gbSeleccionDeMateria.Text = Res.gbSeleccionDeMateria;
            btnGuardarAsist.Text = Res.btnGuardarAsist;
            btnCancelarAsist.Text = Res.btnCancelarAsist;
            btnModificarAsist.Text = Res.btnModificarAsist;
            gbListadoDeAlu.Text = Res.gbListadoDeAlu;
            gbSelDeMat.Text = Res.gbSelDeMat;
            btnSelMateriaAsistencia.Text = Res.btnSelMateriaAsistencia;
        }
    }
}
