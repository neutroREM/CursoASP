using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class Categoria
    {
        public int? IdCategoria { get; set; }    
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        //public Categoria(int IdCategoria, string NombreCategoria, string Descripcion)
        //{
        //    this.IdCategoria = IdCategoria;
        //    this.NombreCategoria = NombreCategoria; 
        //    this.Descripcion = Descripcion;
        //}
    }
}
