using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BIZ;
using BIZ.Seguridad;
using BLL.GestoresSeguridad;

namespace GUI.Seguridad
{
    public partial class UCPerfilesUsuarios : UserControl
    {
        GestorUsuario UnGestorUsuario = new GestorUsuario();
        Usuario unUsuario = new Usuario();
        GestorPatente unGestorPatente = new GestorPatente();
        GestorFamilia unGestorFamilia = new GestorFamilia();

        public UCPerfilesUsuarios()
        {
            InitializeComponent();
            //usuarios traer todo
            dgvUsuariosGestion.DataSource = null;
            dgvUsuariosGestion.DataSource = UnGestorUsuario.TraerTodo();
            //familias traer todo
            dgvFamilias.DataSource = null;
            dgvFamilias.DataSource = unGestorFamilia.TraerTodo();
            dgvAltaFamilias.DataSource = null;
            dgvAltaFamilias.DataSource = unGestorFamilia.TraerTodo();
            dgvBajaFamilias.DataSource = null;
            dgvBajaFamilias.DataSource = unGestorFamilia.TraerTodo();
            dgvModFamilias.DataSource = null;
            dgvModFamilias.DataSource = unGestorFamilia.TraerTodo();
            //patentes traer todo
            dgvPatentes.DataSource = null;
            dgvPatentes.DataSource = unGestorPatente.TraerTodo();
            dgvBajaPatentes.DataSource = null;
            dgvBajaPatentes.DataSource = unGestorPatente.TraerTodo();
            dgvModPatente.DataSource = null;
            dgvModPatente.DataSource = unGestorPatente.TraerTodo();

        }
       

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void AdsdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCBitacora ucbit = new UCBitacora();
            ucbit.Show();
        }

        /// /////////


        // UC PERFILES USUARIO /////


