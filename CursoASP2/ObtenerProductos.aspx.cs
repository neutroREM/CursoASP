using Comun;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CursoASP2
{
    public partial class ObtenerProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ProductoService productoService = new ProductoService();
            gvProductoBuscar.DataSource = productoService.ObtenerProductos(int.Parse(txtIdProducto.Text));
            gvProductoBuscar.DataBind();

            txtNombreProducto.Text = productoService.BuscarXID(int.Parse(txtIdProducto.Text));
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            ProductoService productoService = new ProductoService();
            bool result = productoService.ModificarProducto(new Comun.Producto(int.Parse(txtIdProducto.Text), txtNombreProducto.Text, decimal.Parse("1")));

            if (result)
                lblMensaje.Text = "Producto Modificado";
            else
                lblMensaje.Text = "Error al modificar el Producto";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductoService productoService = new ProductoService();
            bool result = productoService.EliminarProducto(int.Parse(txtIdProducto.Text));

            if (result)
                lblMensaje.Text = "Producto eliminado";
            else
                lblMensaje.Text = "Error al eliminar Producto";
        }
    }
}