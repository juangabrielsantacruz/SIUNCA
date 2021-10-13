using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInicio());
            //Application.Run(new FormPrueba());
            //Application.Run(new Login());
            //Application.Run(new idiomatest());
            //Application.Run(new frmProfesor());
            //Application.Run(new frmSecretarioAcademico());
            Application.Run(new frmSeguridad());
        }
    }
}
