
namespace Framework.D_2015.Persistencia
{
    public class Parametro
    {
        public Parametro(string nombreParametro, object valor)
        {
            NombreParametro = nombreParametro;
            Valor = valor;
        }

        public string NombreParametro { get; set; }
        public object Valor { get; set; }
    }
}