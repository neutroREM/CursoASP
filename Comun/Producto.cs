using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }  
        public decimal Precio{ get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaExpiracion{ get; set; }
        public int IdCategoria { get; set; }

        public Producto(int IdProducto, string NombreProducto, decimal Precio)
        {
            this.IdProducto = IdProducto;
            this.NombreProducto = NombreProducto;
            this.Precio = Precio;
        }

        public Producto() { }


    }
}
