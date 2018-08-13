<%@ Page Title="Información" Language="C#" MasterPageFile="~/Paginas/MasterP.Master" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="SisMonAmbiental.Paginas.Info" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 23px;
    }
        .auto-style2 {
            height: 71px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:Panel ID="Panel3" runat="server">
        <h3>Estacion:</h3>
        <table style="width: 100%;">
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br/><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
                
            </tr>
        </table>
        <br />
    </asp:Panel>
    
     <div class="container">
                <div class="row">            
                    <div class="col-sm-6">
                        <figure>
                            <figcaption><h4>Datos: </h4></figcaption>
                            
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <table style="width: 100%;">
                                        <tr>
                                            <td class="auto-style2"><p>Fecha Inicio:</p>
                                                <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                                                <ajaxToolkit:CalendarExtender ID="CalendarExtender1" format="dd/MM/yyyy" runat="server" TargetControlID="TextBox1"  />
                                                <br />
                                            </td>
                                            <td class="auto-style2"><p>Fecha Final:</p>
                                                <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" OnTextChanged="TextBox2_TextChanged" Enabled="False"></asp:TextBox>
                                                <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" format="dd/MM/yyyy" TargetControlID="TextBox2"/>
                                                </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1"><asp:Label ID="errorlabel" runat="server" Text="Label"></asp:Label> </td>
                                        </tr>
                                    </table>
                                    
                                    <ajaxToolkit:LineChart ID="LineChart1" runat="server" ValueAxisLines="20"></ajaxToolkit:LineChart>
                                    <br />
                                    <h3>PM1</h3>
                                    <asp:GridView ID="GridView1" runat="server">
                                    </asp:GridView>
                                     <br />
                                    <h3>PM2.5</h3>
                                    
                                    <asp:GridView ID="GridView2" runat="server">
                                    </asp:GridView>
                                     <br />
                                    <h3>PM10</h3>
                                    
                                    <asp:GridView ID="GridView3" runat="server">
                                    </asp:GridView>
                                    
                                    <br />
                                    <br/>
                            <p>Temperatura: 
                            <asp:Label ID="templbl" runat="server" Text="Label"></asp:Label></p>
                                    <br />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            
                            
                        </figure>
                    </div>
                
                    </div>
                </div>

   
    <asp:Panel ID="Panel2" runat="server">
        <div class="container">
            <div class="row">            
                <div class="col-sm-6">
                    <figure>
                        <figcaption><h4>BC</h4></figcaption>
                        <img src="../Imagenes/bc.png" class="img-rounded" alt="Imagen 1" Height="360px" Width="360px"/>
                    </figure>
                </div>
                <div class="col-sm-6">
                    <figure>
                        <figcaption><h4>CO</h4></figcaption>
                        <img src="../Imagenes/co.png" class="img-rounded" alt="Imagen 1" Height="360px" Width="360px"/>
                    </figure>
                </div>
                <div class="col-sm-6">
                    <figure>
                        <figcaption><h4>CO2</h4></figcaption>
                        <img src="../Imagenes/co2.png" class="img-rounded" alt="Imagen 1" Height="360px" Width="360px"/>
                    </figure>
                </div>
                 <div class="col-sm-6">
                    <figure>
                        <figcaption><h4>PM25</h4></figcaption>
                        <img src="../Imagenes/pm25.png" class="img-rounded" alt="Imagen 1" Height="360px" Width="360px"/>
                    </figure>
                </div>
                <div class="col-sm-6">
                    <figure>
                        <figcaption><h4>SO2</h4></figcaption>
                        <img src="../Imagenes/so2.png" class="img-rounded" alt="Imagen 1" Height="360px" Width="360px"/>
                    </figure>
                </div>
                </div>
            </div>
    </asp:Panel>
</asp:Content>
