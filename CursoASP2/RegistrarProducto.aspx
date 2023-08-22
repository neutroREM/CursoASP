<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarProducto.aspx.cs" Inherits="CursoASP2.RegistrarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="lblMensaje" runat="server" />
        <table class="style">
            <tr>
                <td>
                    <asp:Label  runat="server" Text="ID Producto:"></asp:Label>
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="txtIdProducto" runat="server" />
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNombreProducto" Text="Nombre Producto: " runat="server" />
                    &nbsp;</td>
                <td>
                    <asp:TextBox runat="server" ID="txtNombreProducto"/>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPrecio" Text="Precio: " runat="server" />
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="txtPrecioProducto" runat="server" />
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnAgregar" text="Agregar" runat="server" OnClick="btnAgregar_Click" />
                    &nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
