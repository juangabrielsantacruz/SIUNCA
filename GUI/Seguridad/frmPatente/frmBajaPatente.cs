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
    public partial class frmBajaPatente : Form
    {
        Patente2 unaPatente = new Patente2();
        GestorPatente unGestorPatente = new GestorPatente();
        public frmBajaPatente()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            unaPatente = (Patente2)dgvBajaPatentes.CurrentRow.DataBoundItem;
            //MessageBox.Show("mensaje", "titulo", MessageBoxButtons.YesNo);
            respuesta = MessageBox.Show("¿Estás seguro que querés borrar ésta patente? Se eliminarán todas las relaciones.", "Atencion", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                unGestorPatente.Quitar(unaPatente);
            }
            else
            {

            }

            dgvBajaPatentes.DataSource = null;
            dgvBajaPatentes.DataSource = unGestorPatente.TraerTodo();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dgvBajaPatentes.DataSource = null;
            dgvBajaPatentes.DataSource = unGestorPatente.TraerTodo();
        }
    }
}
