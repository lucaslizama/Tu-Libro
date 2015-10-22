<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="TuLibroWeb.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Bienvenido a tu Perfil</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoBarraIzquierda" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoCentro" runat="server">
    <fieldset id="contenedorPerfil">
        <legend>Bienvenido a tu Perfil</legend>
        <p id="txtPerfil" class="txtInfoPerfil" runat="server"></p>
        <asp:Button ID="btnModificar" class="btnModificarPerfil" runat="server" OnClick="btnModificarPerfil_Click"
        Text="Modificar Perfil" />
    </fieldset>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoBarraDerecha" runat="server">
    
</asp:Content>
