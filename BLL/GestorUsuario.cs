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
using DAL.DAOSeguridad;

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
                new PermisosDAO().FillUserComponents(unUsuario);
                ManejadorSesion.Login(unUsuario);


                //no hace falta un return del usuario
                //ManejadorSesion.Login(CargarPermisos(unUsuario));

                return ManejadorSesion.GetInstancia._usuario;
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



        /// <summary>
        /// nuevo
        /// </summary>
        /// <returns></returns>
        ///  UsuariosRepository _usuarios;
        ///  
        UsuarioDAO _usuarios;
        public GestorUsuario()
        {
            _usuarios = new UsuarioDAO();
        }
        public List<Usuario> GetAll()
        {
            return _usuarios.GetAll();
        }

        public void GuardarPermisos2(Usuario u)
        {
            _usuarios.GuardarPermisos2(u);
        }

    }
}
