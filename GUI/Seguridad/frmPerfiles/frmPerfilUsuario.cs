using BIZ;
using BIZ.Seguridad;
using BLL;
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

namespace GUI.Seguridad.frmPerfiles
{
    public partial class frmPerfilUsuario : Form
    {
        GestorUsuario repo;
        PermisosBLL permisosRepo;
        Usuario seleccion;
        Usuario tmp;
        public frmPerfilUsuario()
        {
            InitializeComponent();

            repo = new GestorUsuario();
            permisosRepo = new PermisosBLL();
            this.cboUsuarios.DataSource = repo.GetAll();
            this.cboFamilias.DataSource = permisosRepo.GetAllFamilias();
            this.cboPatentes.DataSource = permisosRepo.GetAllPatentes();
        }
        void LlenarTreeView(TreeNode padre, Componente c)
        {
            TreeNode hijo = new TreeNode(c.Nombre);
            hijo.Tag = c;
            padre.Nodes.Add(hijo);

            foreach (var item in c.Hijos)
            {
                LlenarTreeView(hijo, item);
            }

        }

        void MostrarPermisos(Usuario u)
        {
            this.treeView1.Nodes.Clear();
            TreeNode root = new TreeNode(u.username);

            foreach (var item in u.Permisos)
            {
                LlenarTreeView(root, item);
            }

            this.treeView1.Nodes.Add(root);
            this.treeView1.ExpandAll();
        }

        private void cmdConfigurar_Click(object sender, EventArgs e)
        {
            seleccion = (Usuario)this.cboUsuarios.SelectedItem;

            //hago una copia del objeto para no modificr el que esta en el combo.
            tmp = new Usuario();
            tmp.iduser = seleccion.iduser;
            tmp.username = seleccion.username;
            permisosRepo.FillUserComponents(tmp);

            MostrarPermisos(tmp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
                var patente = (Patente)cboPatentes.SelectedItem;
                if (patente != null)
                {
                    var esta = false;

                    foreach (var item in tmp.Permisos)
                    {
                        if (permisosRepo.Existe(item, patente.Id))
                        {
                            esta = true;
                            break;
                        }
                    }
                    if (esta)
                        MessageBox.Show("El usuario ya tiene la patente indicada");
                    else
                    {
                        {
                            tmp.Permisos.Add(patente);
                            MostrarPermisos(tmp);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Seleccione un usuario");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
                var flia = (Familia)cboFamilias.SelectedItem;
                if (flia != null)
                {
                    var esta = false;
                    //verifico que ya no tenga el permiso. TODO: Esto debe ser parte de otra capa.
                    foreach (var item in tmp.Permisos)
                    {
                        if (permisosRepo.Existe(item, flia.Id))
                        {
                            esta = true;
                        }
                    }

                    if (esta)
                        MessageBox.Show("El usuario ya tiene la familia indicada");
                    else
                    {
                        {
                            permisosRepo.FillFamilyComponents(flia);

                            tmp.Permisos.Add(flia);
                            MostrarPermisos(tmp);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Seleccione un usuario");
        }

        private void cmdGuardarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                repo.GuardarPermisos(tmp);
                MessageBox.Show("Usuario guardado correctamente");
            }
            catch (Exception)
            {

                MessageBox.Show("Error al guardar el usuario");
            }
        }
    }
}
