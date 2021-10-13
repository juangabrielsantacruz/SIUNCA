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
    public partial class frmAltaFamilia : Form
    {
        GestorFamilia unGestorFamilia = new GestorFamilia();
        public frmAltaFamilia()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Familia nuevaFamilia = new Familia();

            nuevaFamilia.Descripcion = txtDescripcionFamilia.Text;
            nuevaFamilia.Id = int.Parse(txtIdFamilia.Text);

            unGestorFamilia.Insertar(nuevaFamilia);

            txtDescripcionFamilia.Text = "";
            txtIdFamilia.Text = "";

            dgvAltaFamilias.DataSource = null;
            dgvAltaFamilias.DataSource = unGestorFamilia.TraerTodo();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //familias traer todo            
            dgvAltaFamilias.DataSource = null;
            dgvAltaFamilias.DataSource = unGestorFamilia.TraerTodo();
        }
    }
}
