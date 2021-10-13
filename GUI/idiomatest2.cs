using BIZ.Seguridad;
using Framework.D_2015.Multiidioma;
using Interfaces;
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
    public partial class idiomatest2 : Form, IObservador
    {
        //SesionSingleton inst = SesionSingleton.Instancia;
        public idiomatest2()
        {
            InitializeComponent();
        }

        public void Actualizar(IIdioma idiomaObservado)
        {
            foreach (Control item in this.Controls)
            {
                item.Text = idiomaObservado.BuscarTraduccion(item.Tag.ToString());
            }
        }

        

        private void idiomatest2_Load(object sender, EventArgs e)
        {
            SesionSingleton.Instancia.RegistrarObservador(this);
            //Actualizar(SesionSingleton.Instancia.idioma);
        }
    }
}
