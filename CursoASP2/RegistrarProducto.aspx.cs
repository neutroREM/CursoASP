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
    public partial class RegistrarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            ProductoService productoService = new ProductoService();
            Producto producto = new Producto(Convert.ToInt32(txtIdProducto.Text), txtNombreProducto.Text, Convert.ToDecimal(txtPrecioProducto.Text));
            bool resultado = productoService.Insertar(producto);
            
            if (resultado)
            {
                lblMensaje.Text = "Producto Registrado";
            }
            else
            {
                lblMensaje.Text = "Producto No Registrado, error durante el proceso";
            }
        }
    }
}