using BIZ;
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
        Idioma unIdioma = new Idioma();


        //private SesionSingleton instancia = SesionSingleton.Instancia;
        public idiomatest()
        {
            InitializeComponent();
        }
        public void Actualizar(IIdioma idiomaObservado)
        {
            
            foreach (Control item in this.Controls)
            {
                if (item.Tag != null)
                {
                    item.Text = idiomaObservado.BuscarTraduccion(item.Tag.ToString());
                }
            }
        }


        private void idiomatest_Load(object sender, EventArgs e)
        {


            ////////// ***** TEST IDIOMA CON DICCIONARIO BASE
            /////

            cbIdioma.DataSource = GestorIdioma.ObtenerIdiomas();
            cbIdioma.DisplayMember = "Nombre";
            //cbIdioma.ValueMember = "Id";
            //Idioma unIdioma = GestorIdioma.TraerIdiomaPorId(cbIdioma.SelectedIndex);

            //aca tengo que traer traducciones
            //List<Traduccion> traducciones = GestorIdioma.ObtenerTraducciones(unIdioma1);
       

            var _listatraducciones1 = GestorIdioma.ObtenerTraducciones(unIdioma1);
            var _listatraducciones2 = GestorIdioma.ObtenerTraducciones(unIdioma2);


            //unIdioma1.AgregarTraduccion2(_listatraducciones1);
            //unIdioma2.AgregarTraduccion2(_listatraducciones2);


            //Traducir(SesionSingleton.Instancia.idioma);

            //SesionSingleton.Instancia.CambiarIdioma(unIdioma);
            //SesionSingleton.Instancia.RegistrarObservador(this);
            //Actualizar(SesionSingleton.Instancia.idioma);
            ////////*******CIERRE TEST IDIOMA CON DICCIONARIO BASE

            /////////
            /////////
            ////PARA IDIOMA EN MEMORIA


            //GenerarDiccionarios();
            //SesionSingleton.Instancia.CambiarIdioma(unIdioma1);
            SesionSingleton.Instancia.RegistrarObservador(this);
            //Actualizar(SesionSingleton.Instancia.idioma);

            ///
            // CIERRE PARA IDIOMA EN MEMORIA
            SesionSingleton sesion = SesionSingleton.Instancia;


            //aca tuve que haber seleccionado el idioma en el form padre para cargarle a la sesion
            
            sesion.idioma.Traducciones = (GestorIdioma.ObtenerTraducciones2(sesion.idioma));
            sesion.CambiarIdioma(sesion.idioma);



            idiomatest2 form2 = new idiomatest2();
            form2.Show();

        }

        //private void Traducir(IIdioma idioma)
        //{
        //    var traducciones = GestorIdioma.ObtenerTraducciones(idioma);

        //    if (this.Tag != null && traducciones.ContainsKey(this.Tag.ToString()))
        //        this.Text = traducciones[this.Tag.ToString()].PalabraTraducida;

        //    if (label1.Tag != null && traducciones.ContainsKey(label1.Tag.ToString()))
        //        label1.Text = traducciones[label1.Tag.ToString()].PalabraTraducida;

        //    if (button1.Tag != null && traducciones.ContainsKey(button1.Tag.ToString()))
        //        button1.Text = traducciones[button1.Tag.ToString()].PalabraTraducida;


        //    if (cbIdioma.Tag != null && traducciones.ContainsKey(cbIdioma.Tag.ToString()))
        //        cbIdioma.Text = traducciones[cbIdioma.Tag.ToString()].PalabraTraducida;

        //    //    this.mnuSesion.Text = traducciones[mnuSesion.Tag.ToString()].Texto;
        //}

        //void GenerarDiccionarios()
        //{
        //    //aca debo traer lista de palabras
        //    Palabra p1 = new Palabra() { Id = 1, Texto = "TagLabelESP" };

        //    //aca debo traer lista de traducciones
        //    Traduccion t1 = new Traduccion()
        //    {
        //        IdPalabra_Traduccion = 1,
        //        Palabra_Texto = p1,
        //        PalabraTraducida = "TagLabelESP"
        //    };

        //    Traduccion t2 = new Traduccion()
        //    {
        //        IdPalabra_Traduccion = 2,
        //        Palabra_Texto = p1,
        //        PalabraTraducida = "HomeING"
        //    };

        //    Palabra p2 = new Palabra() { Id = 2, Texto = "TagBOTON" };

        //    Traduccion t3 = new Traduccion()
        //    {
        //        IdPalabra_Traduccion = 3,
        //        Palabra_Texto = p2,
        //        PalabraTraducida = "TagBOTON"
        //    };

        //    Traduccion t4 = new Traduccion()
        //    {
        //        IdPalabra_Traduccion = 4,
        //        Palabra_Texto = p2,
        //        PalabraTraducida = "ChangeING"
        //    };

        //    Palabra p3 = new Palabra() { Id = 3, Texto = "combo" };

        //    Traduccion t5 = new Traduccion()
        //    {
        //        IdPalabra_Traduccion = 5,
        //        Palabra_Texto = p3,
        //        PalabraTraducida = "combo"
        //    };

        //    Traduccion t6 = new Traduccion()
        //    {
        //        IdPalabra_Traduccion = 6,
        //        Palabra_Texto = p3,
        //        PalabraTraducida = "comboing"
        //    };

        //    unIdioma1.AgregarTraduccion(t1);
        //    unIdioma1.AgregarTraduccion(t3);
        //    unIdioma2.AgregarTraduccion(t2);
        //    unIdioma2.AgregarTraduccion(t4);
        //    unIdioma1.AgregarTraduccion(t5);
        //    unIdioma2.AgregarTraduccion(t6);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            SesionSingleton sesion = SesionSingleton.Instancia;
            //hacer todo esto con la sesion idioma
            //SesionSingleton.Instancia.idioma = (Idioma)cbIdioma.SelectedItem;
            sesion.idioma = (Idioma)cbIdioma.SelectedItem;

            //aca traer lista de traducciones en la sesion

            //sesion.idioma.Traducciones = (GestorIdioma.ObtenerTraducciones(sesion.idioma));
            //var listat = sesion.idioma.Traducciones;
            //sesion.idioma.AgregarTraduccion2(listat);

            //aca fucniona con var lista
            //var _listatraducciones3 = GestorIdioma.ObtenerTraducciones(sesion.idioma);
            //sesion.idioma.AgregarTraduccion2(_listatraducciones3);

            sesion.CambiarIdioma(sesion.idioma);

            //SesionSingleton.Instancia.CambiarIdioma(unIdioma2);

            //Idioma unIdioma = GestorIdioma.TraerIdiomaPorId(cbIdioma.SelectedIndex);
            //SesionSingleton.Instancia.CambiarIdioma(unIdioma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SesionSingleton sesion = SesionSingleton.Instancia;

            sesion.idioma = (Idioma)cbIdioma.SelectedItem;

            //sesion.idioma.Traducciones = (GestorIdioma.ObtenerTraducciones1(sesion.idioma));

            sesion.idioma.Traducciones = (GestorIdioma.ObtenerTraducciones2(sesion.idioma));
            sesion.CambiarIdioma(sesion.idioma);

        }
    }
}
