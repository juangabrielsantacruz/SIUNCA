﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.D_2015.Multiidioma;
using Framework.D_2015.Persistencia;
using Interfaces;

namespace BIZ.Seguridad
{
    public class ManejadorSesion : IObservado
    {
        //deberia hacer esta clase en el FRAMEWORK?
        private static ManejadorSesion _instancia;
        public Usuario usuario { get; set; }
        public DateTime FechaInicio { get; set; }
        public static ManejadorSesion GetInstancia
        {
            get
            {
                if (_instancia == null)
                {
                    throw new Exception("Sesión no iniciada");
                    //_instancia = new ManejadorSesion();
                }  
                return _instancia;
            }
        }

        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        public static void Login(Usuario usuario)
        {
            if (_instancia == null)
            {
                _instancia = new ManejadorSesion();
                _instancia.usuario = usuario;
                _instancia.FechaInicio = DateTime.Now;
            }
            else
            {
                throw new Exception("Sesión ya iniciada");
            }
        }
        public static bool IsLogged()
        {
             return _instancia != null;
            
        }
        public static void Logout()
        {
            if (_instancia != null)
            {
                _instancia = null;
            }
            else
            {
                throw new Exception("Sesión no iniciada");
            }            
        }



        /* MULTIIDIOMA */

        public Idioma idioma { get; set; }
        public IList<IObservador> ObservadoresRegistrados { get; set; }

        private ManejadorSesion()
        {
            ObservadoresRegistrados = new List<IObservador>();
        }
        public void CambiarIdioma(Idioma i)
        {
            idioma = i;
            ActualizarObservadores(i);
        }

        public void ActualizarObservadores(IIdioma idioma)
        {
            foreach (var item in ObservadoresRegistrados)
            {
                item.Actualizar(idioma);                
            }
        }

        public void DesregistrarObservador(IObservador observador)
        {
            ObservadoresRegistrados.Remove(observador);
        }

        public void RegistrarObservador(IObservador observador)
        {
            ObservadoresRegistrados.Add(observador);
        }

   
    }
}