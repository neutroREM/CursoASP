using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public  class CategoriaService
    {
        public List<Comun.Categoria> ObtenerCatalago()
        {
            return new AccesoDatos.CategoriaDatabase().ObtenerCategorias();
        }
    }
}
