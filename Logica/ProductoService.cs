using AccesoDatos;
using Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ProductoService
    {
        public List<Comun.Producto> BuscarXCategoria(int IdCategoria)
        {
            return new AccesoDatos.ProductoDatabaseSettings().BuscarXCategoria(IdCategoria);
        }

        public List<Comun.Producto> BuscarXPrecio(int IdCategoria, decimal precio)
        {
            return new AccesoDatos.ProductoDatabaseSettings().BuscarXPrecio(IdCategoria, precio);
        }

        public List<int> BuscarPrecio(int IdCategoria)
        {
            return new AccesoDatos.ProductoDatabaseSettings().BuscarCatXPrecioUnico(IdCategoria);
        }


        public bool Insertar(Comun.Producto producto)
        {
            bool result = false;
            if (producto != null)
            {
                if (producto.IdProducto > 0)
                {
                    if (!string.IsNullOrEmpty(producto.NombreProducto) || producto.Precio != 0 )
                    {
                        ProductoDatabaseSettings productoDBS = new ProductoDatabaseSettings();
                        return  productoDBS.InsertarLinQ(producto);

                    }
                }
            }
            return result;
        }

        //public List<Comun.Producto> ObtenerProductos() 
        //{
        //    ProductoDatabaseSettings productoDBS = new ProductoDatabaseSettings();
        //    return productoDBS.ObtenerCatalagoProductos();
        //}



        public List<Comun.Producto> ObtenerProductos(int IdProducto)
        {
            ProductoDatabaseSettings productoDBS = new ProductoDatabaseSettings();
            return productoDBS.ObtenerProductoXId(IdProducto);
        }



        public string BuscarXID(int IdBuscarXID) 
        {
            ProductoDatabaseSettings productsDBS = new ProductoDatabaseSettings();
            return productsDBS.BuscarXID(IdBuscarXID);

        }

        public bool ModificarProducto(Comun.Producto producto)
        {
            ProductoDatabaseSettings productoDBS = new ProductoDatabaseSettings();
            bool result = productoDBS.Modificar(producto);
            return result;
        }

        public bool EliminarProducto(int IdUsuario)
        {
            ProductoDatabaseSettings productoDBS = new ProductoDatabaseSettings();
            bool result = productoDBS.Eliminar(IdUsuario);

            return result;
        }
    }
}
