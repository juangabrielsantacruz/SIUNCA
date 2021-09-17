using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Framework.D_2015.Serializadores
{
    public class SerializadorXml : ISerializador
    {
        public string Serializar(object unObjeto)
        {
            var xmlSerializer = new XmlSerializer(unObjeto.GetType());
            var ms = new MemoryStream();
            xmlSerializer.Serialize(ms, unObjeto);
            return Cadenas.StreamACadena(ms);
        }

        public T Deserealizar<T>(string unObjetoSerializadoEnXml) where T : new()
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            var resultado = xmlSerializer.Deserialize(new MemoryStream(Cadenas.CadenaABytes(unObjetoSerializadoEnXml)));
            return (T)resultado;
        }
    }
}