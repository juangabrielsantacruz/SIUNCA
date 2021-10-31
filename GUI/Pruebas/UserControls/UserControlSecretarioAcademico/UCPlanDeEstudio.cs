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
using System.Threading;
using System.Globalization;
using Framework.D_2015.Idiomas;
using BLL.GestoresSeguridad;
using Framework.D_2015.Cache;
using BIZ.Seguridad;

namespace GUI.UserControlSecretarioAcademico
{
    public partial class UCPlanDeEstudio : UserControl
    {

        List<DetallesPlanDeEstudio> PEDetalles = new List<DetallesPlanDeEstudio>();
        List<DetallesCorrelativa> CorrelativasDetalles = new List<DetallesCorrelativa>();
        //List<DetallesDetMatPlanCorrPlan> DetallesDMPCP = new List<DetallesDetMatPlanCorrPlan>();
        //DetallesDetMatPlanCorrPlan UnDetalleCorrPlanMatPlan = new DetallesDetMatPlanCorrPlan();
        List<DTODetallesCorrPlan> DTODetallesCorrPlan = new List<DTODetallesCorrPlan>();
        DTODetallesCorrPlan unDTODMPCP = new DTODetallesCorrPlan();
        MateriaConCorrelativas UnaMateriaCC = new MateriaConCorrelativas();
        Carrera UnaCarrera = new Carrera();
        PlanDeEstudio2 unPlanDeEstudio = new PlanDeEstudio2();
        GestorPlanDeEstudio unGestorPE = new GestorPlanDeEstudio();


        public UCPlanDeEstudio()
        {
            InitializeComponent();
            CargarPlanes();
            //ucPlanDeEstudio
            CargarCarreras();
            
            //ucAsignarCorr
            CargarMateriasCC();
            
            //ucPlanDeEstudio
            //CargarPlanes();
            CargarMaterias();
            //IdiomaViejo.cambiarIdioma(IdiomaViejo.cacheIdioma, IdiomaPorDefecto);


            
        }

        //void IdiomaPorDefecto()
        //{
        //    lblNombrePlan.Text = Res.lblNombrePlan;
        //    lblCarrera.Text = Res.lblCarrera;
        //    lblObligatoriedad.Text = Res.lblObligatoriedad;
        //    lblAño.Text = Res.lblAño;
        //    lblCargaHoraria.Text = Res.lblCargaHoraria;
        //    lblNumeroMateria.Text = Res.lblNumeroMateria;
        //    lblMatConCorr.Text = Res.lblMatConCorr;
        //    btnAsignarCorrelativas.Text = Res.btnAsignarCorrelativas;
        //    btnConsultarCorrelativas.Text = Res.btnConsultarCorrelativas;
        //    button4.Text = Res.button4;
        //    button5.Text = Res.button5;
        //    btnGuardarPE.Text = Res.btnGuardarPE;
            
        //}  
        

        private void CargarPlanes()
        {
            GestorPlanDeEstudio unGPE = new GestorPlanDeEstudio();
            ComboPEcorr.DataSource = null;
            ComboPEcorr.DataSource = unGPE.TraerListaPlanes();
            ComboPEcorr.DisplayMember = "Nombre";

            ComboConsultaPlan.DataSource = null;
            ComboConsultaPlan.DataSource = unGPE.TraerListaPlanes();
            ComboConsultaPlan.DisplayMember = "Nombre";

            //dgvModPE.DataSource = null;
            //dgvModPE.DataSource = unGestorPE.TraerListaPlanes();
            //RemoverColumnas();
        }

        private void CargarMateriasCC()
        {            
            GestorMateriaCC unGM = new GestorMateriaCC();
            ComboMaterias1.DataSource = null;
            ComboMaterias1.DataSource = unGM.TraerListaMateriasCC();
            ComboMaterias1.DisplayMember = "Nombre";
        }


        private void btnConsultarCorrelativas_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

     
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarCarreras()
        {
            GestorCarrera unGC = new GestorCarrera();
            ComboBox3.DataSource = null;
            ComboBox3.DataSource = unGC.TraerListaCarreras();
            ComboBox3.DisplayMember = "Nombre";
        }

