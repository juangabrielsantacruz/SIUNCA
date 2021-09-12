using System.IO;

namespace Framework.D_2015.Funciones
{
    public class Archivo
    {
        public static void GuardarEnString(string ruta, string contenido)
        {
            StreamWriter escritor;
            escritor = File.AppendText(ruta);
            escritor.Write(contenido);
            escritor.Flush();
            escritor.Close();
        }
    }
}