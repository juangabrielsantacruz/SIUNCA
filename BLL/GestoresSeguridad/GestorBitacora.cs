using BIZ;
using BIZ.Seguridad;
using DAL.DAOSeguridad;
using Framework.D_2015.Cache;
using Framework.D_2015.DigitoVerificador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.GestoresSeguridad
{

    public class GestorBitacora
    {
        BitacoraDAO unaBitacoraDAO = new BitacoraDAO();
        public List<Bitacora2> ConsultarBitacora(DateTime unaFechaInicial, DateTime unaFechaFinal, TipoBitacora unTipoBitacora, Usuario unUsuario, string unMensaje)
        {
            List<Bitacora2> ListaBitacoras = new List<Bitacora2>();


            ListaBitacoras = unaBitacoraDAO.ConsultarBitacora(unaFechaInicial, unaFechaFinal, unTipoBitacora.IdTipoBitacora, unUsuario.iduser, unMensaje);

            return ListaBitacoras;
        }

        public List<Bitacora2> ConsultarBitacora(DateTime unaFechaInicial, DateTime unaFechaFinal, TipoBitacora unTipoBitacora, Usuario unUsuario)
        {
            List<Bitacora2> ListaBitacoras = new List<Bitacora2>();

            DateTime unaFI;
            DateTime unaFF;

            unaFI = Convert.ToDateTime(unaFechaInicial);
            unaFF = Convert.ToDateTime(unaFechaFinal);

            ListaBitacoras = unaBitacoraDAO.ConsultarBitacora(unaFechaInicial, unaFechaFinal, unTipoBitacora.IdTipoBitacora, unUsuario.iduser);

            return ListaBitacoras;
        }

        public List<string> TraerTodosEventos()
        {

            return unaBitacoraDAO.TraerTodosEventos();
        }

        public void EliminarBitacoras(List<Bitacora2> unaListaBitacoras)
        {
            unaBitacoraDAO.EliminarBitacoras(unaListaBitacoras);
        }

        public void AgregarBitacora(Usuario unUsuario, TipoBitacora unTipoBitacora, DateTime unaFechaHora, string unMensaje)
        {       
            unaBitacoraDAO.Insertar(unUsuario.iduser, unTipoBitacora.IdTipoBitacora, unaFechaHora, unMensaje);
        }

        public List<Bitacora2> ConsultarBitacora2(DateTime unaFechaInicial, DateTime unaFechaFinal, TipoBitacora unTipoBitacora, Usuario unUsuario, string unMensaje)
        {
            List<Bitacora2> ListaBitacoras = new List<Bitacora2>();

            DateTime unaFI;
            DateTime unaFF;

            unaFI = Convert.ToDateTime(unaFechaInicial);
            unaFF = Convert.ToDateTime(unaFechaFinal);
            try
            {
                var digitoVerificadorBLL = new DigitoVerificadorBLL();
                var digitoVerificador = new DigitoVerificador();
                var a = digitoVerificadorBLL.TraerDVBitacora();
                var j = TraerCadenaDv();
                var b = digitoVerificador.calcularDV(j);
                if (a == b)
                {                   
                    ListaBitacoras = unaBitacoraDAO.ConsultarBitacora(unaFechaInicial, unaFechaFinal, unTipoBitacora.IdTipoBitacora, unUsuario.iduser);
                    return ListaBitacoras;                    
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return default;
        }
        public List<Bitacora2> ConsultarBitacora3(DateTime unaFechaInicial, DateTime unaFechaFinal, TipoBitacora unTipoBitacora, Usuario unUsuario, string unMensaje)
        {
            List<Bitacora2> ListaBitacoras = new List<Bitacora2>();

            DateTime unaFI;
            DateTime unaFF;

            unaFI = Convert.ToDateTime(unaFechaInicial);
            unaFF = Convert.ToDateTime(unaFechaFinal);

            ListaBitacoras = unaBitacoraDAO.ConsultarBitacora(unaFechaInicial, unaFechaFinal, unTipoBitacora.IdTipoBitacora, unUsuario.iduser);
            foreach (var item in ListaBitacoras)
            {
                string dv;
                dv = item.IdUsuario.ToString() + item.IdTipoBitacora.ToString() + item.Mensaje.ToString();

                var digitoVerificador = new DigitoVerificador();
                bool resultado = digitoVerificador.VerificarDV(dv, item.dv);
                if (resultado != true)
                {
                    throw new Exception("error digito verificador"); 
                }
            }
            return ListaBitacoras;
            
        }

        private string TraerCadenaDv()
        {
            var unaBitacoraDAO = new BitacoraDAO();
            return unaBitacoraDAO.TraerCadenaDv();
        }

        public void AgregarBitacora(Usuario unUsuario, int unIdTipoBitacora, DateTime unaFechaHora, string unMensaje)
        {
            // Comprobaciones
            unaBitacoraDAO.Insertar(unUsuario.iduser, unIdTipoBitacora, unaFechaHora, unMensaje);
        }

        public void AgregarBitacora1(int unUsuario, int unIdTipoBitacora, DateTime unaFechaHora, string unMensaje)
        {
            // Comprobaciones
            unaBitacoraDAO.Insertar(unUsuario, unIdTipoBitacora, unaFechaHora, unMensaje);
        }


        public void AgregarBitacora(Bitacora2 unaBitacora)
        {
            // Comprobaciones
            string dv;
            dv = unaBitacora.IdUsuario.ToString() + unaBitacora.IdTipoBitacora.ToString() + unaBitacora.Mensaje;
            var digitoVerifidor = new DigitoVerificador();
            unaBitacora.dv = digitoVerifidor.calcularDV(dv);
            

            ActualizarDvv();
            unaBitacoraDAO.Insertar(unaBitacora);
        }
        public void ActualizarDvv()
        {
            var digitoVerificador = new DigitoVerificador();

            var digitoVerificadorDAO = new DigitoVerificadorDAO();
            digitoVerificadorDAO.ActualizarDvv("Bitacora", digitoVerificador.calcularDV(unaBitacoraDAO.TraerCadenaDv()));
        }
    }
   

}
