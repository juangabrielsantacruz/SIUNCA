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
    public partial class frmPrincipalPerfiles : Form
    {
        public frmPrincipalPerfiles()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
           //Verfica que el form no este abierto
            if ((Application.OpenForms["frmPerfilesUsuarios"] as frmPerfilesUsuarios) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPerfilesUsuarios"].BringToFront();
            }
            else
            {
                frmPerfilesUsuarios f1 = new frmPerfilesUsuarios();
                f1.MdiParent = this.MdiParent;
                f1.Show();
                this.MdiParent.MinimumSize = f1.Size;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmPrincipalFamilias"] as frmPrincipalFamilias) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPrincipalFamilias"].BringToFront();
            }
            else
            {
                frmPrincipalFamilias f1 = new frmPrincipalFamilias();
                f1.MdiParent = this.MdiParent;
                f1.Show();
                this.MdiParent.MinimumSize = f1.Size;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmPrincipalPatentes"] as frmPrincipalPatentes) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPrincipalPatentes"].BringToFront();
            }
            else
            {
                frmPrincipalPatentes f1 = new frmPrincipalPatentes();
                f1.MdiParent = this.MdiParent;
                f1.Show();
                this.MdiParent.MinimumSize = f1.Size;
            }
        }
    }
}