        private void CargarCorrelativas()
        {
            DTODetallesCorrPlan unDTOMPCP;
            GestorDetMatPlanCorrPlan unGDTOMPCP = new GestorDetMatPlanCorrPlan();
            unDTOMPCP = (DTODetallesCorrPlan)ComboMaterias1.SelectedItem;            

            //select nombre from materias ij dpe ij ddmpcp where m.idmateria = @dto.idmateria  (TRAIGO DTO)
            unDTOMPCP.IdPlanDetalles2 = ((DTODetallesCorrPlan)ComboConsultaMateria.SelectedItem).IdPlanDetalles;
            unDTOMPCP.NombreMateria2 = ((DTODetallesCorrPlan)ComboConsultaMateria.SelectedItem).Nombre;
            unDTOMPCP.IdPlanDeEstudio = ((DTODetallesCorrPlan)ComboConsultaPlan.SelectedItem).IdPlanDeEstudio;
            dgConsultaCorrelativas.DataSource = null;
            dgConsultaCorrelativas.DataSource = unGDTOMPCP.TraerListaCorrelativas(unDTOMPCP);


            dgConsultaCorrelativas.Columns.Remove("IdDetallesDetMatPlanCorrPlan");
            dgConsultaCorrelativas.Columns.Remove("IdPlanDetalles");
            dgConsultaCorrelativas.Columns.Remove("IdPlanDetalles2");
            dgConsultaCorrelativas.Columns.Remove("NumeroMateria");
            dgConsultaCorrelativas.Columns.Remove("NumeroMateria2");
            dgConsultaCorrelativas.Columns.Remove("Año");
            dgConsultaCorrelativas.Columns.Remove("Obligatoriedad");
            dgConsultaCorrelativas.Columns.Remove("CargaHoraria");
            dgConsultaCorrelativas.Columns.Remove("IdMateriaCC");
            dgConsultaCorrelativas.Columns.Remove("NombreMateria2");
            dgConsultaCorrelativas.Columns.Remove("IdPlanDeEstudio");

            dgConsultaCorrelativas.Columns.Remove("ChangedBy");
            dgConsultaCorrelativas.Columns.Remove("ChangedOn");
            dgConsultaCorrelativas.Columns.Remove("CreatedOn");
            dgConsultaCorrelativas.Columns.Remove("CreatedBy");

            dgConsultaCorrelativas.Columns[0].HeaderText = "Correlativas";
            dgConsultaCorrelativas.Columns[1].HeaderText = "Plan";

            //dgConsultaCorrelativas.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            //dgConsultaCorrelativas.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

        }



        private void Button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                {
                    DetallesPlanDeEstudio unDetallePE = new DetallesPlanDeEstudio();
                    DTODetallesCorrPlan UnaMateria;

                    UnaMateria = (DTODetallesCorrPlan)ComboMaterias1.SelectedItem;

                    // unDetallePE.IdMateriaCC = UnaMateria.IdMateriaCC.ToString();
                    unDetallePE.IdMateriaCC = UnaMateria.IdMateriaCC;
                    //unDetallePE.NumeroMateria = txtNumeroMateria.Text;
                    unDetallePE.NumeroMateria = int.Parse(txtNumeroMateria.Text);
                    //unDetallePE.Obligatoriedad = ComboObligatoriedad.SelectedItem.ToString;
                    //unDetallePE.Obligatoriedad = ComboObligatoriedad.SelectedItem;
                    
                    unDetallePE.Obligatoriedad = ComboObligatoriedad.SelectedItem.ToString();
                    unDetallePE.NombreMateria = ComboMaterias1.Text;
                    unDetallePE.Año = int.Parse(txtAño.Text);
                    unDetallePE.CargaHoraria = int.Parse(txtCargaHoraria.Text);


                    //VALIDO REPETIDOS
                    ExisteEnLista(txtNumeroMateria.Text, dgPEMaterias);
                    ExisteEnListaNombre(ComboMaterias1.Text, dgPEMaterias);

                    //
                    if (ComboObligatoriedad.Text != "Obligatoria" & ComboObligatoriedad.Text != "Opcional")
                    {
                        MessageBox.Show("Debe seleccionar bien la obligatoriedad.");
                        throw new Exception("error campo obligatoridad");
                    }
                    if (int.Parse(txtCargaHoraria.Text) > 20)
                    {
                        MessageBox.Show("Carga Horaria mayor a 20hs");
                        throw new Exception("Error en la carga horaria");
                    }
                                       

                    PEDetalles.Add(unDetallePE);

                    dgPEMaterias.DataSource = null;
                    dgPEMaterias.DataSource = PEDetalles;
                    //dgPEMaterias.Columns("IdPlanDeEstudio").Visible = false;
                    //dgPEMaterias.Columns("IdPlanDetalles").Visible = false;
                    //dgPEMaterias.Columns("IdMateriaCC").Visible = false;
                    dgPEMaterias.Columns.Remove("IdPlanDeEstudio");
                    dgPEMaterias.Columns.Remove("IdPlanDetalles");
                    dgPEMaterias.Columns.Remove("IdMateriaCC");
                    dgPEMaterias.Columns.Remove("ChangedBy");
                    dgPEMaterias.Columns.Remove("ChangedOn");
                    dgPEMaterias.Columns.Remove("CreatedOn");
                    dgPEMaterias.Columns.Remove("CreatedBy");

                    //dgPEMaterias.Columns["NombreMateriaCC"].HeaderText = "Nombre materia";
                    dgPEMaterias.Columns["NombreMateria"].HeaderText = "Nombre materia";
                    dgPEMaterias.Columns["CargaHoraria"].HeaderText = "Carga Horaria";
                    dgPEMaterias.Columns["NumeroMateria"].HeaderText = "Numero de materia";

                    dgPEMaterias.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                    dgPEMaterias.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

                    label10.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faltan campos");
                //throw ex;
            }
            

        }

