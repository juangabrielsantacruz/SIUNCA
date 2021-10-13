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

namespace GUI.Seguridad.frmBitacora
{
    public partial class frmBitacora : Form
    {
        GestorBitacora unGestorBitacora = new GestorBitacora();
        GestorTipoBitacora unGestorTipoBitacora = new GestorTipoBitacora();
        GestorUsuario unGestorUsuario = new GestorUsuario();
        List<Bitacora2> ListaBitacoras = new List<Bitacora2>();
        public frmBitacora()
        {
            InitializeComponent();
            List<Usuario> lista = new List<Usuario>();
            List<TipoBitacora> lista2 = new List<TipoBitacora>();
            List<string> lista3 = new List<string>();

            lista = unGestorUsuario.TraerTodo();
            lista2 = unGestorTipoBitacora.TraerTodos();
            lista3 = unGestorBitacora.TraerTodosEventos();


            cbUsuario.DataSource = null;
            cbUsuario.DataSource = lista;
            cbUsuario.DisplayMember = "iduser";
            cbCriticidad.DataSource = null;
            cbCriticidad.DataSource = lista2;
            cbCriticidad.DisplayMember = "Descripcion";


            cbEvento.DataSource = null;
            cbEvento.DataSource = lista3;
        }

        private void btnFiltrar1_Click(object sender, EventArgs e)
        {
            ListaBitacoras = unGestorBitacora.ConsultarBitacora(dtpFechaInicial.Value, dtpFechaFinal.Value, (TipoBitacora)cbCriticidad.SelectedItem, (Usuario)cbUsuario.SelectedItem);

            dgvBitacoras.DataSource = null;
            dgvBitacoras.DataSource = ListaBitacoras;
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ListaBitacoras = unGestorBitacora.ConsultarBitacora(dtpFechaInicial.Value, dtpFechaFinal.Value, (TipoBitacora)cbCriticidad.SelectedItem, (Usuario)cbUsuario.SelectedItem, (string)cbEvento.SelectedValue);

            dgvBitacoras.DataSource = null;
            dgvBitacoras.DataSource = ListaBitacoras;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GestorBitacora unGestorBitacora = new GestorBitacora();

            // 'Forma 1
            // Dim unaBitacora As New BitacoraDTO

            // unaBitacora.FechaHora = Date.Now
            // unaBitacora.Mensaje = "Todo Bien"
            // unaBitacora.TipoBitacora = cbCriticidad.SelectedItem
            // unaBitacora.Usuario = cbUsuario.SelectedItem

            // unGestorBitacora.AgregarBitacora(unaBitacora)

            // Forma 2

            unGestorBitacora.AgregarBitacora((Usuario)cbUsuario.SelectedItem, (TipoBitacora)cbCriticidad.SelectedItem, DateTime.Now, "Todo ok");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            unGestorBitacora.EliminarBitacoras(ListaBitacoras);
        }
    }
}
