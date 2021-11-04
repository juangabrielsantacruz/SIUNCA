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
        List<object> lista2 = new List<object>();
        public frmCorrelatividad()
        {
            InitializeComponent();
        }

        private void frmCorrelatividad_Load(object sender, EventArgs e)
        {
            CargarPlanes();
            CargarMaterias();
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
            //dgDetallesPlan.DataSource = null;
            //dgDetallesPlan.DataSource = listaDetalles;


            var lista = (from a in listaDetalles
                         select new
                         {
                             NumeroMateria = a.NumeroMateria,
                             Materia = a.Materia.IdMateria,
                             Nombre = a.Materia.Nombre,
                             Año = a.Año,
                             Cuatrimestre = a.Cuatrimestre,
                             CargaHoraria = a.CargaHorariaTotal
                         }).ToList();


            dgDetallesPlan.DataSource = null;
            dgDetallesPlan.DataSource = lista;
        }

        private void btnAgregarCorrelativa_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    DetallesPlan unDetallePE = new DetallesPlan();
                    //DetallesDetallePlan unDetalleDetallePE = new DetallesDetallePlan();
                    Materia UnaMateria = new Materia();

                    UnaMateria = (Materia)cbMateria.SelectedItem;

                    unDetallePE.Materia = UnaMateria;

                    var row = dgDetallesPlan.CurrentRow.DataBoundItem;
                    if (CorroborarRepetidos() == false)
                    {
                        lista2.Add(row);
                    }                  


                    dgDetallesDetalle.DataSource = null;
                    dgDetallesDetalle.DataSource = lista2;
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
                if (dgDetallesDetalle.CurrentRow.Cells[2].Value.ToString() == dgDetallesDetalle.Rows[i].Cells[3].Value.ToString())
                {
                    MessageBox.Show("Registro duplicado");
                    existe = true;
                }
            }
            return existe;
        }
    }
}
