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
    public partial class frmBajaFamilia : Form
    {
        GestorFamilia unGestorFamilia = new GestorFamilia();
        Familia unaFamilia = new Familia();
        public frmBajaFamilia()
        {
            InitializeComponent();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            unaFamilia = (Familia)dgvBajaFamilias.CurrentRow.DataBoundItem;

            unGestorFamilia.Quitar(unaFamilia);

            dgvBajaFamilias.DataSource = null;
            dgvBajaFamilias.DataSource = unGestorFamilia.TraerTodo();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            // familias traer todo
            dgvBajaFamilias.DataSource = null;
            dgvBajaFamilias.DataSource = unGestorFamilia.TraerTodo();
        }
    }
}
