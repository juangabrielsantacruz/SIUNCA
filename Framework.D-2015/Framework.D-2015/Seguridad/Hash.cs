using System.Security.Cryptography;
using System.Text;

namespace Framework.D_2015.Seguridad
{
    public class Hash
    {
        public static string getSHA256(string contraseña)
        {
            var sha256 = SHA256.Create();
            var encoding = new ASCIIEncoding();
            byte[] stream = null;
            var sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(contraseña));
            for (int i = 0, loopTo = stream.Length - 1; i <= loopTo; i++)
                sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}