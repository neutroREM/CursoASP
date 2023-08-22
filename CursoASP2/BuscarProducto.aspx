<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuscarProducto.aspx.cs" Inherits="CursoASP2.BuscarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <asp:Label ID="lblFPB" runat="server" Text="lbl1" />
        <asp:UpdatePanel runat="server" ID="upHora" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label runat="server" ID="lblHora" Text=" " />
                <br />
                <%-- AutoPosback: Cargar información sin que la página realice un postback --%>
                <asp:DropDownList runat="server" ID="ddlCategorias" AutoPostBack="true" Height="46px" Width="466px" OnSelectedIndexChanged="ddlCategorias_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:UpdateProgress ID="upProgreso" runat="server">
                    <ProgressTemplate>
                        Buscando datos ...
                    </ProgressTemplate>
                </asp:UpdateProgress>
                <br />
                <asp:DropDownList runat="server" ID="ddlPrecios" AutoPostBack="true" Height="46px" Width="466px" OnSelectedIndexChanged="ddlPrecios_SelectedIndexChanged">
                </asp:DropDownList>

            </ContentTemplate>
        </asp:UpdatePanel>

        <asp:UpdatePanel runat="server" ID="upProductos" UpdateMode="Conditional">
            <ContentTemplate>
                 <asp:Label runat="server" ID="lblGrid" Text=" " />
                <asp:GridView runat="server" ID="gvProductos" OnSelectedIndexChanged="gvProductos_SelectedIndexChanged">
                </asp:GridView>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="ddlPrecios" EventName="SelectedIndexChanged" />
            </Triggers>
        </asp:UpdatePanel>

    </main>
</asp:Content>
