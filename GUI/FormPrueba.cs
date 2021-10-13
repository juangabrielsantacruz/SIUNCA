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
    public partial class FormPrueba : Form
    {
        public FormPrueba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProfesor form = new frmProfesor();
            form.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSecretarioAcademico form = new frmSecretarioAcademico();
            form.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show(this);
        }

        private void idioma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idiomatest frmidioma = new idiomatest();
            frmidioma.MdiParent = this;
            //frmidioma.Dock = DockStyle.Fill;
            frmidioma.Show();

        }

        private void formSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeguridad frmSegu = new frmSeguridad();
            frmSegu.MdiParent = this;
            //frmSegu.Dock = DockStyle.Fill;
            frmSegu.Show();
            //this.WindowState = FormWindowState.Maximized;


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOLA");
        }

        private void FormPrueba_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmSeguridad"] as frmSeguridad) != null)
            {
                MessageBox.Show("ya abierto");
                Application.OpenForms["frmSeguridad"].BringToFront();
            }
            else
            {
                frmSeguridad frmSegu = new frmSeguridad();
                frmSegu.MdiParent = this;
                //frmSegu.Dock = DockStyle.Fill;
                frmSegu.Show();
                
            }
        }
    }
}
