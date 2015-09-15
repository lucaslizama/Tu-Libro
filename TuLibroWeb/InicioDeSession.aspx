<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="InicioDeSession.aspx.cs" Inherits="TuLibroWeb.InicioDeSession" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Inicio de Sesion</title>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="contenidoCentro" runat="server">
    <fieldset id="campos-login">
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="lblUser" Text="Nombre Usuario" runat="server" />
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox ID="txtUser" runat="server" />
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="lblPass" Text="Password" runat="server" />
                </asp:TableCell><asp:TableCell>
                    <asp:TextBox ID="txtPass" TextMode="Password" runat="server" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <div id="botones-login">
            <asp:Button ID="btnIniciarSesion" class="login-button" runat="server" Text="Iniciar Sesion" OnClick = "btnIniciarSesion_Click" />
            <asp:Button ID="btnRegistrarse" class="login-button" runat="server" Text="Registrarse" OnClick = "btnRegistrarse_Click" />
        </div>
    </fieldset>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="contenidoBarraDerecha" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contenidoBarraIzquierda" runat="server">
</asp:Content>