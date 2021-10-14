using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Seguridad.frmUsuarios
{
    public partial class frmPrincipalUsuarios : Form
    {
        public frmPrincipalUsuarios()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmAltaUsuario"] as frmAltaUsuario) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmAltaUsuario"].BringToFront();
            }
            else
            {
                frmAltaUsuario f1 = new frmAltaUsuario();
                f1.MdiParent = this.MdiParent;
                f1.Show();
                this.MdiParent.MinimumSize = f1.Size;
            }
        }
    }
}
