using GUI.Seguridad.frmFamilia;
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
    public partial class frmPrincipalFamilias : Form
    {
        public frmPrincipalFamilias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmGestionFamilias"] as frmGestionFamilias) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmGestionFamilias"].BringToFront();
            }
            else
            {
                frmGestionFamilias f1 = new frmGestionFamilias();
                f1.MdiParent = this.MdiParent;
                f1.Show();
                this.MdiParent.MinimumSize = f1.Size;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmAltaFamilia"] as frmAltaFamilia) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmAltaFamilia"].BringToFront();
            }
            else
            {
                frmAltaFamilia f1 = new frmAltaFamilia();
                f1.MdiParent = this.MdiParent;
                f1.Show();
                this.MdiParent.MinimumSize = f1.Size;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmModificarFamilia"] as frmModificarFamilia) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmModificarFamilia"].BringToFront();
            }
            else
            {
                frmModificarFamilia f1 = new frmModificarFamilia();
                f1.MdiParent = this.MdiParent;
                f1.Show();
                this.MdiParent.MinimumSize = f1.Size;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmBajaFamilia"] as frmBajaFamilia) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmBajaFamilia"].BringToFront();
            }
            else
            {
                frmBajaFamilia f1 = new frmBajaFamilia();
                f1.MdiParent = this.MdiParent;
                f1.Show();
                this.MdiParent.MinimumSize = f1.Size;
            }
        }
    }
}
