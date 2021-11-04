using BIZ;
using BIZ.GestionPlanes;
using BLL;
using BLL.GestoresSeguridad;
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
    public partial class frmPlanDeEstudio : Form
    {
        List<DetallesPlan> listaDetalles = new List<DetallesPlan>();
        List<object> lista = new List<object>();
        GestorBitacora unGestorBitacora = new GestorBitacora();
        Carrera UnaCarrera = new Carrera();
        GestorPlanDeEstudio unGestorPE = new GestorPlanDeEstudio();
        BIZ.GestionPlanes.PlanDeEstudio unPlanDeEstudio = new BIZ.GestionPlanes.PlanDeEstudio();
        GestorMateria unGM = new GestorMateria();
        GestorCarrera unGC = new GestorCarrera();

        public frmPlanDeEstudio()
        {
            InitializeComponent();
        }
        private void frmPlanDeEstudio_Load(object sender, EventArgs e)
        {
            CargarCarreras();
            CargarMaterias();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    DetallesPlan unDetallePE = new DetallesPlan();
                    Materia UnaMateria = new Materia();

                    UnaMateria = (Materia)cbMateria.SelectedItem;

                    unDetallePE.Materia = UnaMateria;
                    unDetallePE.NumeroMateria = int.Parse(txtNumeroMateria.Text);
                    unDetallePE.Año = int.Parse(txtAño.Text);
                    unDetallePE.Cuatrimestre = int.Parse(txtCuatrimestre.Text);
                    unDetallePE.CargaHorariaTotal = int.Parse(txtCargaHoraria.Text);

                    if (CorroborarRepetidos() == false)
                    {
                        listaDetalles.Add(unDetallePE);
                    }                   

                    //var lista = (from a in listaDetalles
                    //             select new {
                    //                 NumeroMateria = a.NumeroMateria,
                    //                 Materia = a.Materia.Nombre,
                    //                 Año = a.Año,
                    //                 Cuatrimestre = a.Cuatrimestre,
                    //                 CargaHoraria = a.CargaHorariaTotal}).ToList();

                    var lista2 = listaDetalles.Select(x => new
                    {
                        NumeroMateria = x.NumeroMateria,
                        Nombre = x.Materia.Nombre,
                        Año = x.Año,
                        Cuatrimestre = x.Cuatrimestre,
                        CargaHorariaTotal = x.CargaHorariaTotal
                    }).ToList();



                    dgPEMaterias.DataSource = null;
                    dgPEMaterias.DataSource = lista2;                    

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

            for (int i = 0; i < dgPEMaterias.Rows.Count; i++)
            {
                if (cbMateria.Text == dgPEMaterias.Rows[i].Cells[1].Value.ToString() || txtNumeroMateria.Text == dgPEMaterias.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Registro duplicado");
                    existe = true;
                }
            }
            return existe;
        }



        private void btnGuardarPE_Click(object sender, EventArgs e)
        {
            UnaCarrera = (Carrera)cbCarrera.SelectedItem;
            unPlanDeEstudio.IdCarrera = UnaCarrera.IdCarrera;
            //unPlanDeEstudio.NombreCarrera = ((Carrera)ComboBox3.SelectedItem).Nombre;
            unPlanDeEstudio.Nombre = textBox1.Text;

            try
            {
                if (unPlanDeEstudio.Nombre == "")
                {
                    MessageBox.Show("Falta nombre del plan.");
                    throw new Exception("Nombre del plan en blanco");
                }
                GestorPlanDeEstudio GestorPE = new GestorPlanDeEstudio();
                GestorPE.CrearPlanDeEstudio(unPlanDeEstudio, listaDetalles);
                MessageBox.Show("Se registró el Plan de estudio.");

                //Agrego una bitacora del registro del plan.
                //unGestorBitacora.AgregarBitacora1(manejadorsesion.user..., 2, DateTime.Now, "Se registro un plan de estudio");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el Plan de estudio.");
            }
        }

        private void btnQuitarMateria_Click(object sender, EventArgs e)
        {
            //var item = dgPEMaterias.CurrentRow.DataBoundItem;
            // borrar de la lista 
            //listaDetalles.RemoveAt(1)
            
            listaDetalles.Remove((DetallesPlan)dgPEMaterias.CurrentRow.DataBoundItem);

            dgPEMaterias.DataSource = null;
            dgPEMaterias.DataSource = listaDetalles;

        }     

        private void CargarMaterias()
        {
            cbMateria.DataSource = null;
            cbMateria.DataSource = unGM.TraerListaMaterias();
            cbMateria.DisplayMember = "Nombre";
        }

        private void CargarCarreras()
        {
            cbCarrera.DataSource = null;
            cbCarrera.DataSource = unGC.TraerListaCarreras();
            cbCarrera.DisplayMember = "Nombre";
        }

        private void btnAgregarCorrelativas_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
           
                frmCorrelatividad frmSegu = new frmCorrelatividad();
               
                frmSegu.Show();
            
        }
    }
}
