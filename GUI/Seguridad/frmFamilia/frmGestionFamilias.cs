using BIZ.Seguridad;
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

namespace GUI.Seguridad
{
    public partial class frmGestionFamilias : Form
    {
        GestorPatente unGestorPatente = new GestorPatente();
        GestorFamilia unGestorFamilia = new GestorFamilia();

        Familia unaFamilia = new Familia();
        public frmGestionFamilias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvFamilias.DataSource = null;
            dgvFamilias.DataSource = unGestorFamilia.TraerTodo();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Bloqueo Controles
            //BloqueoFamilia();

            Familia unaFamilia = new Familia();
            // Cargo Familia seleccionada del DataGrid
            unaFamilia = (Familia)dgvFamilias.CurrentRow.DataBoundItem;

            CargarPermisosFamilia(unaFamilia);
        }
        public void CargarPermisosFamilia(Familia unaFamilia)
        {
            List<Patente> PatentesFaltantes;
            List<Familia> FamiliasFaltantes;

            // Muestro las Familias de la Familia seleccionada
            dgvFamiliaFamilia.DataSource = null;
            dgvFamiliaFamilia.DataSource = unaFamilia.Lista.Where(x => x.GetType() == typeof(Familia)).ToList();

            // Muestro todas las Patentes (incluso contenidas dentro de Familias) de la Familia seleccionada
            dgvFamiliaPatente.DataSource = null;
            dgvFamiliaPatente.DataSource = unaFamilia.ListaCompleta;

            // Llevo todas las Patentes existentes a PatentesFaltantes
            PatentesFaltantes = unGestorPatente.TraerTodo();

            // Saco las Patentes que la Familia ya tiene
            foreach (Patente item in unaFamilia.ListaCompleta)
            {
                if (PatentesFaltantes.Contains(item))
                    PatentesFaltantes.Remove(item);
            }

            // Muestro Patentes que Familia seleccionada no tiene
            dgvFamiliaSinPatente.DataSource = null;
            dgvFamiliaSinPatente.DataSource = PatentesFaltantes;

            // Llevo todas las Familias existentes a FamiliasFaltantes
            FamiliasFaltantes = unGestorFamilia.TraerTodo();

            // Saco las Familias que la Familia seleccionada ya tiene
            foreach (var item in unaFamilia.Lista)
            {
                if (item.GetType() == typeof(Familia))
                {
                    if (FamiliasFaltantes.Exists(x => x.Id == item.Id))
                        FamiliasFaltantes.RemoveAll(y => y.Id == item.Id);
                }
            }

            // Elimino la Familia que ya está seleccionada, sino quedará repetida por el TraerTodo
            FamiliasFaltantes.RemoveAll(x => x.Id == unaFamilia.Id);

            // Muestro Familias que Usuario no tiene
            dgvFamiliaSinFamilia.DataSource = null;
            dgvFamiliaSinFamilia.DataSource = FamiliasFaltantes;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            unGestorFamilia.GuardarPermisos(unaFamilia);

            // Restauro Controles
            RestaurarFamilia();

            dgvFamilias.DataSource = null;
            dgvFamilias.DataSource = unGestorFamilia.TraerTodo();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //Descartar cambios
            RestaurarFamilia();
        }
        public void RestaurarFamilia()
        {
            // Desbloqueo Controles
            dgvFamilias.Enabled = true;
            //btnActualizarGrillaFamilias.Enabled = true;
            //btnCargarFamilia.Enabled = true;
            //btnDescartarFamilia.Enabled = false;
            //btnGuardarFamilia.Enabled = false;

            dgvFamiliaFamilia.DataSource = null;
            dgvFamiliaPatente.DataSource = null;
            dgvFamiliaSinFamilia.DataSource = null;
            dgvFamiliaSinPatente.DataSource = null;

            unaFamilia = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Familia FamiliaSeleccionada = new Familia();
            // Cargo Familia seleccionada de la grilla
            FamiliaSeleccionada = (Familia)dgvFamiliaSinFamilia.CurrentRow.DataBoundItem;

            unaFamilia.Agregar(FamiliaSeleccionada);

            CargarPermisosFamilia(unaFamilia);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Familia FamiliaSeleccionada = new Familia();
            // Cargo Familia seleccionada de la grilla
            FamiliaSeleccionada = (Familia)dgvFamiliaFamilia.CurrentRow.DataBoundItem;

            unaFamilia.Quitar(FamiliaSeleccionada);

            CargarPermisosFamilia(unaFamilia);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // quito Patente seleccionada de la grilla
            Patente unaPatente = new Patente();
            unaPatente = (Patente)dgvFamiliaPatente.CurrentRow.DataBoundItem;

            unaFamilia.Quitar(unaPatente);

            CargarPermisosFamilia(unaFamilia);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // agrego Patente seleccionada de la grilla
            Patente unaPatente = new Patente();
            unaPatente = (Patente)dgvFamiliaSinPatente.CurrentRow.DataBoundItem;

            unaFamilia.Agregar(unaPatente);

            CargarPermisosFamilia(unaFamilia);
        }
    }
}
