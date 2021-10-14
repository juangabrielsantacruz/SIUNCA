using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BIZ;
using Framework.D_2015.Cache;
using BIZ.Seguridad;
using Framework.D_2015.Seguridad;
using BLL.GestoresSeguridad;

namespace BLL
{
    public class GestorUsuario
    {
        UsuarioDAO unUsuarioDAO = new UsuarioDAO();


        public Usuario IniciarSesion(Usuario usuario)
        {
            if (ManejadorSesion.IsLogged())
            { 
                throw new Exception("Ya hay una sesión iniciada");
            }

            usuario.password = Hash.getSHA256(usuario.password);
            var unUsuario = unUsuarioDAO.traerUsuario(usuario);
            
            if (unUsuario == null)
            {
                throw new Exception("crednediales invalidas// faltan crear excepciones");
            }
            else
            {
                ManejadorSesion.Login(CargarPermisos(unUsuario));
                return ManejadorSesion.GetInstancia.usuario;
            }               

        }

        public void eliminarUsuario(int idUsuario)
        {
            unUsuarioDAO.eliminar(idUsuario);
        }

        public void guardarUsuario(Usuario unUsuario)
        {        
            unUsuarioDAO.insertarUsuario(unUsuario);

        }

        public List<Usuario> TraerTodo()
        {
            return unUsuarioDAO.TraerTodo();
        }

        public Usuario CargarPermisos(Usuario unUsuario)
        {
            // Logueo (traigo perfil) del Usuario
            return unUsuarioDAO.TraerPermisos(unUsuario);
        }

        public void GuardarPermisos(Usuario unUsuario)
        {
            unUsuarioDAO.GuardarPermisos(unUsuario);
        }


    }
}
