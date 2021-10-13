using GUI.Seguridad;
using GUI.Seguridad.frmBitacora;
using GUI.Seguridad.frmBackup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmPrincipalPerfiles"] as frmPrincipalPerfiles) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPrincipalPerfiles"].BringToFront();
            }
            else
            {
                frmPrincipalPerfiles frmSegu = new frmPrincipalPerfiles();
                frmSegu.MdiParent = this;
                frmSegu.Show();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmPrincipalPerfiles"] as frmPrincipalPerfiles) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPrincipalPerfiles"].BringToFront();
            }
            else
            {
                frmPrincipalPerfiles frmSegu = new frmPrincipalPerfiles();
                frmSegu.MdiParent = this;
                frmSegu.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {   
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmBitacora"] as frmBitacora) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPrincipalPerfiles"].BringToFront();
            }
            else
            {
                frmBitacora frmBitacora = new frmBitacora();
                frmBitacora.MdiParent = this;
                frmBitacora.Show();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmBackup"] as frmBackup) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPrincipalPerfiles"].BringToFront();
            }
            else
            {
                frmBackup frmBitacora = new frmBackup();
                frmBitacora.MdiParent = this;
                frmBitacora.Show();
            }
        }
    }
}
