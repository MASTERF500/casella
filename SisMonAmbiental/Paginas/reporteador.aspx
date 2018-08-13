<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterP.Master" AutoEventWireup="true" CodeBehind="reporteador.aspx.cs" Inherits="SisMonAmbiental.Paginas.reporteador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-6">
        <figure>
            <figcaption>
                <h4><b>Generador de Reportes</b></h4>
                <p>Historial de los registros por estación. Para consultar una estación diferente:
                    <br />
                    1. Regrese al mapa de <b>Estaciones</b> y seleccione una diferente.
                    <br />
                    2. Estando en la página de <b>Datos Graficados</b> de clic en el link <b>Reporteador…</b></p>
            </figcaption>

            <h5><b>Estacion:</b></h5>
            <table style="width: 100%;">
                <tr>
                    <td>
                        <asp:Label ID="nameLabel" runat="server" Text="Label"></asp:Label>
                        <br />
                        <asp:Label ID="LongLabel" runat="server" Text="Label"></asp:Label><br />
                        <asp:Label ID="LatLabel" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:ImageButton ID="ImageButtonPdf" runat="server" ImageUrl="~/Paginas/img/csv.png" Height="121px" Width="125px" OnClick="ImageButtonPdf_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" Height="539px" PageSize="50" Width="624px" OnRowDataBound="GridView1_RowDataBound">
                            <Columns>
                                <asp:BoundField DataField="fecha" HeaderText="FECHA" SortExpression="fecha" />
                                <asp:BoundField DataField="PM1_1H" HeaderText="PM1_1H" SortExpression="PM1_1H" />
                                <asp:BoundField DataField="PM2P5_1H" HeaderText="PM2P5_1H" SortExpression="PM2P5_1H" />
                                <asp:BoundField DataField="PM10_1H" HeaderText="PM10_1H" SortExpression="PM10_1H" />
                                <asp:BoundField DataField="temp" HeaderText="TEMP" SortExpression="temp" />
                                <asp:BoundField DataField="supply" HeaderText="SUPPLY" SortExpression="supply" />
                            </Columns>
                            <PagerSettings PageButtonCount="31" />
                            <RowStyle BorderStyle="Groove" />
                        </asp:GridView>
                        <br />
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CaborcaBD %>" SelectCommand="SELECT [fecha], [PM1_1H], [PM2P5_1H], [PM10_1H], [temp], [supply] FROM caborca_estacion_1 ORDER BY [fecha]"></asp:SqlDataSource>
                        <br />
                    </td>
                    
                </tr>
            </table>
            <br />

        </figure>
    </div>

</asp:Content>
