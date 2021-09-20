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
    public partial class idiomatest : Form, IObservador
    {
        Idioma i1 = new Idioma() { Id = 1, Nombre = "Español" };
        Idioma i2 = new Idioma() { Id = 2, Nombre = "Inglés" };
        public idiomatest()
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


        private void idiomatest_Load(object sender, EventArgs e)
        {
            GenerarDiccionarios();
            SesionSingleton.Instancia.CambiarIdioma(i1);
            SesionSingleton.Instancia.RegistrarObservador(this);
            Actualizar(SesionSingleton.Instancia.idioma);

            idiomatest2 form2 = new idiomatest2();
            form2.Show();

        }

        void GenerarDiccionarios()
        {
            Palabra p1 = new Palabra() { Id = 1, Texto = "Inicio" };

            Traduccion t1 = new Traduccion()
            {
                Id = 1,
                Palabra = p1,
                PalabraTraducida = "Inicio"
            };

            Traduccion t2 = new Traduccion()
            {
                Id = 2,
                Palabra = p1,
                PalabraTraducida = "Home"
            };

            Palabra p2 = new Palabra() { Id = 2, Texto = "Cambiar" };

            Traduccion t3 = new Traduccion()
            {
                Id = 3,
                Palabra = p2,
                PalabraTraducida = "Cambiar"
            };

            Traduccion t4 = new Traduccion()
            {
                Id = 4,
                Palabra = p2,
                PalabraTraducida = "Change"
            };

            i1.AgregarTraduccion(t1);
            i1.AgregarTraduccion(t3);
            i2.AgregarTraduccion(t2);
            i2.AgregarTraduccion(t4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SesionSingleton.Instancia.CambiarIdioma(i2);
        }
    }
}
