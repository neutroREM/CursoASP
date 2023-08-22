<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObtenerProductos.aspx.cs" Inherits="CursoASP2.ObtenerProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-4">
                <asp:Label ID="lblId" Text="Buscar ID" runat="server" />
                <asp:TextBox runat="server" ID="txtIdProducto" />
            </div>
            <div class="col-auto">
                 <asp:Button ID="btnBuscar" Text="Buscar" runat="server" OnClick="btnBuscar_Click" />
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-6">
                <asp:GridView runat="server" ID="gvProductoBuscar" AutoGenerateColumns="true">

                </asp:GridView>
            </div>
        </div>
        <div class="row">
            <asp:Label runat="server" ID="lblMensaje"/>
        </div>
        <div class="row">
            <div class="col-3">
                <asp:Label Text="Producto" runat="server" ID="lblProducto"/>
                <asp:TextBox runat="server" ID="txtNombreProducto" />
                <asp:Button Text="Modificar" runat="server" ID="btnModificar" OnClick="btnModificar_Click" />
                <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" OnClick="btnEliminar_Click"/>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-12">
                <asp:GridView runat="server" ID="gvProductos" DataSourceID="odsProductos" AutoGenerateColumns="False" RowStyle-BorderStyle="Solid">
                    <Columns>
                        <asp:BoundField DataField="IdProducto" HeaderText="Id" SortExpression="IdProducto" ItemStyle-HorizontalAlign="Left"></asp:BoundField>
                        <asp:BoundField DataField="NombreProducto" HeaderText="NombreProducto" SortExpression="NombreProducto" ItemStyle-HorizontalAlign="Left"></asp:BoundField>
                        <asp:BoundField DataField="PrecioProducto" HeaderText="Precio" SortExpression="PrecioProducto" ItemStyle-HorizontalAlign="Right"></asp:BoundField>
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource runat="server" ID="odsProductos" SelectMethod="ObtenerProductos" TypeName="Logica.ProductoService"></asp:ObjectDataSource>
            </div>
        </div>
    </div>
</asp:Content>
