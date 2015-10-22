<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="MiPerfil.aspx.cs" Inherits="TuLibroWeb.MiPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoBarraIzquierda" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoCentro" runat="server">
        <center>
            <b>Bienvenido a mi Perfil.</b>
        </center>    
        <br />        
            <asp:Table ID="table1" runat="server" BorderColor="Black" BorderWidth="3" Width="800px">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblNombre" Text="Nombre : " runat="server" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtNombre" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblApellido" Text="Apellido : " runat="server" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtApellido" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblUser" Text="Usuario : " runat="server" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtUsuario" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblCorreo" Text="Correo : " runat="server" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtCorreo" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblFechaNaciemiento" Text="Fecha de Nacimiento : " runat="server" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtFecha" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblPass" Text="Password : " runat="server" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtPass" runat="server" />
                    </asp:TableCell>
                </asp:TableRow> 
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
                    </asp:TableCell>
                </asp:TableRow>   
            </asp:Table>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoBarraDerecha" runat="server">
</asp:Content>
