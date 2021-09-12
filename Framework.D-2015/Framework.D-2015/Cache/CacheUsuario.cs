
namespace Framework.D_2015.Cache
{
    /// <summary>
    /// Clase estatica para guardar los datos del usuario de forma temporal en memoria,
    /// una vez se que la aplicacion se cierra no guarda los datos
    /// </summary>
    public class CacheUsuario
    {
        public static int iduser;
        public static string username;
        public static string password;
        public static string email;
        public static string rol;
    }
}