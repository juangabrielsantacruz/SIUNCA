using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAOSeguridad
{
    public interface ICRUD<T>
    {

        bool Agregar(T t);

        bool Modificar(T t);

        bool Eliminar(T t);

        List<T> Listar();
    }
}
