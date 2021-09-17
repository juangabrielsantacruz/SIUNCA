//using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Framework.D_2015.Generadores
{
    public class GeneradorXML
    {

        public  void GeneradorXMLDBConfig(string tipodb, string server, string catalogo, string usuario, string contraseña)
        {
            XmlWriter documentoXml;

            // Recopilar informacion del documento "configuraciones".
            XmlWriterSettings configuracionXml = new XmlWriterSettings();
            //configuracionXml.Indent = 2;
            configuracionXml.Indent = true;

            // Creo el documento.
            //implementar using vb para usar funcion de linea de abajo
            //documentoXml = XmlWriter.Create(FileSystem.CurDir() + @"\config.xml", configuracionXml);
            //reever donde se gaurda el xml
            documentoXml = XmlWriter.Create("configg.xml", configuracionXml);

            documentoXml.WriteStartDocument(true);

            documentoXml.WriteStartElement("Configuracion");

            //mirar orden de pametros
            documentoXml.WriteElementString("Tipo", tipodb);
            documentoXml.WriteElementString("Server", server);
            documentoXml.WriteElementString("Catalogo", catalogo);
            documentoXml.WriteElementString("Usuario", usuario);
            documentoXml.WriteElementString("Contraseña", contraseña);

            documentoXml.WriteEndElement(); // Cierro Configuracion

            documentoXml.WriteEndDocument();
            documentoXml.Close();
        }

        public static void GeneradorXMLDBConfig(string tipodb, string server, string catalogo)
        {
            XmlWriter documentoXml;

            // Recopilar informacion del documento "configuraciones".
            XmlWriterSettings configuracionXml = new XmlWriterSettings();
            //configuracionXml.Indent = 2;
            configuracionXml.Indent = true;

            // Creo el documento.
            //implementar using vb para usar funcion de linea de abajo
            //documentoXml = XmlWriter.Create(FileSystem.CurDir() + @"\config.xml", configuracionXml);
            //reever donde se gaurda el xml
            documentoXml = XmlWriter.Create("configg.xml", configuracionXml);

            documentoXml.WriteStartDocument(true);

            documentoXml.WriteStartElement("ConexionBD");

            documentoXml.WriteElementString("Tipo", tipodb);
            documentoXml.WriteElementString("Server", server);
            documentoXml.WriteElementString("Catalogo", catalogo);

            documentoXml.WriteEndElement(); // Cierro Configuracion

            documentoXml.WriteEndDocument();
            documentoXml.Close();
        }
    }
}
