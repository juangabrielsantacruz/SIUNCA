﻿using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.D_2015.Multiidioma
{
    public class Idioma : Entity, IIdioma
    {
        public string Nombre { get; set; }

        public IList<ITraduccion> Traducciones { get; set; }
        //public bool Default { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Idioma()
        {
            Traducciones = new List<ITraduccion>();
        }
        public void AgregarTraduccion2(List<Traduccion> traduccion)
        {
            foreach (var item in traduccion)
            {
                Traducciones.Add(item);
            }
            
        }

        public string BuscarTraduccion(string texto)
        {
            try
            {
                var _resultadotraducciones = Traducciones.FirstOrDefault(x => x.Palabra_Texto == texto).PalabraTraducida;
                if (_resultadotraducciones == null)
                {
                    return texto;
                }
                else
                {
                    return _resultadotraducciones;
                }
            }
            catch (Exception)
            {

                return "sintraduccion";
            }
            
          
        }

        public void AgregarTraduccion(ITraduccion traduccion)
        {
            Traducciones.Add(traduccion);
        }
    }
}
