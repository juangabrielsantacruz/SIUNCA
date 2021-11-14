using BIZ;
using BIZ.GestionPlanes;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.PlanDeEstudio
{
    public partial class frmCorrelatividad : Form
    {
        GestorPlanDeEstudio unGPE = new GestorPlanDeEstudio();
        GestorPEDetalle unGDP = new GestorPEDetalle();
        List<DetallesPlan> listaDetalles = new List<DetallesPlan>();
        GestorMateria unGM = new GestorMateria();
        List<Materia> lista2 = new List<Materia>();
        List<DetallesDetallePlan> lista4 = new List<DetallesDetallePlan>();
        List<object> lista3 = new List<object>();
        public frmCorrelatividad()
        {
            InitializeComponent();
        }

        private void frmCorrelatividad_Load(object sender, EventArgs e)
        {
            CargarPlanes();
            //CargarMaterias();
        }

        private void CargarMaterias()
        {
            cbMateria.DataSource = null;
            cbMateria.DataSource = unGM.TraerListaMaterias();
            cbMateria.DisplayMember = "Nombre";
        }

        private void CargarPlanes()
        {            
            cbPlan.DataSource = null;
            cbPlan.DataSource = unGPE.TraerListaPlanes();
            cbPlan.DisplayMember = "Nombre";
        }

        private void cbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDataGridDetalles();
        }

        private void CargarDataGridDetalles()
        {
            GestorPEDetalle unGDetPE2 = new GestorPEDetalle();
            BIZ.GestionPlanes.PlanDeEstudio unPE = (BIZ.GestionPlanes.PlanDeEstudio)cbPlan.SelectedItem;
            
            listaDetalles = unGDetPE2.TraerListaPEDetallesBien(unPE);
            dgDetallesPlan.DataSource = null;
            dgDetallesPlan.DataSource = listaDetalles;

            cbMateria.DataSource = null;
            cbMateria.DataSource = unGDetPE2.TraerListaPEDetallesBien(unPE);
            cbMateria.DisplayMember = "Materia";


            //var lista = listaDetalles.Select(x => new
            //{
            //    NumeroMateria = x.NumeroMateria,
            //    Nombre = x.Materia.Nombre,
            //    Año = x.Año,
            //    Cuatrimestre = x.Cuatrimestre,
            //    CargaHorariaTotal = x.CargaHorariaTotal
            //}).ToList();



            //dgDetallesPlan.DataSource = null;
            //dgDetallesPlan.DataSource = lista;
        }

        private void btnAgregarCorrelativa_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    DetallesPlan unDetallePE = new DetallesPlan();
                    //DetallesDetallePlan unDetalleDetallePE = new DetallesDetallePlan();
                    Materia UnaMateria = new Materia();

                    //UnaMateria = (Materia)cbMateria.SelectedItem;

                    unDetallePE.Materia = UnaMateria;

                    DetallesDetallePlan UnaMateriaCorrelativa = new DetallesDetallePlan();
                    //UnaMateriaCorrelativa.IdDetallesPlan = (DetallesPlan)dgDetallesPlan.CurrentRow.DataBoundItem;
                    //UnaMateriaCorrelativa.IdMateria = Int32.Parse(dgDetallesPlan.CurrentRow.Cells[1].Value.ToString());
                    UnaMateriaCorrelativa.IdDetallesPlan = Int32.Parse(dgDetallesPlan.CurrentRow.Cells[0].Value.ToString());

                    //var row = dgDetallesPlan.CurrentRow.DataBoundItem;
                    if (CorroborarRepetidos() == false)
                    {
                        lista4.Add(UnaMateriaCorrelativa);
                    }                  


                    dgDetallesDetalle.DataSource = null;
                    dgDetallesDetalle.DataSource = lista4;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Faltan campos");
                throw ex;
            }

        }

        private bool CorroborarRepetidos()
        {
            bool existe = false;

            for (int i = 0; i < dgDetallesDetalle.Rows.Count; i++)
            {
                if (dgDetallesPlan.CurrentRow.Cells[0].Value.ToString() == dgDetallesDetalle.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Registro duplicado");
                    existe = true;
                }
            }
            return existe;
        }

        private void btnGuardarCorrelativas_Click(object sender, EventArgs e)
        {
            DetallesPlan unDetalle = new DetallesPlan();

            unDetalle.IdDetallePlan = Int32.Parse(dgDetallesPlan.CurrentRow.Cells[0].Value.ToString());

            
            //UnaCarrera = (Carrera)cbCarrera.SelectedItem;
            //unPlanDeEstudio.IdCarrera = UnaCarrera.IdCarrera;
            ////unPlanDeEstudio.NombreCarrera = ((Carrera)ComboBox3.SelectedItem).Nombre;
            //unPlanDeEstudio.Nombre = textBox1.Text;

            try
            {
                GestorDetMatPlanCorrPlan GestorPE = new GestorDetMatPlanCorrPlan();
                GestorPE.GuardarCorrelativas2(unDetalle, lista4);
                MessageBox.Show("Se registró el Plan de estudio.");

                //Agrego una bitacora del registro del plan.
                //unGestorBitacora.AgregarBitacora1(manejadorsesion.user..., 2, DateTime.Now, "Se registro un plan de estudio");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el Plan de estudio.");
            }
        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCorrelativasActuales();
        }

        private void CargarCorrelativasActuales()
        {
            //aca traigo todas las correlativas que posee en el otro datagrid
        }
    }
}
