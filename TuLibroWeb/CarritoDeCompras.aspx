<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="CarritoDeCompras.aspx.cs" Inherits="TuLibroWeb.CarritoDeCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoBarraIzquierda" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoCentro" runat="server">
<div class="cart-info">
          <asp:ListView runat="server" ID="listaCarro">
                    <LayoutTemplate>
                        <table class="table table-striped table-bordered">
                            <tr>
                                <th class="name">Nombre</th>
                                <th class="model">Descripción</th>
                                <th class="price">Precio</th>
                            </tr>
                            <asp:PlaceHolder runat="server" ID="itemPlaceholder"/>
                            </table>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr>
                            <td  class="name"><a href="Libro.aspx?id=<%#Eval("isbn") %>"><%#Eval("Nombre") %></a></td>
                            <td class="model"><%#Eval("ShortDescripcion")%></td>
                            <td class="price"><%#Eval("Precio")%></td>
                         </tr>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        <label>No se encontraron items</label>
                    </EmptyDataTemplate>
        </asp:ListView>
      </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoBarraDerecha" runat="server">
</asp:Content>
