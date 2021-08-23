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
using BLL;
using BIZ.DTOs;

namespace GUI.UserControlSecretarioAcademico
{
    public partial class UCCursos : UserControl
    {
        List<DTOCurso> ListCurso = new List<DTOCurso>();
        DTOCurso unDTOCurso = new DTOCurso();
        Carrera UnaCarrera = new Carrera();
        public UCCursos()
        {
            InitializeComponent();
            CargarPlanes();
            CargarCarreras();
            CargarMaterias2();

        }

        private void CargarPlanes()
        {
            GestorPlanDeEstudio unGPE = new GestorPlanDeEstudio();
            ComboPEcorr.DataSource = null;
            ComboPEcorr.DataSource = unGPE.TraerListaPlanes();
            ComboPEcorr.DisplayMember = "Nombre";
            
        }
        private void CargarCarreras()
        {
            GestorCarrera unGC = new GestorCarrera();
            ComboCarrera.DataSource = null;
            ComboCarrera.DataSource = unGC.TraerListaCarreras();
            ComboCarrera.DisplayMember = "Nombre";
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                DTOCurso unDetCurso = new DTOCurso();
                DTODetallesCorrPlan UnaMateria;
                Carrera UnaCarrera;

                UnaMateria = (DTODetallesCorrPlan)ComboMaterias1.SelectedItem;
                UnaCarrera = (Carrera)ComboCarrera.SelectedItem;


                unDetCurso.IdMateriaCC = UnaMateria.IdMateriaCC;
                unDetCurso.IdCarrera = UnaCarrera.IdCarrera;
                unDetCurso.NombreMateria = UnaMateria.Nombre;
                unDetCurso.NombreCarrera = UnaCarrera.Nombre;
                //unDetCurso.Nombre = ((DTODetallesCorrPlan)ComboMaterias1.SelectedItem).Nombre;
                //unDetCurso.CuposMax = int.Parse(ComboCuposMax.Text);
                unDetCurso.CuposMax = int.Parse(txtCuposMax.Text);
                unDetCurso.FechaInicio = dateTimePicker1.Value;
                unDetCurso.FechaFin = dateTimePicker2.Value;
                unDetCurso.Turno = comboTurno.Text;

                unDetCurso.nombreCurso = UnaMateria.Nombre + " "+ unDetCurso.Turno;
                //unDetAlumnoMatCC.Turno = ComboTurno.Text;

                ExisteEnLista(ComboMaterias1.Text, dgCursoMat);

                //traigo al dgAprobadas y verifico que la materia que quiero agregar no este "Aprobada"
                //ConsultarAprobadas();
                //ExisteEnListaAprobados(ComboMaterias1.Text, dgAprobadas);

                //Valido que esten las correlativas aprobadas                
                //ExisteEnDgAprobadas();
                if (dateTimePicker1.Value.Date == dateTimePicker2.Value.Date)
                {
                    MessageBox.Show("Fecha de inicio no puede ser igual a fecha de finalizacion.");
                    throw new Exception();

                }
                else if (dateTimePicker1.Value.Date <= DateTime.Now.Date)
                {
                    MessageBox.Show("Fecha de inicio de cursada no puede ser menor o igual a hoy.");
                    throw new Exception();
                }
                else 
                {
                    if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
                    {
                        MessageBox.Show("Fecha de inicio no puede ser mayor a fecha de finalizacion.");
                        throw new Exception();
                    }
                }
                
                ListCurso.Add(unDetCurso);
                dgCursoMat.DataSource = null;
                dgCursoMat.DataSource = ListCurso;

                dgCursoMat.Columns.Remove("IdCurso");
                dgCursoMat.Columns.Remove("IdMateriaCC");
                dgCursoMat.Columns.Remove("IdCarrera");
                dgCursoMat.Columns.Remove("CreatedOn");
                dgCursoMat.Columns.Remove("CreatedBy");
                dgCursoMat.Columns.Remove("ChangedBy");
                dgCursoMat.Columns.Remove("ChangedOn");

                dgCursoMat.Columns["NombreMateria"].HeaderText = "Materia";
                dgCursoMat.Columns["NombreCarrera"].HeaderText = "Carrera";
                dgCursoMat.Columns["CuposMax"].HeaderText = "Cupos Max";
                dgCursoMat.Columns["FechaInicio"].HeaderText = "Fecha inicio";
                dgCursoMat.Columns["FechaFin"].HeaderText = "Fecha fin";
                dgCursoMat.Columns["NombreCurso"].HeaderText = "Nombre curso";


                dgCursoMat.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                dgCursoMat.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar");
            }
         
        }
        public Boolean ExisteEnLista(String Rol, DataGridView Dg)
        {
            Boolean existe = false;
            foreach (DataGridViewRow row in Dg.Rows)
            {
                String verificar = Convert.ToString(row.Cells["NombreMateria"].Value);
                if (Rol == verificar)
                {
                    //labelMensaje.Visible = true;
                    //labelMensaje.Text = "Ya existe";
                    existe = true;
                    MessageBox.Show("Atención, ya se encuentra esa materia en el listado.","Aviso",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //throw new Exception("Numero de materia repetido");
                    break;
                }
                else
                {
                    //labelMensaje.Visible = true;
                    existe = false;
                    //labelMensaje.Text = "Agregado";
                }
            }
            return existe;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
           // unDTOCurso.nombreCurso = comboNombreCurso.Text;

            try
            {
                GestorCurso unGCurso = new GestorCurso();
                unGCurso.CrearCurso(unDTOCurso, ListCurso);
                MessageBox.Show("Curso creado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar curso.");
            }
        }


        private void ComboPEcorr_DropDownClosed(object sender, EventArgs e)
        {
            CargarMaterias2();
        }

        private void CargarMaterias2()
        {
            DTODetallesCorrPlan unPE2;
            GestorPEDetalle unGDetPE = new GestorPEDetalle();
            unPE2 = (DTODetallesCorrPlan)ComboPEcorr.SelectedItem;
            ComboMaterias1.DataSource = null;
            ComboMaterias1.DataSource = unGDetPE.TraerListaPEDetalles(unPE2);

            ComboMaterias1.DisplayMember = "Nombre";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ListCurso.Remove((DTOCurso)dgCursoMat.CurrentRow.DataBoundItem);
            dgCursoMat.DataSource = null;
            dgCursoMat.DataSource = ListCurso;

            dgCursoMat.Columns.Remove("IdCurso");
            //dgCursoMat.Columns.Remove("IdMateriaCC");
            //dgCursoMat.Columns.Remove("IdAlumno_Materia");
            dgCursoMat.Columns.Remove("CreatedOn");
            dgCursoMat.Columns.Remove("CreatedBy");
            dgCursoMat.Columns.Remove("ChangedBy");
            dgCursoMat.Columns.Remove("ChangedOn");

            //dgCursoMat.Columns["Nombre"].HeaderText = "Materia seleccionada";
            //dgCursoMat.Columns["NombreMateria2"].HeaderText = "Correlativa asignada";
        }

        private void BtnConsultarCorrelativas_Click(object sender, EventArgs e)
        {
            //traigo los cursos de una materia
            CargarCursosDeMateria();
        }

        private void CargarCursosDeMateria()
        {
            GestorCurso UnGCurso = new GestorCurso();
            DTODetallesCorrPlan unaMateria = new DTODetallesCorrPlan();


            unaMateria = (DTODetallesCorrPlan)ComboMaterias1.SelectedItem;

            dgConsultaCursos.DataSource = null;
            dgConsultaCursos.DataSource = UnGCurso.TraerFechasInicioCursos(unaMateria);

            dgConsultaCursos.Columns.Remove("NombreCurso");
            dgConsultaCursos.Columns.Remove("IdMateriaCC");
            dgConsultaCursos.Columns.Remove("IdCarrera");

            dgConsultaCursos.Columns.Remove("ChangedBy");
            dgConsultaCursos.Columns.Remove("ChangedOn");
            dgConsultaCursos.Columns.Remove("CreatedOn");
            dgConsultaCursos.Columns.Remove("CreatedBy");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
