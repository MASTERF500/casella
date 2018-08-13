<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterP.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="SisMonAmbiental.Paginas.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 align="center">Sistema de Monitoreo Ambiental</h2>
    
    <table style="width: 100%;">
        <tr>
            <td><asp:Image ID="Image3" runat="server" ImageUrl="~/Imagenes/Inicio/sagarpa.jpg" Height="219px" Width="411px"/></td>
            <td>&nbsp;</td>
            <td><asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Inicio/inifap.jpg" Height="166px" Width="339px"/></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><asp:Image ID="Image2" runat="server" ImageUrl="~/Imagenes/Inicio/logo.png" Height="180px" Width="574px" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>         
        </tr>        
    </table>
           

</asp:Content>
