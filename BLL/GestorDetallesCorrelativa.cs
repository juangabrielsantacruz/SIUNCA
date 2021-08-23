using System;
using BIZ;
using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class GestorDetallesCorrelativa
    {
      

        public List<DetallesCorrelativa> TraerListaCorrelativas(MateriaConCorrelativas unaMateriaCC)
        {
            List<DetallesCorrelativa> ListaCorrelativas = new List<DetallesCorrelativa>();
            DetalleCorrelativaDAO unDetalleCorrelativaDAO = new DetalleCorrelativaDAO();           
            ListaCorrelativas = unDetalleCorrelativaDAO.TraerTodo(unaMateriaCC);
         
            //comentando
            return ListaCorrelativas;
        }


      
    }
}