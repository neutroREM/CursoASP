using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CursoASP2
{
    public partial class BuscarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var lsObtenerCatalagoCategorias = new Logica.CategoriaService();
                ddlCategorias.DataSource = lsObtenerCatalagoCategorias.ObtenerCatalago();
                ddlCategorias.DataTextField = "NombreCategoria";
                ddlCategorias.DataValueField = "IdCategoria";
                ddlCategorias.DataBind();
            }
            lblFPB.Text = DateTime.Now.ToLongTimeString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblGrid.Text = DateTime.Now.ToLongTimeString();
        }

        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void ddlCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Thread.Sleep(2000);
            var lsProductos = new Logica.ProductoService();

            ddlPrecios.DataSource = lsProductos.BuscarPrecio(int.Parse(ddlCategorias.SelectedValue));
            ddlPrecios.DataBind();
        }

        protected void ddlPrecios_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lsProductos = new Logica.ProductoService();
            gvProductos.DataSource = lsProductos.BuscarXPrecio(int.Parse(ddlCategorias.SelectedValue),
                decimal.Parse(ddlPrecios.Text));
            gvProductos.DataBind();
        }
    }
}