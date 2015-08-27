<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TuLibroWeb.Registro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
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
                    ControlToValidate="TxtNombreUsuario" ID="RfvNombreUsuario" />
                </asp:TableCell>                
            </asp:TableRow>
        </center>    
    </div>
    </form>
</body>
</html>
