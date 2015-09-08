<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="InicioDeSession.aspx.cs" Inherits="TuLibroWeb.InicioDeSession" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Inicio de Sesion</title>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="contenidoCentro" runat="server">

    <center>
        <br />
        <br />
        <br />
        <br />
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
                    <asp:TextBox ID="txtPass" runat="server" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <br /> 
        <asp:Button ID="btnIniciarSesion" runat="server" Text="Iniciar Sesion" OnClick = "btnIniciarSesion_Click" />
        <br />
        <br />
        <asp:Button ID="btnRegistrarse" runat="server" Text="Registrarse" OnClick = "btnRegistrarse_Click" />
        <br />
        <br />
    </center>
</asp:Content>