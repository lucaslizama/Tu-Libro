<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="TuLibroWeb.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Bienvenido a tu Perfil</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoBarraIzquierda" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoCentro" runat="server">
    <div>
        <asp:TextBox ID="txtInfo" runat="server" TextMode="MultiLine" Enabled="false" 
        Text="" Width="300px" Height="300px" />
        <div>
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="btnModificar" runat="server" OnClick="btnModificarPerfil_Click"
                    Text="Modificar Perfil" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
        <br />
        <a href="Inicio.aspx">Volver a Inicio</a>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoBarraDerecha" runat="server">
    
</asp:Content>
