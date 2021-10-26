using DAL.DAOSeguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.GestoresSeguridad
{
    class DigitoVerificadorBLL
    {
        internal int TraerDVBitacora()
        {
            var digitoVerificadorDAO = new DigitoVerificadorDAO();
            return digitoVerificadorDAO.TraerDvv("Bitacora");
        }
    }
}
