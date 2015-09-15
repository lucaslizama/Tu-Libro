<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="VistaLibro.aspx.cs" Inherits="TuLibroWeb.VistaLibro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoBarraIzquierda" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoCentro" runat="server">
    <fieldset id="fichaProducto">
        <legend>Ficha del Producto</legend>
        <div id="contenidoVistaLibro">
            <img id="thumbnailVistaLibro" class="thumbnailVistaLibro" src="~/recursos/imagenes/book-thumbnails/hg-02.jpg" alt="a" runat="server" />
            <p id="infoVistaLibro" class="infoVistaLibro" runat="server">asdd</p>
            <asp:ImageButton ID="ImageButton1" class="btnVistaLibro" runat="server" ImageUrl="recursos/imagenes/agregar.png" />
            <p id="descVistaLibro" class="descVistaLibro" runat="server">asd</p>
        </div>
    </fieldset>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoBarraDerecha" runat="server">
</asp:Content>
