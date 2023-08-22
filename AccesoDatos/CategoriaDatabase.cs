using Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{  
    public class CategoriaDatabase
    {

        public List<Comun.Categoria> ObtenerCategorias()
        {
            var context = new CategoriaLINQDataContext();
            var result = from cat in context.Categoria
                         select new Comun.Categoria
                         {
                             IdCategoria = cat.IdCategoria,
                             NombreCategoria = cat.NombreCategoria,
                             Descripcion = cat.Descripcion
                         };

            return result.ToList<Comun.Categoria>();
        }

        

    }
}
