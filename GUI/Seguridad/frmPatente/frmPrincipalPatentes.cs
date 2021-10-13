using GUI.Seguridad.frmPatente;
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
    public partial class frmPrincipalPatentes : Form
    {
        public frmPrincipalPatentes()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmAltaPatente"] as frmAltaPatente) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmAltaPatente"].BringToFront();
            }
            else
            {
                frmAltaPatente f1 = new frmAltaPatente();
                f1.MdiParent = this.MdiParent;
                f1.Show();
                this.MdiParent.MinimumSize = f1.Size;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {    
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmModificarPatente"] as frmModificarPatente) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmModificarPatente"].BringToFront();
            }
            else
            {
                frmModificarPatente f1 = new frmModificarPatente();
                f1.MdiParent = this.MdiParent;
                f1.Show();
                this.MdiParent.MinimumSize = f1.Size;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmBajaPatente"] as frmBajaPatente) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmBajaPatente"].BringToFront();
            }
            else
            {
                frmBajaPatente f1 = new frmBajaPatente();
                f1.MdiParent = this.MdiParent;
                f1.Show();
                this.MdiParent.MinimumSize = f1.Size;
            }
        }
    }
}
