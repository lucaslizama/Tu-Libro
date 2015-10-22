<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="CarritoDeCompras.aspx.cs" Inherits="TuLibroWeb.CarritoDeCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoBarraIzquierda" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoCentro" runat="server">
    <label id="errorLabel" class="errorLabel" runat="server"></label>
    <div id="contenedorInfoCarro" class="cart-info" runat="server"> 
        <ol id="listaProductos" runat="server">
            
        </ol>
        <asp:Button ID="btnComprar" class="btnComprar" runat="server" Text="Comprar" 
            onclick="btnComprar_Click" />
        <asp:Button ID="btnVaciar" class="btnVaciar" runat="server" Text="Vaciar" 
            onclick="btnVaciar_Click" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoBarraDerecha" runat="server">
</asp:Content>
