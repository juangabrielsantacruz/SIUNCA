
namespace Framework.D_2015
{
    public interface ISerializador
    {
        string Serializar(object unObjeto);
        T Deserealizar<T>(string unObjetoSerializadoEnXml) where T : new();
    }
}