        //FUNCION Q VALIDA REPETIDOS
        public Boolean ExisteEnLista(String Rol, DataGridView Dg)
        {
            Boolean existe = false;
            foreach (DataGridViewRow row in Dg.Rows)
            {
                String verificar = Convert.ToString(row.Cells["NumeroMateria"].Value);
                if (Rol == verificar)
                {
                    labelMensaje.Visible = true;
                    labelMensaje.Text = "Ya existe";
                    existe = true;
                    MessageBox.Show("Numero de materia repetido");
                    throw new Exception("Numero de materia repetido");
                    break;
                }
                else
                {
                    labelMensaje.Visible = true;
                    existe = false;
                    labelMensaje.Text = "Agregado";
                }
            }
            return existe;
        }

        public Boolean ExisteEnListaNombre(String Rol, DataGridView Dg)
        {
            Boolean existe = false;
            foreach (DataGridViewRow row in Dg.Rows)
            {
                String verificar = Convert.ToString(row.Cells["NombreMateria"].Value);
                if (Rol == verificar)
                {
                    labelMensaje.Text = "Ya existe";
                    existe = true;
                    MessageBox.Show("Nombre de materia repetido");                    
                    throw new Exception("Nombre de materia repetido");
                    break;
                }
                else
                {
                    existe = false;
                    labelMensaje.Text = "Agregado";
                }
            }
            return existe;
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            PEDetalles.Remove((DetallesPlanDeEstudio)dgPEMaterias.CurrentRow.DataBoundItem);
            dgPEMaterias.DataSource = null;
            dgPEMaterias.DataSource = PEDetalles;
            dgPEMaterias.Columns.Remove("IdPlanDeEstudio");
            dgPEMaterias.Columns.Remove("IdPlanDetalles");
            dgPEMaterias.Columns.Remove("IdMateriaCC");
            dgPEMaterias.Columns.Remove("ChangedBy");
            dgPEMaterias.Columns.Remove("ChangedOn");
            dgPEMaterias.Columns.Remove("CreatedOn");
            dgPEMaterias.Columns.Remove("CreatedBy");

            dgPEMaterias.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dgPEMaterias.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            //dgPEMaterias.Columns("IdPlanDeEstudio").Visible = false;
            //dgPEMaterias.Columns("IdPlanDetalles").Visible = false;
            //dgPEMaterias.Columns("IdMateriaCC").Visible = false;
        }

