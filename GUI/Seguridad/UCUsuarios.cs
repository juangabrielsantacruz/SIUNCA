using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ;
using BLL;
using Framework.D_2015.Seguridad;


namespace GUI.Seguridad
{
    public partial class UCUsuarios : UserControl
    {
        GestorUsuario gestorusuario = new GestorUsuario();

        public UCUsuarios()
        {
            InitializeComponent();
            cboRol.SelectedIndex = 0;

            refrescarDGUsuario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();

            usuario.username = txtUsername.Text;
            usuario.password = Hash.getSHA256(txtPasword.Text);
            usuario.email = txtMail.Text;
            usuario.rol = cboRol.Text;

            gestorusuario.guardarUsuario(usuario);

            MessageBox.Show("El usuario ha sido guardado con exito");

            //Limpiar textbox
            txtMail.Text = "";
            txtPasword.Text = "";
            txtUsername.Text = "";
            cboRol.SelectedIndex = 0;
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count > 0)
            {
                var idUsuario = (int)dgUsuarios.CurrentRow.Cells["iduser"].Value;
                gestorusuario.eliminarUsuario(idUsuario);
                MessageBox.Show("El usuario ha sido eliminado con exito");
                refrescarDGUsuario();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para poder eliminar el usuario");
            }
        }

        List<Usuario> ListaUsuarios()
        {
            return gestorusuario.TraerTodo();
        }

        void refrescarDGUsuario()
        {
            dgUsuarios.DataSource = ListaUsuarios();

            //Oculta columnas 
            dgUsuarios.Columns[0].Visible = false;
            dgUsuarios.Columns[2].Visible = false;
            //Modifica el nombre de las columnas
            dgUsuarios.Columns[1].HeaderText = "Nombre y apellido";
            dgUsuarios.Columns[1].HeaderText = "Email";
            dgUsuarios.Columns[1].HeaderText = "Rol";
            dgUsuarios.Columns[1].HeaderText = "Perfil";

        }
    }
}
