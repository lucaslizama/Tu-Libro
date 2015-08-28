<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TuLibroWeb.Registro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Registro</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <b>Esta información es necesaria para poder crear tu cuenta.</b>
        </center>
        <br />
        <center>                        
           <asp:Table ID="Table1" runat="server" BorderColor="Black" BorderWidth="3" Width="800px">
                <asp:TableRow>
                     <asp:TableCell>
                        <asp:Label ID="LblNombreUsuario" Text="Ingrese Su Nombre" runat="server" />
                     </asp:TableCell>                    
                    <asp:TableCell>
                        <asp:TextBox ID="TxtNombreUsuario" runat="server" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" ForeColor="Red"
                        ErrorMessage=" * Ingrese un Nombre en el campo"
                        ControlToValidate="TxtNombreUsuario" ID="RfvNombreUsuario"/>
                    </asp:TableCell>                
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblEdad" Text="Ingrese Su Edad" runat="server" />
                    </asp:TableCell>                    
                    <asp:TableCell>
                        <asp:TextBox ID="TxtEdad" runat="server" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red"
                        ErrorMessage=" * Ingrese una Edad en el campo "
                        ControlToValidate="TxtEdad" Display="Dynamic" />
                        <asp:RangeValidator runat="server" ID="RvEdad" ControlToValidate="TxtEdad"
                        ForeColor="Red" MaximumValue="110" MinimumValue="18" Type="Integer"
                        Display="Dynamic" ErrorMessage=" * Ingrese una Edad mayor a 17 y menor a 111 años " />
                    </asp:TableCell>                
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblCorreoUsuario" Text="Ingrese Su Correo" runat="server" />
                    </asp:TableCell>                    
                    <asp:TableCell>
                        <asp:TextBox ID="TxtCorreoUsuario" runat="server" />
                    </asp:TableCell>                        
                    <asp:TableCell>
                        <asp:RegularExpressionValidator runat="server" ID="RevCorreoUsuario" ForeColor="Red"
                        ErrorMessage=" * Ingrese un Correo válido" ControlToValidate="TxtCorreoUsuario" 
                        ValidationExpression="^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,6})$" 
                        Display="Dynamic"/>
                    </asp:TableCell>                
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblCorreoUsuario2" Text="Reingrese Su Correo" runat="server" />
                    </asp:TableCell>                    
                    <asp:TableCell>
                        <asp:TextBox ID="TxtCorreoUsuario2" runat="server" />
                    </asp:TableCell>                        
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" ID="RfvCorreoUsuario2"
                        ForeColor="Red" ErrorMessage=" * Debe Reingresar su Correo "
                        ControlToValidate="TxtCorreoUsuario2" Display="Dynamic" />
                        <asp:CompareValidator runat="server" ID="CvCorreoUsuario2"
                        ForeColor="Red" ControlToCompare="TxtCorreoUsuario" ControlToValidate="TxtCorreoUsuario2"
                        ErrorMessage=" * Sus Correos no Son Iguales " Display="Dynamic" />
                    </asp:TableCell>                
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblPassword" Text="Password" runat="server" />
                    </asp:TableCell>                    
                    <asp:TableCell>
                        <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"/>
                    </asp:TableCell>                        
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" ID="RfvPassword"
                        ForeColor="Red" ErrorMessage=" * Ingrese una Pasword"
                        ControlToValidate="TxtPassword" Display="Dynamic" />
                        <asp:RegularExpressionValidator runat="server" ID="RevPassword" 
                        ForeColor="Red" ErrorMessage=" * Su Password es muy debil "
                        ControlToValidate="TxtPassword"
                        ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,10})$;" Display="Dynamic" />
                    </asp:TableCell>                
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LblPassword2" Text="Reingrese su Passwors" runat="server" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtPassword2" runat="server" TextMode="Password" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" ID="RvfPassword2"
                        ForeColor="Red" ControlToValidate="TxtPassword2" Display="Dynamic" />
                        <asp:CompareValidator runat="server" ID="CvPassword2" ForeColor="Red"
                        ControlToCompare="TxtPassword" ControlToValidate="TxtPassword2"
                        ErrorMessage=" * Las Passwors no conciden , Reintente" Display="Dynamic" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>   
                    <asp:TableCell>                    
                    </asp:TableCell>                             
                <asp:TableCell>
                    <center>
                        <b>Al crear una cuenta en www.tulibro.cl, usted acepta las Condiciones 
                        generales de uso, la Declaración de protección de datos y la Política de cookies y publicidad 
                        en Internet de TuLibro.</b>
                    </center>
                    </asp:TableCell>                            
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="BtnValidar" runat="server" OnClick="BtnValidar_Click"
                    Text="Registrarse" />
                </asp:TableCell>
            </asp:TableRow>
           </asp:Table>
        </center>    
    </div>
    </form>
</body>
</html>
