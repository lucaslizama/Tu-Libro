<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TuLibroWeb.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Bienvenido a Tu Libro</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoBarraIzquierda" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoCentro" runat="server">
    <fieldset id="contenedor-buscador" title="sadasd">
        <legend>Buscar Libros</legend>
        <asp:Label ID="lblBuscar" runat="server" Text="Buscar por:" />
        <asp:DropDownList ID="ddlBuscador" runat="server">
            <asp:ListItem>Palabra Clave</asp:ListItem>
            <asp:ListItem>Titulo</asp:ListItem>
            <asp:ListItem>Autor</asp:ListItem>
            <asp:ListItem>ISBN</asp:ListItem>
            <asp:ListItem>Editorial</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtBuscador" runat="server" Width="350px"/>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Width="100px" class="search-button"/>
        <div id="librosRecomendados">
            <div class="libro-recomendado">
                <img id="imgLibroRec1" class="thumbnail" runat="server" src="recursos/imagenes/book-thumbnails/07.jpg" alt="Libro Recomendado 1"/>
                <p id="infoLibroRec1" class="info-libro" runat="server"></p>
                <p id="desclibrorec1" class="desc-libro" runat="server"></p>
            </div>
            <div class="libro-recomendado">
                <img id="imgLibroRec2" class="thumbnail" runat="server" src="recursos/imagenes/book-thumbnails/08.jpg" alt="Libro Recomendado 2"/>
                <p id="infoLibroRec2" class="info-libro" runat="server"></p>
                <p id="desclibrorec2" class="desc-libro" runat="server"></p>
            </div>
            <div class="libro-recomendado">
                <img id="imgLibroRec3" class="thumbnail" runat="server" src="recursos/imagenes/book-thumbnails/11.jpg" alt="Libro Recomendado 3"/>
                <p id="infoLibroRec3" class="info-libro" runat="server" ></p>
                <p id="desclibrorec3" class="desc-libro" runat="server"></p>
            </div>
            <div class="libro-recomendado">
                <img id="imgLibroRec4" class="thumbnail" runat="server" src="recursos/imagenes/book-thumbnails/13.jpg" alt="Libro Recomendado 4"/>
                <p id="infoLibroRec4" class="info-libro" runat="server"></p>
                <p id="desclibrorec4" class="desc-libro" runat="server"></p>
            </div>
        </div>
    </fieldset>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoBarraDerecha" runat="server">
</asp:Content>