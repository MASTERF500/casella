<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio/MasterI.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SisMonAmbiental.Inicio.Login" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h2>Inicio de Sesión</h2></center>
     <br />
    <div class="container">
    <form class="main row">
        <div class="col-xs-12 col-sm-8 col-md-6">
  <div class="form-group">
    <label for="exampleInputEmail1"><strong>Usuario:</strong></label>
      <asp:TextBox  type="text" class="form-control" placeholder="Usuario" ID="TextBox1" runat="server"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1"><strong>Contraseña:</strong></label>
      <asp:TextBox type="password" class="form-control" placeholder="Contraseña" ID="TextBox2" runat="server"></asp:TextBox>
  </div>
            <asp:Label ID="Label1" runat="server" ForeColor="#FF3300"></asp:Label>
  <br />
            
            <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="Acceso" OnClick="Button1_Click" />
            </div>
</form>
        </div>
</asp:Content>
