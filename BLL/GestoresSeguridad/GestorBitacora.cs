using BIZ;
using BIZ.Seguridad;
using DAL.DAOSeguridad;
using Framework.D_2015.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.GestoresSeguridad
{

    public class GestorBitacora
    {
        public List<Bitacora2> ConsultarBitacora(DateTime unaFechaInicial, DateTime unaFechaFinal, TipoBitacora unTipoBitacora, Usuario unUsuario, string unMensaje)
        {
            List<Bitacora2> ListaBitacoras = new List<Bitacora2>();
            BitacoraDAO unaBitacoraDAO = new BitacoraDAO();


            ListaBitacoras = unaBitacoraDAO.ConsultarBitacora(unaFechaInicial, unaFechaFinal, unTipoBitacora.IdTipoBitacora, unUsuario.iduser, unMensaje);

            return ListaBitacoras;
        }

        public List<Bitacora2> ConsultarBitacora(DateTime unaFechaInicial, DateTime unaFechaFinal, TipoBitacora unTipoBitacora, Usuario unUsuario)
        {
            List<Bitacora2> ListaBitacoras = new List<Bitacora2>();
            BitacoraDAO unaBitacoraDAO = new BitacoraDAO();

            DateTime unaFI;
            DateTime unaFF;

            unaFI = Convert.ToDateTime(unaFechaInicial);
            unaFF = Convert.ToDateTime(unaFechaFinal);

            ListaBitacoras = unaBitacoraDAO.ConsultarBitacora(unaFechaInicial, unaFechaFinal, unTipoBitacora.IdTipoBitacora, unUsuario.iduser);

            return ListaBitacoras;
        }

        public List<string> TraerTodosEventos()
        {
            BitacoraDAO unaBitacoraDAO = new BitacoraDAO();

            return unaBitacoraDAO.TraerTodosEventos();
        }

        public void EliminarBitacoras(List<Bitacora2> unaListaBitacoras)
        {
            BitacoraDAO unaBitacoraDAO = new BitacoraDAO();

            unaBitacoraDAO.EliminarBitacoras(unaListaBitacoras);
        }

        public void AgregarBitacora(Usuario unUsuario, TipoBitacora unTipoBitacora, DateTime unaFechaHora, string unMensaje)
        {
            BitacoraDAO unaBitacoraDAO = new BitacoraDAO();

            // Comprobaciones
            unaBitacoraDAO.Insertar(unUsuario.iduser, unTipoBitacora.IdTipoBitacora, unaFechaHora, unMensaje);
        }

        public void AgregarBitacora(Usuario unUsuario, int unIdTipoBitacora, DateTime unaFechaHora, string unMensaje)
        {
            BitacoraDAO unaBitacoraDAO = new BitacoraDAO();

            // Comprobaciones
            unaBitacoraDAO.Insertar(unUsuario.iduser, unIdTipoBitacora, unaFechaHora, unMensaje);
        }

        public void AgregarBitacora1(int unUsuario, int unIdTipoBitacora, DateTime unaFechaHora, string unMensaje)
        {
            BitacoraDAO unaBitacoraDAO = new BitacoraDAO();

            // Comprobaciones
            unaBitacoraDAO.Insertar(unUsuario, unIdTipoBitacora, unaFechaHora, unMensaje);
        }


        public void AgregarBitacora(Bitacora2 unaBitacora)
        {
            BitacoraDAO unaBitacoraDAO = new BitacoraDAO();

            // Comprobaciones

            unaBitacoraDAO.Insertar(unaBitacora);
        }
    }


}
