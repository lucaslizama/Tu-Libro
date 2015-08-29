<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="InicioDeSession.aspx.cs" Inherits="TuLibroWeb.InicioDeSession" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="botonesBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoBarraIzquierda" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoCentro" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="contenidoBarraDerecha" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="Mas_Vendidos" runat="server">
    <div>   
        <center>
            <asp:Table runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblUsuarioSession" Text="Nombre Usuario" runat="server" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtNombreUsuarioSession" runat="server" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red"
                        ErrorMessage=" * Ingrese un Usuario " ControlToValidate="TxtNombreUsuarioSession"
                        ID="RfcNombreUsuarioSession" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </center>
    </div>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="Recomendados" runat="server">
</asp:Content>