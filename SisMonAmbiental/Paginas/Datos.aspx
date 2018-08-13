<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterP.Master" AutoEventWireup="true" CodeBehind="Datos.aspx.cs" Inherits="SisMonAmbiental.Paginas.Datos" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <script src="canvas/canvasjs.min.js"></script>
    <asp:Panel ID="Panel3" runat="server">

        <div class="col-sm-6">
            <figure>
                <figcaption>
                    <h4>Datos</h4>
                    <p>Seleccione una nueva fecha para visualizar diferentes datos.</p>
                </figcaption>

                <h5>Estacion:</h5>
                <table style="width: 100%;">
                    <tr>
                        <td>
                            <asp:Label ID="nameLabel" runat="server" Text="Label"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LongLabel" runat="server" Text="Label"></asp:Label><br />
                            <asp:Label ID="LatLabel" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>
                                <asp:Label ID="Label1" runat="server" Text="Fecha:"></asp:Label>

                            <asp:TextBox ID="FechaTextBox" runat="server" AutoPostBack="True" OnTextChanged="FechaTextBox_TextChanged" Width="149px"></asp:TextBox>
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="FechaTextBox" Format="dd/MM/yyyy" PopupButtonID="ImageButton1" />
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="icons/calendar1.png" AlternateText="Calendario" Height="24px" Width="26px" />
                            <br />
                        </td>
                    </tr>
                </table>
                <br />

            </figure>
        </div>

    </asp:Panel>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Block">
        <ContentTemplate>
            <div id='chart1' style='width: 90%; height: 450px; vertical-align: central; display: inline-block;'></div>
            <br />
            <div id='chart2' style='width: 90%; height: 450px; vertical-align: central; display: inline-block;'></div>
            <br />
            <div id='chart3' style='width: 90%; height: 450px; vertical-align: central; display: inline-block;'></div>
            <br />
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
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
