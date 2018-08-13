<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterP.Master" AutoEventWireup="true" CodeBehind="Pruebas.aspx.cs" Inherits="SisMonAmbiental.Paginas.Pruebas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" format="dd/MM/yyyy" TargetControlID="TextBox1"/>
    <ajaxToolkit:LineChart ID="LineChart1" runat="server"></ajaxToolkit:LineChart>
    <br />
    <ajaxToolkit:LineChart ID="LineChart2" runat="server"></ajaxToolkit:LineChart>
    <br />
    <ajaxToolkit:LineChart ID="LineChart3" runat="server"></ajaxToolkit:LineChart>
    <br />
</asp:Content>