        private void btnAsignarCorrelativas_Click_1(object sender, EventArgs e)
        {
            //frmCorrelativas.Show();
            //tabPage2.Show();
            //tabPage2.Focus();
            //tabPage2.Select();
            tabControl1.SelectedIndex = 1;


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    DTODetallesCorrPlan unDMPCP = new DTODetallesCorrPlan();

                    DTODetallesCorrPlan unDTO;
                    DTODetallesCorrPlan unDTO2;

                    unDTO = (DTODetallesCorrPlan)ComboCorrelativas.SelectedItem;
                    unDTO.Nombre = ComboCorrelativas.Text;



                    unDTO2 = (DTODetallesCorrPlan)ComboMateriasCC.SelectedItem;
                    unDTO2.Nombre = ComboMateriasCC.Text;




                    unDMPCP.IdPlanDetalles = unDTO.IdPlanDetalles;
                    unDMPCP.IdPlanDetalles2 = unDTO2.IdPlanDetalles;
                    unDMPCP.Nombre = unDTO.Nombre;
                    unDMPCP.Nombre = ComboMateriasCC.Text;
                    unDMPCP.NombreMateria2 = unDTO2.NombreMateria2;                    
                    unDMPCP.NombreMateria2 = ComboCorrelativas.Text;
                    //unDMPCP.NombreMateriaCC = ComboMateriasCC.Text;

                    //ValidoExistente2(ComboCorrelativas.Text, dgCorrelatividades);

                    DTODetallesCorrPlan.Add(unDMPCP);


                    dgCorrelatividades.DataSource = null;
                    dgCorrelatividades.DataSource = DTODetallesCorrPlan;                    
                    


                    dgCorrelatividades.Columns.Remove("IdDetallesDetMatPlanCorrPlan");
                    dgCorrelatividades.Columns.Remove("NumeroMateria");
                    dgCorrelatividades.Columns.Remove("NumeroMateria2");
                    dgCorrelatividades.Columns.Remove("Obligatoriedad");
                    dgCorrelatividades.Columns.Remove("IdMateriaCC");
                    dgCorrelatividades.Columns.Remove("IdPlanDeEstudio");
                    dgCorrelatividades.Columns.Remove("Año");
                    dgCorrelatividades.Columns.Remove("NombrePlan");
                    dgCorrelatividades.Columns.Remove("CargaHoraria");
                    dgCorrelatividades.Columns.Remove("CreatedOn");
                    dgCorrelatividades.Columns.Remove("CreatedBy");
                    dgCorrelatividades.Columns.Remove("ChangedBy");
                    dgCorrelatividades.Columns.Remove("ChangedOn");



                    dgCorrelatividades.Columns["Nombre"].HeaderText = "Materia seleccionada";
                    dgCorrelatividades.Columns["NombreMateria2"].HeaderText = "Correlativa asignada";


                }
            }
            catch (Exception)
            {

                MessageBox.Show("error al agregar al listado");
                throw;
            }
           
        }
        public Boolean ValidoExistente2(String Rol, DataGridView Dg)
        {
            Boolean existe = false;
            foreach (DataGridViewRow row in Dg.Rows)
            {
                String verificar = Convert.ToString(row.Cells["NombreMateria"].Value);
                if (Rol == verificar)
                {
                    //labelMensaje.Text = "Ya existe";
                    existe = true;
                    MessageBox.Show("Nombre de correlativa repetido");
                    throw new Exception("Nombre de correlativa repetido");
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
        private void CargarMaterias()
        {

            DTODetallesCorrPlan unPE;
            GestorPEDetalle unGDetPE = new GestorPEDetalle();
            unPE = (DTODetallesCorrPlan)ComboPEcorr.SelectedItem;
            ComboCorrelativas.DataSource = null;
            ComboCorrelativas.DataSource = unGDetPE.TraerListaPEDetalles(unPE);

            ComboCorrelativas.DisplayMember = "Nombre";

            //
            ComboMateriasCC.DataSource = null;
            ComboMateriasCC.DataSource = unGDetPE.TraerListaPEDetalles(unPE);

            ComboMateriasCC.DisplayMember = "Nombre";

        }

        private void CargarMaterias2()
        {
            DTODetallesCorrPlan unPE2;
            GestorPEDetalle unGDetPE = new GestorPEDetalle();
            unPE2 = (DTODetallesCorrPlan)ComboConsultaPlan.SelectedItem;
            ComboConsultaMateria.DataSource = null;
            ComboConsultaMateria.DataSource = unGDetPE.TraerListaPEDetalles(unPE2);

            ComboConsultaMateria.DisplayMember = "Nombre";
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            //UnaMateriaCC.Nombre = ((Materias)ComboMateriasCC.SelectedItem).Nombre;

            //try
            //{
            //    GestorMateriaCC GestorMateriaCC = new GestorMateriaCC();
            //    GestorMateriaCC.CrearMateriaConCorrelativa(UnaMateriaCC, CorrelativasDetalles);
            //    MessageBox.Show("materia con correlativa guardada.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al guardar Materia con correlativa.");
            //}

            unDTODMPCP.IdPlanDetalles = ((DTODetallesCorrPlan)ComboCorrelativas.SelectedItem).IdPlanDetalles;
            unDTODMPCP.IdPlanDetalles2 = ((DTODetallesCorrPlan)ComboMateriasCC.SelectedItem).IdPlanDetalles;
            
            try
            {
                GestorDetMatPlanCorrPlan GestorDMPCP = new GestorDetMatPlanCorrPlan();
                GestorDetMatPlanCorrPlan.CrearDetMatPlanCorrPlan(unDTODMPCP, DTODetallesCorrPlan);
                MessageBox.Show("materia con correlativa guardada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar Materia con correlativa.");
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // unPlanDeEstudio.HorasTotales = Total
            GestorBitacora unGestorBitacora = new GestorBitacora();

           
            //

            UnaCarrera = (Carrera)ComboBox3.SelectedItem;
            unPlanDeEstudio.IdCarrera = UnaCarrera.IdCarrera;
            unPlanDeEstudio.NombreCarrera = ((Carrera)ComboBox3.SelectedItem).Nombre;
            unPlanDeEstudio.Nombre = textBox1.Text;

            try
            {
                if (unPlanDeEstudio.Nombre=="")
                {
                    MessageBox.Show("Falta nombre del plan.");
                    throw new Exception("Nombre del plan en blanco");
                }
                GestorPlanDeEstudio GestorPE = new GestorPlanDeEstudio();
                GestorPE.CrearPlanDeEstudio(unPlanDeEstudio, PEDetalles);
                MessageBox.Show("Se registró el Plan de estudio.");

                //Agrego una bitacora del registro del plan.
                unGestorBitacora.AgregarBitacora1(CacheUsuario.iduser, 2, DateTime.Now, "Se registro un plan de estudio");
            }
            catch (Exception ex)
            {
                //Interaction.MsgBox("Error al guardar el Plan de estudio.");
                MessageBox.Show("Error al guardar el Plan de estudio.");
            }
        }

        private void ComboMaterias1_Click(object sender, EventArgs e)
        {
            
                CargarMateriasCC();
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            DTODetallesCorrPlan.Remove((DTODetallesCorrPlan)dgCorrelatividades.CurrentRow.DataBoundItem);
            dgCorrelatividades.DataSource = null;
            dgCorrelatividades.DataSource = DTODetallesCorrPlan;

            dgCorrelatividades.Columns.Remove("IdDetallesDetMatPlanCorrPlan");
            dgCorrelatividades.Columns.Remove("NumeroMateria");
            dgCorrelatividades.Columns.Remove("NumeroMateria2");
            dgCorrelatividades.Columns.Remove("Obligatoriedad");
            dgCorrelatividades.Columns.Remove("CargaHoraria");

            dgCorrelatividades.Columns["Nombre"].HeaderText = "Materia seleccionada";
            dgCorrelatividades.Columns["NombreMateria2"].HeaderText = "Correlativa asignada";

        }


        

        private void ComboPEcorr_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            CargarCorrelativas();
        }

        private void ComboConsultaPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMaterias2();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtModNombre.Text != "" )
                {
                    unDTODMPCP = (DTODetallesCorrPlan)dgvModPE.CurrentRow.DataBoundItem;
                    unDTODMPCP.Nombre = txtModNombre.Text;
                    

                    unGestorPE.Modificar(unDTODMPCP);

                    txtModNombre.Text = "";
                    


                    dgvModPE.DataSource = null;
                    dgvModPE.DataSource = unGestorPE.TraerListaPlanes();
                    RemoverColumnas();
                    MessageBox.Show("Se modifico el Plan " + unPlanDeEstudio.Nombre);
                }
                else
                {
                    txtModNombre.Text = "";                    
                    MessageBox.Show("No se pudo modificar, verifique los datos ingresados");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al modificar Plan");
            }
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            dgvModPE.DataSource = null;
            dgvModPE.DataSource = unGestorPE.TraerListaPlanes();
            RemoverColumnas();
        }
        private void RemoverColumnas()
        {
            dgvModPE.Columns.Remove("IdDetallesDetMatPlanCorrPlan");
            dgvModPE.Columns.Remove("IdPlanDetalles");
            dgvModPE.Columns.Remove("IdPlanDetalles2");
            dgvModPE.Columns.Remove("NumeroMateria");
            dgvModPE.Columns.Remove("NumeroMateria2");
            dgvModPE.Columns.Remove("NombreMateria2");
            dgvModPE.Columns.Remove("Año");
            dgvModPE.Columns.Remove("NombrePlan");
            dgvModPE.Columns.Remove("CargaHoraria");
            dgvModPE.Columns.Remove("Obligatoriedad");
            dgvModPE.Columns.Remove("IdMateriaCC");

            dgvModPE.Columns.Remove("CreatedOn");
            dgvModPE.Columns.Remove("CreatedBy");
            dgvModPE.Columns.Remove("ChangedBy");
            dgvModPE.Columns.Remove("ChangedOn");

            dgvModPE.Columns["IdPlanDeEstudio"].HeaderText = "Id del Plan";
            //dgvModAlumno.Columns["Nombre"].HeaderText = "Nombre materia";
        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
