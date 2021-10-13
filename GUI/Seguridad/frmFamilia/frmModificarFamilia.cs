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

namespace GUI.Seguridad.frmFamilia
{
    public partial class frmModificarFamilia : Form
    {
        GestorFamilia unGestorFamilia = new GestorFamilia();
        Familia unaFamilia = new Familia();
        public frmModificarFamilia()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            

            unaFamilia = (Familia)dgvModFamilias.CurrentRow.DataBoundItem;
            unaFamilia.Descripcion = txtModDescripcionFamilia.Text;

            unGestorFamilia.Modificar(unaFamilia);

            txtModDescripcionFamilia.Text = "";

            dgvModFamilias.DataSource = null;
            dgvModFamilias.DataSource = unGestorFamilia.TraerTodo();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            // familias traer todo
            dgvModFamilias.DataSource = null;
            dgvModFamilias.DataSource = unGestorFamilia.TraerTodo();
        }
    }
}
