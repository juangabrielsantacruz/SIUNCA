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
    public partial class UCAlumnos : UserControl
    {
        public UCAlumnos()
        {
            InitializeComponent();
           // CargarPlanes();
        }

        List<Alumno_MateriaCC> ListAlumnoMateriaCC = new List<Alumno_MateriaCC>();
        Alumno unAlumno = new Alumno();
        GestorAlumno unGestorAlumno = new GestorAlumno();

        int resta = 0;
        int suma = 0;


        private void UCAlumnos_Load(object sender, EventArgs e)
        {
            comboSexo.Text = "Seleccione";
            dgvModAlumno.DataSource = null;
            dgvModAlumno.DataSource = unGestorAlumno.traerAlumnos();
            RemoverColumnas();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
             unAlumno.LegajoAlumno = int.Parse(txtLegajo.Text);

            try
            {
                if (dgAlumMat.RowCount > 0)
                {
                    GestorAlumno unGAlumno = new GestorAlumno();
                    unGAlumno.AsignarAlumnoAMaterias(unAlumno, ListAlumnoMateriaCC);
                    MessageBox.Show("Asignacion de alumno a materias guardada.");
                    dgAlumMat.DataSource = null;
                }
                else
                {
                    MessageBox.Show("No hay materias seleccionadas");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar asginacion a materias.");
            }
        }
        private void CargarPlanes()
        {
            GestorPlanDeEstudio unGPE = new GestorPlanDeEstudio();
            ComboPEcorr.DataSource = null;
            ComboPEcorr.DataSource = unGPE.TraerListaPlanes2();
            ComboPEcorr.DisplayMember = "Nombre";
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                CargarNombreAlumno();
                //CargarApellidoAlumno();

                CargarCarreraDelAlumno();
                CargarMateriasDeCarrera();
                CargarPlanAlumno();

            }
        }

        private void CargarNombreAlumno()
        {
            GestorAlumno unGAlumno = new GestorAlumno();
            Alumno UnAlumno = new Alumno();
            UnAlumno.LegajoAlumno = int.Parse(txtLegajo.Text);

            //txtNombre.Text = ((Alumno)unGAlumno.TraerAlumno(UnAlumno)).NombreAlumno;           

            ComboNombre.DataSource = null;
            ComboNombre.DataSource = unGAlumno.TraerAlumno(UnAlumno);
            ComboNombre.DisplayMember = "Nombre";

            ComboApellido.DataSource = null;
            ComboApellido.DataSource = unGAlumno.TraerAlumno(UnAlumno);
            ComboApellido.DisplayMember = "Apellido";
        }
        private void CargarCarreraDelAlumno()
        {
            Alumno UnAlumno = new Alumno();
            GestorCarrera unGC = new GestorCarrera();

            UnAlumno.LegajoAlumno = int.Parse(txtLegajo.Text);

            ComboCarrera.DataSource = null;
            ComboCarrera.DataSource = unGC.TraerCarrera(UnAlumno);
            ComboCarrera.DisplayMember = "Nombre";

        }
        private void CargarPlanAlumno()
        {
            Alumno unAlumno = new Alumno();
            Carrera unaCarrera = new Carrera();
            GestorPlanDeEstudio unGPE = new GestorPlanDeEstudio();

            unAlumno.LegajoAlumno = int.Parse(txtLegajo.Text);
            unaCarrera.IdCarrera = ((Carrera)ComboCarrera.SelectedItem).IdCarrera;

            ComboPEcorr.DataSource = null;
            ComboPEcorr.DataSource = unGPE.TraerListaPlanes(unAlumno, unaCarrera);
            ComboPEcorr.DisplayMember = "Nombre";
        }

        private void CargarMateriasDeCarrera()
        {

            GestorMateriaCC UnGMCC = new GestorMateriaCC();
            Carrera UnaCarrera = new Carrera();


            UnaCarrera.Nombre = ((Carrera)ComboCarrera.SelectedItem).Nombre;

            ComboMaterias1.DataSource = null;
            ComboMaterias1.DataSource = UnGMCC.TraerListaMateriasCC(UnaCarrera);
            ComboMaterias1.DisplayMember = "Nombre";

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno_MateriaCC unDetAlumnoMatCC = new Alumno_MateriaCC();
                DTODetallesCorrPlan UnaMateria;
                Carrera UnaCarrera;

                UnaMateria = (DTODetallesCorrPlan)ComboMaterias1.SelectedItem;
                UnaCarrera = (Carrera)ComboCarrera.SelectedItem;


                unDetAlumnoMatCC.IdMateriaCC = UnaMateria.IdMateriaCC;
                unDetAlumnoMatCC.Nombre = ((DTODetallesCorrPlan)ComboMaterias1.SelectedItem).Nombre;
                unDetAlumnoMatCC.NombreCarrera = ComboCarrera.Text;
                unDetAlumnoMatCC.ApellidoAlumno = ComboApellido.Text;
                unDetAlumnoMatCC.NombreAlumno = ComboNombre.Text;
                unDetAlumnoMatCC.Estado = "Cursando";
                unDetAlumnoMatCC.LegajoAlumno = int.Parse(txtLegajo.Text);
                //unDetAlumnoMatCC.Turno = ComboTurno.Text;

                ExisteEnLista(ComboMaterias1.Text, dgAlumMat);

                //traigo al dgAprobadas y verifico que la materia que quiero agregar no este "Aprobada"
                ConsultarAprobadas();
                ExisteEnListaAprobados(ComboMaterias1.Text, dgAprobadas);

                //Valido que esten las correlativas aprobadas                
                ExisteEnDgAprobadas();


                ListAlumnoMateriaCC.Add(unDetAlumnoMatCC);


                Alumno UnAlumno = new Alumno();
                GestorCarrera unGC = new GestorCarrera();

                UnAlumno.LegajoAlumno = int.Parse(txtLegajo.Text);

                ComboCarrera.DataSource = null;
                ComboCarrera.DataSource = unGC.TraerCarrera(UnAlumno);
                ComboCarrera.DisplayMember = "Nombre";

                dgAlumMat.DataSource = null;
                dgAlumMat.DataSource = ListAlumnoMateriaCC;

                //dgAlumMat.Columns.Remove("IdDetallesMateriaCC");
                dgAlumMat.Columns.Remove("IdMateriaCC");
                dgAlumMat.Columns.Remove("IdAlumno_Materia");
                dgAlumMat.Columns.Remove("CreatedOn");
                dgAlumMat.Columns.Remove("CreatedBy");
                dgAlumMat.Columns.Remove("ChangedBy");
                dgAlumMat.Columns.Remove("ChangedOn");

                dgAlumMat.Columns["LegajoAlumno"].HeaderText = "Legajo";
                dgAlumMat.Columns["NombreAlumno"].HeaderText = "Nombre Alumno";
                dgAlumMat.Columns["ApellidoAlumno"].HeaderText = "Apellido Alumno";
                dgAlumMat.Columns["NombreCarrera"].HeaderText = "Carrera";
                dgAlumMat.Columns["Nombre"].HeaderText = "Materia asignada";



                dgAlumMat.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                dgAlumMat.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar");                
            }
           
            //resto 1
            //int resultado;
            //resta = int.Parse(ComboCupos.Text) - 1;
            //ComboCupos.Text = resta.ToString();          
           
            
        }

        public void ExisteEnDgAprobadas()
        {
            if (dgAprobadas.RowCount > 0)
            {
                // Primero averigua si el registro existe:
                bool existe = false;
                int i;
                for ( i = 0; i < dgAprobadas.RowCount; i++)
                {
                    for (int j = 0; j < dgCorrelativas.RowCount; j++)
                    {
                        if (dgAprobadas.Rows[i].Cells["Nombre"].Value.ToString() == dgCorrelativas.Rows[j].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("correlativa " + dgAprobadas.Rows[i].Cells["Nombre"].Value.ToString() + " esta en dgAprobada");
                            existe = true;
                            break; // debes salirte del ciclo si encuentras el registro, no es necesario seguir dentro
                        }
                    }                    
                    existe = false;                  
                   
                }
               
                // Luego, ya fuera del ciclo, solo si no existe, realizas la insercion:
                if (existe == false)
                {

                    if (dgCorrelativas.RowCount == 0)
                    {
                        MessageBox.Show("esta materia no tiene correlativas");

                    }
                    else
                    {                        
                        MessageBox.Show("Una de las materias correlativas no esta aprobada");
                        throw new Exception();
                        //MessageBox.Show("correlativa " + dgAprobadas.Rows[i].Cells["Nombre"].Value.ToString() + " no esta en dgAprobada");
                    }                                     
                    //dgAprobadas.Rows.Add(id_prod, nombre, cant);
                }
            }
        }

        //FUNCION Q VALIDA REPETIDOS
        public Boolean ExisteEnLista(String Rol, DataGridView Dg)
        {
            Boolean existe = false;
            foreach (DataGridViewRow row in Dg.Rows)
            {
                String verificar = Convert.ToString(row.Cells["Nombre"].Value);
                if (Rol == verificar)
                {
                    //labelMensaje.Text = "Ya existe";
                    existe = true;
                    MessageBox.Show("Materia repetida");
                    throw new Exception("Materia repetida");
                    break;
                }
                else
                {
                    existe = false;
                    //labelMensaje.Text = "Agregado";
                }
            }
            return existe;
        }
        //FUNCION Q VALIDA REPETIDOS
        public Boolean ExisteEnListaAprobados(String Rol, DataGridView Dg)
        {
            Boolean existe = false;
            foreach (DataGridViewRow row in Dg.Rows)
            {
                String verificar = Convert.ToString(row.Cells["Nombre"].Value);
                if (Rol == verificar)
                {
                    //labelMensaje.Text = "Ya existe";
                    existe = true;
                    MessageBox.Show("Materia que intenta agregar ya esta aprobada o esta siendo cursada");
                    throw new Exception("Materia repetida");
                    break;
                }
                else
                {
                    existe = false;
                    //labelMensaje.Text = "Agregado";
                }
            }
            return existe;
        }

        //FUNCION Q VALIDA REPETIDOS
       
        


        private void Button8_Click(object sender, EventArgs e)
        {
            CargarCorrelativas();

        }
        private void CargarCorrelativas()
        {
            DTODetallesCorrPlan unDTOMPCP;
            GestorDetMatPlanCorrPlan unGDTOMPCP = new GestorDetMatPlanCorrPlan();
            unDTOMPCP = (DTODetallesCorrPlan)ComboMaterias1.SelectedItem;

            //select nombre from materias ij dpe ij ddmpcp where m.idmateria = @dto.idmateria  (TRAIGO DTO)
            unDTOMPCP.IdPlanDetalles2 = ((DTODetallesCorrPlan)ComboMaterias1.SelectedItem).IdPlanDetalles;
            unDTOMPCP.NombreMateria2 = ((DTODetallesCorrPlan)ComboMaterias1.SelectedItem).Nombre;
            unDTOMPCP.IdPlanDeEstudio = ((DTODetallesCorrPlan)ComboPEcorr.SelectedItem).IdPlanDeEstudio;
            dgCorrelativas.DataSource = null;
            dgCorrelativas.DataSource = unGDTOMPCP.TraerListaCorrelativas(unDTOMPCP);


            dgCorrelativas.Columns.Remove("IdDetallesDetMatPlanCorrPlan");
            dgCorrelativas.Columns.Remove("IdPlanDetalles");
            dgCorrelativas.Columns.Remove("IdPlanDetalles2");
            dgCorrelativas.Columns.Remove("NumeroMateria");
            dgCorrelativas.Columns.Remove("NumeroMateria2");
            dgCorrelativas.Columns.Remove("Año");
            dgCorrelativas.Columns.Remove("Obligatoriedad");
            dgCorrelativas.Columns.Remove("CargaHoraria");
            dgCorrelativas.Columns.Remove("IdMateriaCC");
            dgCorrelativas.Columns.Remove("NombreMateria2");
            dgCorrelativas.Columns.Remove("IdPlanDeEstudio");

            dgCorrelativas.Columns.Remove("ChangedBy");
            dgCorrelativas.Columns.Remove("ChangedOn");
            dgCorrelativas.Columns.Remove("CreatedOn");
            dgCorrelativas.Columns.Remove("CreatedBy");

            dgCorrelativas.Columns[0].HeaderText = "Correlativas";
            dgCorrelativas.Columns[1].HeaderText = "Plan";

            //dgConsultaCorrelativas.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            //dgConsultaCorrelativas.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

        }

        private void BtnConsultarCorrelativas_Click(object sender, EventArgs e)
        {
            ConsultarAprobadas();
        }
        private void ConsultarAprobadas()
        {
            Alumno unAlumno = new Alumno();
            GestorDetallesAlumnoMateria unGDC = new GestorDetallesAlumnoMateria();
            unAlumno.LegajoAlumno = int.Parse(txtLegajo.Text);
            dgAprobadas.DataSource = null;
            dgAprobadas.DataSource = unGDC.TraerMateriasAprobadas(unAlumno);

            dgAprobadas.Columns.Remove("IdMateriaCC");
            dgAprobadas.Columns.Remove("LegajoAlumno");
            dgAprobadas.Columns.Remove("IdAlumno_Materia");
            dgAprobadas.Columns.Remove("NombreAlumno");
            dgAprobadas.Columns.Remove("ApellidoAlumno");
            dgAprobadas.Columns.Remove("NombreCarrera");
            dgAprobadas.Columns.Remove("ChangedBy");
            dgAprobadas.Columns.Remove("ChangedOn");
            dgAprobadas.Columns.Remove("CreatedOn");
            dgAprobadas.Columns.Remove("CreatedBy");

        }

        private void ComboFechasInicioCurso_Click(object sender, EventArgs e)
        {
            try
            {
                TraerFechasInicioCursos();
                TraerCuposMaxCurso();
            }
            
            catch (Exception ex)
            {                
                MessageBox.Show("No hay cursos", ex.ToString());

            }         
   
        }

        private void TraerFechasInicioCursos()
        {
            GestorCurso UnGCurso = new GestorCurso();
            DTODetallesCorrPlan unaMateria = new DTODetallesCorrPlan();


            unaMateria.IdMateriaCC = ((DTODetallesCorrPlan)ComboMaterias1.SelectedItem).IdMateriaCC;

            ComboFechasInicioCurso.DataSource = null;
            ComboFechasInicioCurso.DataSource = UnGCurso.TraerFechasInicioCursos(unaMateria);
            ComboFechasInicioCurso.DisplayMember = "FechaInicio";
            
            //ComboFechasInicioCurso.DisplayMember = "FechaInicio";
            //dateTimePicker1.Show = UnCurso.TraerFechasInicioCursos(unaMateria);
        }

        private void TraerCuposMaxCurso()
        {
            GestorCurso UnGCurso = new GestorCurso();
            Curso uncurso = new Curso();

           
                uncurso.IdCurso = ((Curso)ComboFechasInicioCurso.SelectedItem).IdCurso;

                ComboCuposMax.DataSource = null;
                ComboCuposMax.DataSource = UnGCurso.TraerCuposMaxCurso(uncurso);
                ComboCuposMax.DisplayMember = "CuposMax";
                ComboCupos.DataSource = null;
                ComboCupos.DataSource = UnGCurso.TraerCuposMaxCurso(uncurso);
                ComboCupos.DisplayMember = "CuposMax";
               
                //resta = ((Curso)ComboCuposMax.SelectedValue).CuposMax - 1;          
            

        }

        private void ComboCupos_Click(object sender, EventArgs e)
        {
            //Restar 1 a cuposmax

        }

        private void 
            _SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void ComboPEcorr_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMaterias2();
        }
        private void CargarMaterias2()
        {
            DTODetallesCorrPlan unPE2;
            GestorPEDetalle unGDetPE2 = new GestorPEDetalle();
            unPE2 = (DTODetallesCorrPlan)ComboPEcorr.SelectedItem;
            ComboMaterias1.DataSource = null;
            ComboMaterias1.DataSource = unGDetPE2.TraerListaPEDetalles(unPE2);

            ComboMaterias1.DisplayMember = "Nombre";
        }

        private void ComboMaterias1_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                CargarCorrelativas();
                TraerFechasInicioCursos();
                TraerCuposMaxCurso();
                
            }

            catch (Exception ex)
            {

                MessageBox.Show("No hay cursos", ex.ToString());

            }
        }

        private void BtnExisteCorrEnAprobadas_Click(object sender, EventArgs e)
        {
            ExisteEnDgAprobadas();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtApelldio.Text != "" && txtEmail.Text != "" && (comboSexo.Text == "Masculino" || comboSexo.Text == "Femenino"))
                {
                    unAlumno = (Alumno)dgvModAlumno.CurrentRow.DataBoundItem;
                    unAlumno.Nombre = txtNombre.Text;
                    unAlumno.Apellido = txtApelldio.Text;
                    unAlumno.Email = txtEmail.Text;
                    unAlumno.Sexo = comboSexo.Text;

                    unGestorAlumno.Modificar(unAlumno);

                    txtNombre.Text = "";
                    txtApelldio.Text = "";
                    txtEmail.Text = "";
                    comboSexo.Text = "Seleccione";
                    

                    dgvModAlumno.DataSource = null;
                    dgvModAlumno.DataSource = unGestorAlumno.traerAlumnos();
                    RemoverColumnas();
                    MessageBox.Show("Se modifico el alumno de legajo " + unAlumno.LegajoAlumno);
                }
                else
                {
                    txtNombre.Text = "";
                    txtApelldio.Text = "";
                    txtEmail.Text = "";
                    comboSexo.Text = "Seleccione";
                    MessageBox.Show("No se pudo modificar, verifique los datos ingresados");
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Error al modificar alumno");
            }
            
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            dgvModAlumno.DataSource = null;
            dgvModAlumno.DataSource = unGestorAlumno.traerAlumnos();
            RemoverColumnas();
        }
        private void RemoverColumnas()
        {
            dgvModAlumno.Columns.Remove("IdCarrera");
            //dgvModAlumno.Columns.Remove("Asistencia");
            //dgvModAlumno.Columns.Remove("Evaluacion");
            dgvModAlumno.Columns.Remove("Promedio");
            //dgvModAlumno.Columns.Remove("AlumnoMateria");

            dgvModAlumno.Columns.Remove("CreatedOn");
            dgvModAlumno.Columns.Remove("CreatedBy");
            dgvModAlumno.Columns.Remove("ChangedBy");
            dgvModAlumno.Columns.Remove("ChangedOn");

            //dgvModAlumno.Columns["IdMateriaCC"].HeaderText = "Id materia";
            //dgvModAlumno.Columns["Nombre"].HeaderText = "Nombre materia";
        }




        //private void ComboMaterias1_Click(object sender, EventArgs e)
        //{
        //    CargarMateriasDeCarrera();
        //    MessageBox.Show("hola");
        //}
    }
}
