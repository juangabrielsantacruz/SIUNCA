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
    public partial class frmAltaPatente : Form
    {
        Patente unaPatente = new Patente();
        GestorPatente unGestorPatente = new GestorPatente();
        public frmAltaPatente()
        {
            InitializeComponent();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            unaPatente.Id = int.Parse(txtIdPatente.Text);
            unaPatente.Descripcion = txtDescripcionPatente.Text;

            unGestorPatente.Insertar(unaPatente);

            txtDescripcionPatente.Text = "";
            txtIdPatente.Text = "";


            dgvPatentes.DataSource = null;
            dgvPatentes.DataSource = unGestorPatente.TraerTodo();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            dgvPatentes.DataSource = null;
            dgvPatentes.DataSource = unGestorPatente.TraerTodo();
        }
    }
}
