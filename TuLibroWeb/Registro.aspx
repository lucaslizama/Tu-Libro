<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TuLibroWeb.Registro2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Registrarte en Tu Libro</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoBarraIzquierda" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoCentro" runat="server">
    <div>
        <center>
        <b>Esta información es necesaria para poder crear tu cuenta.</b>
        </center>
        <br />
        <center>                        
           <asp:Table ID="Table1" runat="server" BorderColor="Black" BorderWidth="3" Width="800px">
                <asp:TableRow>
                     <asp:TableCell>
                        <asp:Label ID="lblNombre" Text="Ingrese Su Nombre" runat="server" />
                     </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="txtNombre" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red"
                        ErrorMessage=" * Ingrese un Nombre en el campo"
                        ControlToValidate="txtNombre" ID="rfvNombre"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                     <asp:TableCell>
                        <asp:Label ID="lblApellido" Text="Ingrese Su Apellido" runat="server" />
                     </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="txtApellido" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red"
                        ErrorMessage=" * Ingrese un Apellido en el campo"
                        ControlToValidate="txtApellido" ID="rfvApellido"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                     <asp:TableCell>
                        <asp:Label ID="lblUser" Text="Ingrese un nombre de usuario" runat="server" />
                     </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="txtUser" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red"
                        ErrorMessage=" * Ingrese un nombre de usuario en el campo"
                        ControlToValidate="txtUser" ID="rfvUser"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblEdad" Text="Ingrese Su Edad" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="txtEdad" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:RequiredFieldValidator ID="rfvEdad" runat="server" ForeColor="Red"
                        ErrorMessage=" * Ingrese una Edad en el campo "
                        ControlToValidate="txtEdad" Display="Dynamic" />
                        <asp:RangeValidator runat="server" ID="rvEdad" ControlToValidate="txtEdad"
                        ForeColor="Red" MaximumValue="110" MinimumValue="18" Type="Integer"
                        Display="Dynamic" ErrorMessage=" * Ingrese una Edad mayor a 17 y menor a 111 años " />
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblCorreoUsuario" Text="Ingrese Su Correo" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="txtCorreoUsuario" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:RegularExpressionValidator runat="server" ID="revCorreoUsuario" ForeColor="Red"
                        ErrorMessage=" * Ingrese un Correo válido" ControlToValidate="txtCorreoUsuario" 
                        ValidationExpression="^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,6})$" 
                        Display="Dynamic"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblCorreoUsuario2" Text="Reingrese Su Correo" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="txtCorreoUsuario2" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" ID="rfvCorreoUsuario2"
                        ForeColor="Red" ErrorMessage=" * Debe Reingresar su Correo "
                        ControlToValidate="txtCorreoUsuario2" Display="Dynamic" />
                        <asp:CompareValidator runat="server" ID="cvCorreoUsuario2"
                        ForeColor="Red" ControlToCompare="txtCorreoUsuario" ControlToValidate="txtCorreoUsuario2"
                        ErrorMessage=" * Sus Correos no Son Iguales " Display="Dynamic" />
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblPassword" Text="Password" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"/>
                    </asp:TableCell><asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" ID="rfvPassword"
                        ForeColor="Red" ErrorMessage=" * Ingrese una Pasword"
                        ControlToValidate="txtPassword" Display="Dynamic" />
                        
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblPassword2" Text="Reingrese Password" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password"/>
                    </asp:TableCell><asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" ID="rfvPAssword2"
                        ForeColor="Red" ErrorMessage=" * Debe Ingresar una contraseña"
                        ControlToValidate="txtPassword2" Display="Dynamic" />
                        <asp:CompareValidator runat="server" ID="cvPassword2"
                        ForeColor="Red" ControlToCompare="txtPassword" ControlToValidate="txtPassword2"
                        ErrorMessage=" * Lo Ingresado no concide con la Password, reingrese" Display="Dynamic"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>                    
                </asp:TableCell><asp:TableCell>
                    <asp:Label ID="lblTerminos" runat="server" Text="Al crear una cuenta, usted acepta las Condiciones 
                    generales de uso, la Declaración de protección de datos y la Política de cookies y publicidad 
                    en Internet de TuLibro."></asp:Label>
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell>
                </asp:TableCell><asp:TableCell>
                    <asp:Button ID="btnRegistrarse" runat="server" OnClick="btnRegistrarse_Click"
                    Text="Registrarse" />
                </asp:TableCell><asp:TableCell>
                </asp:TableCell></asp:TableRow></asp:Table></center></div></asp:Content><asp:Content ID="Content4" ContentPlaceHolderID="contenidoBarraDerecha" runat="server">
</asp:Content>
