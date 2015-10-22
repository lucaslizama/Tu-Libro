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
        <fieldset id="campos-registro">  
           <legend>Ingrese sus Datos</legend>                      
           <asp:Table ID="Table1" runat="server" Width="800px">
                <asp:TableRow>
                     <asp:TableCell Width="180px">
                        <asp:Label ID="lblNombre" Text="Nombre" runat="server" />
                     </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="txtNombre" runat="server" />
                    </asp:TableCell>
                    <asp:TableCell Width="230px">
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red"
                        ErrorMessage=" * Ingrese un Nombre en el campo"
                        ControlToValidate="txtNombre" ID="rfvNombre"/>
                    </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblApellido" Text="Apellido" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="txtApellido" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red"
                        ErrorMessage=" * Ingrese un Apellido en el campo"
                        ControlToValidate="txtApellido" ID="rfvApellido"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                     <asp:TableCell>
                        <asp:Label ID="lblUser" Text="Nombre de usuario" runat="server" />
                     </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="txtUser" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red"
                        ErrorMessage=" * Ingrese un nombre de usuario en el campo"
                        ControlToValidate="txtUser" ID="rfvUser"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblEdad" Text="Fecha de Nacimiento" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="txtFechaNacimiento" runat="server"></asp:TextBox>
                    </asp:TableCell><asp:TableCell>
                        <asp:RequiredFieldValidator ID="rfvFechaNacimiento" runat="server" ForeColor="Red"
                        ErrorMessage=" * Ingrese una fecha de Nacimiento "
                        ControlToValidate="txtFechaNacimiento" Display="Dynamic" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="* ingrese una fecha en el formato dd/mm/yyyy" ForeColor="Red"
                        ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$"
                        ControlToValidate="txtFechaNacimiento"/>

                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblCorreoUsuario" Text="Correo" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="txtCorreoUsuario" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:RegularExpressionValidator runat="server" ID="revCorreoUsuario" ForeColor="Red"
                        ErrorMessage=" * Ingrese un Correo válido" ControlToValidate="txtCorreoUsuario" 
                        ValidationExpression="^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,6})$" 
                        Display="Dynamic"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblCorreoUsuario2" Text="Reingrese Correo" runat="server" />
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
                        <asp:Label ID="lblPassword" Text="Contraseña" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"/>
                    </asp:TableCell><asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" ID="rfvPassword"
                        ForeColor="Red" ErrorMessage=" * Ingrese una Pasword"
                        ControlToValidate="txtPassword" Display="Dynamic" />
                        
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblPassword2" Text="Reingrese Contraseña" runat="server" />
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
                </asp:TableCell>
                <asp:TableCell>
                </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <div id="terminos-condiciones">
                <asp:Label ID="lblTerminos" runat="server" Text="Al crear una cuenta, usted acepta las Condiciones 
                    generales de uso, la Declaración de protección de datos y la Política de cookies y publicidad 
                    en Internet de TuLibro."></asp:Label>
            </div>
            <div id="btn-registro-registro">
                <asp:Button ID="btnRegistrarse" class="login-button" runat="server" OnClick="btnRegistrarse_Click" Text="Registrarse" />
            </div>
        </fieldset> 
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoBarraDerecha" runat="server">
</asp:Content>
