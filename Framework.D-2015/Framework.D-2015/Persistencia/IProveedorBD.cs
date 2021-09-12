using System.Collections.Generic;

namespace Framework.D_2015.Persistencia
{
    public interface IProveedorBD
    {
        void ConexionIniciar();
        void ConexionFinalizar();
        void TransaccionIniciar();
        void TransaccionAceptar();
        void TransaccionCancelar();
        void EjecutarSinResultado(string query, List<Parametro> parametros);
        T EjecutarEscalar<T>(string query, List<Parametro> parametros);
        List<T> EjecutarTupla<T>(string query, List<Parametro> parametros) where T : new();
    }
}