        /// /////////
        private void Button19_Click(object sender, EventArgs e)
        {           

            dgvUsuariosGestion.DataSource = null;
            dgvUsuariosGestion.DataSource = UnGestorUsuario.TraerTodo();           

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            // Bloqueo Controles
            //dgvUsuariosGestion.Enabled = false;
            //btnActualizarGrilla.Enabled = false;
            //btnCargarUsuario.Enabled = false;
            //btnDescartarCambiosUsuario.Enabled = true;
            //btnGuardarCambiosUsuario.Enabled = true;

            try
            {
                // Cargo Usuario seleccionado en grilla                
                unUsuario = new Usuario();
                unUsuario = (Usuario)dgvUsuariosGestion.CurrentRow.DataBoundItem ;
                // Logueo (traigo Perfil) del Usuario
                unUsuario = UnGestorUsuario.Login(unUsuario);

                CargarPermisosUsuario(unUsuario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        private void Button4_Click_1(object sender, EventArgs e)
        {
            // Agregar Familia seleccionada de la grilla
            Familia unaFamilia = new Familia();
            unaFamilia = (Familia)dgvUsuarioSinFamilias.CurrentRow.DataBoundItem;

            unUsuario.AgregarFamilia(unaFamilia);

            CargarPermisosUsuario(unUsuario);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // Quitar Familia seleccionada de la grilla
            Familia unaFamilia = new Familia();
            unaFamilia = (Familia)dgvFamiliasUsuario.CurrentRow.DataBoundItem;

            unUsuario.QuitarFamilia(unaFamilia);

            CargarPermisosUsuario(unUsuario);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            // Agrego Patente seleccionada de la grilla
            Patente unaPatente = new Patente();
            unaPatente = (Patente)dgvUsuarioSinPatentes.CurrentRow.DataBoundItem;

            unUsuario.AgregarPatente(unaPatente);

            CargarPermisosUsuario(unUsuario);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            // quito Patente seleccionada de la grilla
            Patente unaPatente = new Patente();
            unaPatente = (Patente)dgvPatentesUsuario.CurrentRow.DataBoundItem;

            unUsuario.QuitarPatente(unaPatente);

            CargarPermisosUsuario(unUsuario);
        }

        public void CargarPermisosUsuario(Usuario unUsuario)
        {
            List<Patente> PatentesFaltantes;
            List<Familia> FamiliasFaltantes;

            // Muestro las Familias del Usuario

            dgvFamiliasUsuario.DataSource = null;
            dgvFamiliasUsuario.DataSource = unUsuario.Perfil.Lista.Where(x => x.GetType() == typeof(Familia)).ToList();

            // Muestro todas las Patentes individuales del Usuario
            dgvPatentesUsuario.DataSource = null;
            dgvPatentesUsuario.DataSource = unUsuario.Perfil.Lista.Where(x => x.GetType() == typeof(Patente)).ToList();

            // Muestro las Patentes de las Familias que el Usuario tenga
            List<Permiso> miniLista = new List<Permiso>();
            miniLista = unUsuario.Perfil.Lista.Where(x => x.GetType() == typeof(Familia)).ToList();
            dgvUsuarioPatenteFamilia.DataSource = null;
            dgvUsuarioPatenteFamilia.DataSource = miniLista.SelectMany(x => x.ListaCompleta).Distinct().ToList();

            // Llevo todas las Patentes existentes a PatentesFaltantes
            PatentesFaltantes = new List<Patente>();
            PatentesFaltantes = unGestorPatente.TraerTodo();

            // Saco las Patentes que el Usuario ya tiene
            foreach (Patente item in unUsuario.Perfil.ListaCompleta)
            {
                if (PatentesFaltantes.Contains(item))
                    PatentesFaltantes.Remove(item);
            }

            // Muestro Patentes que Usuario no tiene esta bien el name del dg?LACONCHA
            dgvUsuarioSinPatentes.DataSource = null;
            dgvUsuarioSinPatentes.DataSource = PatentesFaltantes;

            // Llevo todas las Familias existentes a FamiliasFaltantes
            FamiliasFaltantes = unGestorFamilia.TraerTodo();

            // Saco las Familias que el Usuario ya tiene
            foreach (var item in unUsuario.Perfil.Lista)
            {
                if (item.GetType() == typeof(Familia))
                {
                    if (FamiliasFaltantes.Exists(x => x.Id == item.Id))
                        FamiliasFaltantes.RemoveAll(y => y.Id == item.Id);
                }
            }

            // Muestro Familias que Usuario no tiene
            dgvUsuarioSinFamilias.DataSource = null;
            dgvUsuarioSinFamilias.DataSource = FamiliasFaltantes;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // Para guardar todos los cambios
            UnGestorUsuario.GuardarPermisos(unUsuario);

            // Restauro Controles
            //dgvUsuariosGestion.Enabled = true;
            //btnActualizarGrilla.Enabled = true;
            //btnCargarUsuario.Enabled = true;
            //btnDescartarCambiosUsuario.Enabled = false;
            //btnGuardarCambiosUsuario.Enabled = false;

            dgvFamiliasUsuario.DataSource = null;
            dgvPatentesUsuario.DataSource = null;
            dgvUsuarioPatenteFamilia.DataSource = null;
            dgvUsuarioSinFamilias.DataSource = null;
            dgvUsuarioSinPatentes.DataSource = null;

            dgvUsuariosGestion.DataSource = null;
            dgvUsuariosGestion.DataSource = UnGestorUsuario.TraerTodo();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            {
                // Restauro Controles y descarto cambios
                unUsuario = null;

                //dgvUsuariosGestion.Enabled = true;
                //btnActualizarGrilla.Enabled = true;
                //btnCargarUsuario.Enabled = true;
                //btnDescartarCambiosUsuario.Enabled = false;
                //btnGuardarCambiosUsuario.Enabled = false;

                dgvFamiliasUsuario.DataSource = null;
                dgvPatentesUsuario.DataSource = null;
                dgvUsuarioPatenteFamilia.DataSource = null;
                dgvUsuarioSinFamilias.DataSource = null;
                dgvUsuarioSinPatentes.DataSource = null;

                dgvUsuariosGestion.DataSource = null;
                dgvUsuariosGestion.DataSource = UnGestorUsuario.TraerTodo();
            }

        }




        /// /////////


        // UC FAMILIA /////


        /// /////////

        Familia unaFamilia = new Familia();
        private void Button1_Click(object sender, EventArgs e)
        {
            dgvFamilias.DataSource = null;
            dgvFamilias.DataSource = unGestorFamilia.TraerTodo();
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            // Bloqueo Controles
            //BloqueoFamilia();

            Familia unaFamilia = new Familia();
            // Cargo Familia seleccionada del DataGrid
            unaFamilia = (Familia)dgvFamilias.CurrentRow.DataBoundItem;

            CargarPermisosFamilia(unaFamilia);
        }

        public void CargarPermisosFamilia(Familia unaFamilia)
        {
            List<Patente> PatentesFaltantes;
            List<Familia> FamiliasFaltantes;

            // Muestro las Familias de la Familia seleccionada
            dgvFamiliaFamilia.DataSource = null;
            dgvFamiliaFamilia.DataSource = unaFamilia.Lista.Where(x => x.GetType() == typeof(Familia)).ToList();

            // Muestro todas las Patentes (incluso contenidas dentro de Familias) de la Familia seleccionada
            dgvFamiliaPatente.DataSource = null;
            dgvFamiliaPatente.DataSource = unaFamilia.ListaCompleta;

            // Llevo todas las Patentes existentes a PatentesFaltantes
            PatentesFaltantes = unGestorPatente.TraerTodo();

            // Saco las Patentes que la Familia ya tiene
            foreach (Patente item in unaFamilia.ListaCompleta)
            {
                if (PatentesFaltantes.Contains(item))
                    PatentesFaltantes.Remove(item);
            }

            // Muestro Patentes que Familia seleccionada no tiene
            dgvFamiliaSinPatente.DataSource = null;
            dgvFamiliaSinPatente.DataSource = PatentesFaltantes;

            // Llevo todas las Familias existentes a FamiliasFaltantes
            FamiliasFaltantes = unGestorFamilia.TraerTodo();

            // Saco las Familias que la Familia seleccionada ya tiene
            foreach (var item in unaFamilia.Lista)
            {
                if (item.GetType() == typeof(Familia))
                {
                    if (FamiliasFaltantes.Exists(x => x.Id == item.Id))
                        FamiliasFaltantes.RemoveAll(y => y.Id == item.Id);
                }
            }

            // Elimino la Familia que ya está seleccionada, sino quedará repetida por el TraerTodo
            FamiliasFaltantes.RemoveAll(x => x.Id == unaFamilia.Id);

            // Muestro Familias que Usuario no tiene
            dgvFamiliaSinFamilia.DataSource = null;
            dgvFamiliaSinFamilia.DataSource = FamiliasFaltantes;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Familia FamiliaSeleccionada = new Familia();
            // Cargo Familia seleccionada de la grilla
            FamiliaSeleccionada = (Familia)dgvFamiliaSinFamilia.CurrentRow.DataBoundItem;

            unaFamilia.Agregar(FamiliaSeleccionada);

            CargarPermisosFamilia(unaFamilia);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // agrego Patente seleccionada de la grilla
            Patente unaPatente = new Patente();
            unaPatente = (Patente)dgvFamiliaSinPatente.CurrentRow.DataBoundItem;

            unaFamilia.Agregar(unaPatente);

            CargarPermisosFamilia(unaFamilia);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            Familia FamiliaSeleccionada = new Familia();
            // Cargo Familia seleccionada de la grilla
            FamiliaSeleccionada = (Familia)dgvFamiliaFamilia.CurrentRow.DataBoundItem;

            unaFamilia.Quitar(FamiliaSeleccionada);

            CargarPermisosFamilia(unaFamilia);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            // quito Patente seleccionada de la grilla
            Patente unaPatente = new Patente();
            unaPatente = (Patente)dgvFamiliaPatente.CurrentRow.DataBoundItem;

            unaFamilia.Quitar(unaPatente);

            CargarPermisosFamilia(unaFamilia);
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            unGestorFamilia.GuardarPermisos(unaFamilia);

            // Restauro Controles
            RestaurarFamilia();

            dgvFamilias.DataSource = null;
            dgvFamilias.DataSource = unGestorFamilia.TraerTodo();
        }
        private void Button21_Click(object sender, EventArgs e)
        {
            //Descartar cambios
            RestaurarFamilia();
        }


        public void RestaurarFamilia()
        {
            // Desbloqueo Controles
            dgvFamilias.Enabled = true;
            //btnActualizarGrillaFamilias.Enabled = true;
            //btnCargarFamilia.Enabled = true;
            //btnDescartarFamilia.Enabled = false;
            //btnGuardarFamilia.Enabled = false;

            dgvFamiliaFamilia.DataSource = null;
            dgvFamiliaPatente.DataSource = null;
            dgvFamiliaSinFamilia.DataSource = null;
            dgvFamiliaSinPatente.DataSource = null;

            unaFamilia = null;
        }
        /// 
        /// Alta FAMILIA
        /// 
        private void Button16_Click(object sender, EventArgs e)
        {
            Familia nuevaFamilia = new Familia();

            nuevaFamilia.Descripcion = txtDescripcionFamilia.Text;
            nuevaFamilia.Id = int.Parse(txtIdFamilia.Text);

            unGestorFamilia.Insertar(nuevaFamilia);

            txtDescripcionFamilia.Text = "";
            txtIdFamilia.Text = "";

            dgvFamilias.DataSource = null;
            dgvFamilias.DataSource = unGestorFamilia.TraerTodo();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            //familias traer todo            
            dgvAltaFamilias.DataSource = null;
            dgvAltaFamilias.DataSource = unGestorFamilia.TraerTodo();
        }
        /// 
        /// Alta FAMILIA
        /// 

        /// 
        /// BAJA FAMILIA
        /// 
        private void Button35_Click(object sender, EventArgs e)
        {
            unaFamilia = (Familia)dgvBajaFamilias.CurrentRow.DataBoundItem;

            unGestorFamilia.Quitar(unaFamilia);

            dgvFamilias.DataSource = null;
            dgvFamilias.DataSource = unGestorFamilia.TraerTodo();
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            // familias traer todo
            dgvBajaFamilias.DataSource = null;
            dgvBajaFamilias.DataSource = unGestorFamilia.TraerTodo();
        }
        /// 
        /// BAJA FAMILIA
        /// 

        /// 
        /// MOD FAMILIA
        /// 
        private void Button11_Click(object sender, EventArgs e)
        {
            Familia unaFamilia = new Familia();

            unaFamilia = (Familia)dgvModFamilias.CurrentRow.DataBoundItem;
            unaFamilia.Descripcion = txtModDescripcionFamilia.Text;

            unGestorFamilia.Modificar(unaFamilia);

            txtModDescripcionFamilia.Text = "";

            dgvFamilias.DataSource = null;
            dgvFamilias.DataSource = unGestorFamilia.TraerTodo();
        }
        
        private void Button33_Click(object sender, EventArgs e)
        {
            // familias traer todo
            dgvModFamilias.DataSource = null;
            dgvModFamilias.DataSource = unGestorFamilia.TraerTodo();
        }
        /// 
        /// MOD FAMILIA
        /// 

        /// /////////


        // UC PATENTE /////


        /// /////////
        /// 
        /// 
        /// Alta PATENTE
        /// 

        Patente unaPatente = new Patente();
        private void Button32_Click(object sender, EventArgs e)
        {
            unaPatente.Id = int.Parse(txtIdPatente.Text);
            unaPatente.Descripcion = txtDescripcionPatente.Text;

            unGestorPatente.Insertar(unaPatente);

            txtDescripcionPatente.Text = "";
            txtIdPatente.Text = "";


            dgvPatentes.DataSource = null;
            dgvPatentes.DataSource = unGestorPatente.TraerTodo();
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            dgvPatentes.DataSource = null;
            dgvPatentes.DataSource = unGestorPatente.TraerTodo();
        }
        /// 
        /// Alta PATENTE
        ///

        /// 
        /// BAJA PATENTE
        /// 

        private void Button8_Click(object sender, EventArgs e)
        {
            Patente unaPatente = new Patente();
            DialogResult respuesta;
            unaPatente = (Patente)dgvBajaPatentes.CurrentRow.DataBoundItem;
            //MessageBox.Show("mensaje", "titulo", MessageBoxButtons.YesNo);
            respuesta = MessageBox.Show("¿Estás seguro que querés borrar ésta patente? Se eliminarán todas las relaciones.", "Atencion", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                unGestorPatente.Quitar(unaPatente);
            }
            else
            {

            }               

            dgvBajaPatentes.DataSource = null;
            dgvBajaPatentes.DataSource = unGestorPatente.TraerTodo();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            dgvBajaPatentes.DataSource = null;
            dgvBajaPatentes.DataSource = unGestorPatente.TraerTodo();
        }

        /// 
        /// BAJA PATENTE
        /// 

        /// 
        /// MOD PATENTE
        /// 

        private void BtnModPatente_Click(object sender, EventArgs e)
        {
            unaPatente = (Patente)dgvModPatente.CurrentRow.DataBoundItem;
            unaPatente.Descripcion = txtModDescPatente.Text;

            unGestorPatente.Modificar(unaPatente);

            txtModDescPatente.Text = "";

            dgvModPatente.DataSource = null;
            dgvModPatente.DataSource = unGestorPatente.TraerTodo();
        }
        
        private void Button28_Click(object sender, EventArgs e)
        {
            dgvModPatente.DataSource = null;
            dgvModPatente.DataSource = unGestorPatente.TraerTodo();
        }

        /// 
        /// MOD PATENTE
        /// 

        /// /////////

    }
}
