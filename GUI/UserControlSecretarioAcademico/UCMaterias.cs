using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BIZ;
using BIZ.DTOs;

namespace GUI.UserControlSecretarioAcademico
{
    public partial class UCMaterias : UserControl
    {
        public UCMaterias()
        {
            InitializeComponent();

        }

        private void RemoverColumnas()
        {
            dgvModMat.Columns.Remove("IdDetallesDetMatPlanCorrPlan");
            dgvModMat.Columns.Remove("NumeroMateria");
            dgvModMat.Columns.Remove("NumeroMateria2");
            dgvModMat.Columns.Remove("NombreMateria2");
            dgvModMat.Columns.Remove("Obligatoriedad");
            dgvModMat.Columns.Remove("IdPlanDeEstudio");
            dgvModMat.Columns.Remove("IdPlanDetalles");
            dgvModMat.Columns.Remove("IdPlanDetalles2");
            dgvModMat.Columns.Remove("Año");
            dgvModMat.Columns.Remove("NombrePlan");
            dgvModMat.Columns.Remove("CargaHoraria");
            dgvModMat.Columns.Remove("CreatedOn");
            dgvModMat.Columns.Remove("CreatedBy");
            dgvModMat.Columns.Remove("ChangedBy");
            dgvModMat.Columns.Remove("ChangedOn");

            dgvModMat.Columns["IdMateriaCC"].HeaderText = "Id materia";
            dgvModMat.Columns["Nombre"].HeaderText = "Nombre materia";
        }

        GestorMateriaCC unGestorMateria = new GestorMateriaCC();
        DTODetallesCorrPlan unaMateria = new DTODetallesCorrPlan();
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            unaMateria = (DTODetallesCorrPlan)dgvModMat.CurrentRow.DataBoundItem;
            unaMateria.Nombre = txtNombreMat.Text;

            unGestorMateria.Modificar(unaMateria);

            txtNombreMat.Text = "";

            dgvModMat.DataSource = null;
            dgvModMat.DataSource = unGestorMateria.TraerListaMateriasCC();
            RemoverColumnas();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            dgvModMat.DataSource = null;
            dgvModMat.DataSource = unGestorMateria.TraerListaMateriasCC();
            RemoverColumnas();
        }
    }
}
