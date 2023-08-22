 using Comun;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ProductoDatabaseSettings
    {

        public List<Comun.Producto> BuscarXCategoria(int IdCategoria)
        {
            var context = new CategoriaLINQDataContext();
            var result = from product in context.Producto
                         where product.IdCategoria == IdCategoria
                         orderby product.IdProducto
                         select new Comun.Producto
                         {
                             IdCategoria = (int)product.IdCategoria,
                             IdProducto = product.IdProducto,
                             NombreProducto = product.NombreProducto,
                             Precio = (decimal)product.Precio
                         };
            return result.ToList<Comun.Producto>();
        }

        public List<Comun.Producto> BuscarXPrecio(int IdCategoria, decimal Precio)
        {
            var context = new CategoriaLINQDataContext();
            var result = from product in context.Producto
                         where product.IdCategoria == IdCategoria &&
                         product.Precio >= Precio
                         orderby product.IdProducto
                         select new Comun.Producto
                         {
                             IdCategoria = (int)product.IdCategoria,
                             IdProducto = product.IdProducto, 
                             NombreProducto = product.NombreProducto,
                             Precio = (decimal)product.Precio
                         };
            return result.ToList<Comun.Producto>();

        }

        public List<int> BuscarCatXPrecioUnico(int IdCategoria)
        {
            var context = new CategoriaLINQDataContext();
            var result = from product in context.Producto
                         where product.IdCategoria == IdCategoria
                         group product by Convert.ToInt32(product.Precio.Value)
                         into Grupo
                         select Convert.ToInt32(Grupo.Key);
            return result.ToList<int>();
        }



        public bool InsertarLinQ(Comun.Producto producto)
        {
            bool result = true;
            //var dc = new ProductoLINQDataContext;
            //var ri =producto.IdProducto, producto.NombreProducto);

            //var res = ri.FirstOrDefault<msp_InsertarResult>();
            //result = res.RegistrosInsertados == 1;

            return result;

        }

        public List<Producto> ObtenerCatalagoProductos()
        {
            var dc = new ProductoLINQDataContext();

            var result = from en in dc.Producto
                         select new Producto
                         {
                             IdProducto = en.IdProducto,
                             NombreProducto = en.NombreProducto
                         };

            return result.ToList<Producto>();
        
        }

        public bool Insertar(Comun.Producto producto)
        {
            bool Resultado = false;
            SqlConnection stringConnection = new SqlConnection();
            stringConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=abarrotes;Integrated Security=True";
            stringConnection.Open();

            SqlCommand stringCommand = new SqlCommand();
            stringCommand.Connection = stringConnection;
            stringCommand.CommandType = System.Data.CommandType.Text;
            stringCommand.CommandText = "INSERT INTO Producto(IdProducto, NombreProducto, Precio) Values(@IdProducto, @NombreProducto, @Precio)";
            stringCommand.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
            stringCommand.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
            stringCommand.Parameters.AddWithValue("@Precio", producto.Precio);


            int rn = stringCommand.ExecuteNonQuery();
            if (rn == 1)
            {
                Resultado = true;
            }
            stringConnection.Close();
            stringConnection.Dispose();
            return Resultado;
        }

        public List<Comun.Producto> ObtenerProductos() 
        {
            SqlConnection stringConnection = new SqlConnection();
            stringConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=abarrotes;Integrated Security=True";
            stringConnection.Open();

            SqlCommand stringCommand = new SqlCommand();
            stringCommand.Connection = stringConnection;
            stringCommand.CommandType = System.Data.CommandType.Text;
            stringCommand.CommandText = "SELECT * FROM Producto";


            //DataReader es un objeto ADO que permite trabajar de forma conectada
            var resultado = new List<Comun.Producto>();
            var drProductos = stringCommand.ExecuteReader();
            while (drProductos.Read())
            {
                resultado.Add(new Comun.Producto(drProductos.GetInt32(0), drProductos.GetString(1), drProductos.GetDecimal(2)));
            }

            stringConnection.Close();

            return resultado;

        }

        public List<Comun.Producto> ObtenerProductoXId(int IdProducto)
        {
            SqlConnection stringConnection = new SqlConnection();
            stringConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=abarrotes;Integrated Security=True";
            stringConnection.Open();

            SqlCommand stringCommand = new SqlCommand();
            stringCommand.Connection = stringConnection;
            stringCommand.CommandType = System.Data.CommandType.Text;
            stringCommand.CommandText = "SELECT IdProducto, NombreProducto, Precio FROM Producto WHERE IdProducto = @IdProducto";
            stringCommand.Parameters.AddWithValue("@IdProducto", IdProducto);


            //DataReader es un objeto ADO que permite trabajar de forma conectada
            var resultado = new List<Comun.Producto>();
            var drProductos = stringCommand.ExecuteReader();
            while (drProductos.Read())
            {
                resultado.Add(new Comun.Producto(drProductos.GetInt32(0), drProductos.GetString(1), drProductos.GetDecimal(2)));
            }

            stringConnection.Close();

            return resultado;

        }


        public string BuscarXID(int IdProducto)
        {
            SqlConnection stringConnection = new SqlConnection();
            stringConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=abarrotes;Integrated Security=True";
            stringConnection.Open();

            SqlCommand stringCommand = new SqlCommand();
            stringCommand.Connection = stringConnection;
            stringCommand.CommandType = System.Data.CommandType.Text;
            stringCommand.CommandText = "SELECT NombreProducto FROM Producto WHERE IdProducto = @IdProducto";
            stringCommand.Parameters.AddWithValue("@IdProducto", IdProducto);


            var resultado = stringCommand.ExecuteScalar().ToString(); 

            stringConnection.Close();
            return resultado;
        }

        public bool Modificar(Comun.Producto producto)
        {
            bool Resultado = false;
            SqlConnection stringConnection = new SqlConnection();
            stringConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=abarrotes;Integrated Security=True";
            stringConnection.Open();

            SqlCommand stringCommand = new SqlCommand();
            stringCommand.Connection = stringConnection;
            stringCommand.CommandType = System.Data.CommandType.Text;
            stringCommand.CommandText = "UPDATE Producto SET NombreProducto = @NombreProducto WHERE IdProducto = @IdProducto";
            stringCommand.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
            stringCommand.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);


            int rn = stringCommand.ExecuteNonQuery();
            if (rn == 1)
            {
                Resultado = true;
            }
            stringConnection.Close();
            stringConnection.Dispose();
            return Resultado;
        }

        public bool Eliminar(int IdProducto)
        {
            bool Resultado = false;
            SqlConnection stringConnection = new SqlConnection();
            stringConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=abarrotes;Integrated Security=True";
            stringConnection.Open();

            SqlCommand stringCommand = new SqlCommand();
            stringCommand.Connection = stringConnection;
            stringCommand.CommandType = System.Data.CommandType.Text;
            stringCommand.CommandText = "DELETE Producto WHERE IdProducto = @IdProducto";

            stringCommand.Parameters.AddWithValue("@IdProducto", IdProducto);


            int rn = stringCommand.ExecuteNonQuery();
            if (rn == 1)
            {
                Resultado = true;
            }
            stringConnection.Close();
            stringConnection.Dispose();
            return Resultado;
        }
    }
}
