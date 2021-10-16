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

namespace GUI.Seguridad.frmPatente
{
    public partial class frmModificarPatente : Form
    {
        Patente2 unaPatente = new Patente2();
        GestorPatente unGestorPatente = new GestorPatente();
        public frmModificarPatente()
        {
            InitializeComponent();
        }

        private void btnModPatente_Click(object sender, EventArgs e)
        {
            unaPatente = (Patente2)dgvModPatente.CurrentRow.DataBoundItem;
            unaPatente.Descripcion = txtModDescPatente.Text;

            unGestorPatente.Modificar(unaPatente);

            txtModDescPatente.Text = "";

            dgvModPatente.DataSource = null;
            dgvModPatente.DataSource = unGestorPatente.TraerTodo();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            dgvModPatente.DataSource = null;
            dgvModPatente.DataSource = unGestorPatente.TraerTodo();
        }
    }
}
