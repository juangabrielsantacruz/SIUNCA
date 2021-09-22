using BIZ.Seguridad;
using BLL;
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
        Idioma unIdioma1 = new Idioma() { Id = 1, Nombre = "Español" };
        Idioma unIdioma2 = new Idioma() { Id = 2, Nombre = "Inglés" };
        //private SesionSingleton instancia = SesionSingleton.Instancia;
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

            ////
            ///

            //var gestoridioma = new GestorIdioma();
            //cbIdioma.DataSource = GestorIdioma.ObtenerIdiomas();
            //cbIdioma.DisplayMember = "Nombre_Idioma";
            //cbIdioma.ValueMember = "IdIdioma";
            //GestorIdioma.TraerIdiomaPorId(int.Parse((string)cbIdioma.SelectedValue));
           
            ///
            ///
            //aca debo TRAER IDIOMAS y el resultado va a sesion.instancia.CambiarIdioma(resultado)

            GenerarDiccionarios();
            SesionSingleton.Instancia.CambiarIdioma(unIdioma1);
            SesionSingleton.Instancia.RegistrarObservador(this);
            Actualizar(SesionSingleton.Instancia.idioma);

            idiomatest2 form2 = new idiomatest2();
            form2.Show();

        }

        void GenerarDiccionarios()
        {
            //aca debo traer lista de palabras
            Palabra p1 = new Palabra() { Id = 1, Texto = "TagLabelESP" };

            //aca debo traer lista de traducciones
            Traduccion t1 = new Traduccion()
            {
                Id = 1,
                Palabra = p1,
                PalabraTraducida = "TagLabelESP"
            };

            Traduccion t2 = new Traduccion()
            {
                Id = 2,
                Palabra = p1,
                PalabraTraducida = "HomeING"
            };

            Palabra p2 = new Palabra() { Id = 2, Texto = "TagBOTON" };

            Traduccion t3 = new Traduccion()
            {
                Id = 3,
                Palabra = p2,
                PalabraTraducida = "TagBOTON"
            };

            Traduccion t4 = new Traduccion()
            {
                Id = 4,
                Palabra = p2,
                PalabraTraducida = "ChangeING"
            };

            Palabra p3 = new Palabra() { Id = 2, Texto = "combo" };

            Traduccion t5 = new Traduccion()
            {
                Id = 3,
                Palabra = p3,
                PalabraTraducida = "combo"
            };

            Traduccion t6 = new Traduccion()
            {
                Id = 4,
                Palabra = p3,
                PalabraTraducida = "comboing"
            };

            unIdioma1.AgregarTraduccion(t1);
            unIdioma1.AgregarTraduccion(t3);
            unIdioma2.AgregarTraduccion(t2);
            unIdioma2.AgregarTraduccion(t4);
            unIdioma1.AgregarTraduccion(t5);
            unIdioma2.AgregarTraduccion(t6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SesionSingleton.Instancia.CambiarIdioma(unIdioma2);
        }
    }
}
