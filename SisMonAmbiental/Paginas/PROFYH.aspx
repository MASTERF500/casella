<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterP.Master" AutoEventWireup="true" CodeBehind="PROFYH.aspx.cs" Inherits="SisMonAmbiental.Paginas.PROFYH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
    <style type="text/css">
        .auto-style3 {
            width: 87px;
        }
        .auto-style5 {
            width: 200px;
        }
        .auto-style6 {
            width: 35px;
        }
    </style>
    <style>
        #map {
            height:320px;
            width:650px;
            overflow:hidden;
            float:left;
            border:thin solid #333;
            margin:auto;
        }
        .auto-style7 {
            width: 550px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center><h1>Productores de Frutas y Hortalizas</h1></center>
    <br />
    <br />
    <table style="width: 100%;">        
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td><center><asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Inicio/logo.png" Height="122px" Width="353px" /></center></td>
            <td>&nbsp;</td>
        </tr>        
    </table>
    <br />
    <br />

    <table style="width: 100%;" id="justifica">
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">
                <p>La agricultura es la actividad más importante en Caborca, tierra forjada por las manos de los hombres, en ella se deposita el esfuerzo y los sueños de su gente ofreciendo al mundo sus mejores frutos nacidos de nuestro México.</p>
    <p>La excelencia de nuestros cultivos radica en la labor ejercida en el campo, presentando al mundo el trabajo y el esfuerzo de su gente.</p>
    <p>Nuestros cultivos en manos expertas ofrecen la calidad que se exige hoy, produciéndose en Caborca frutas y hortalizas con sanidad y frescura para el deleite del mundo.</p>
    <p>PROFYH tiene como meta impulsar el desarrollo económico de la región, generando la preferencia de los consumidores por los frutos que se cultivan en Caborca, Sonora.</p>
            </td>
            <td class="auto-style5">
                <div id="map"></div>
            </td>
        </tr>
    </table>
    
     <script>
         function initMap() {
             var myLatlng = new google.maps.LatLng(30.7808, -112.446);
             map = new google.maps.Map(document.getElementById('map'), {
                 center: new google.maps.LatLng(30.7808, -112.446),
                 zoom: 7,
                 mapTypeId: google.maps.MapTypeId.ROADMAP
             });
                       
             var marker = new google.maps.Marker({
                 position: myLatlng,
                 map: map,
                 title: 'Lt:30.7808, Long:-112.446'
             });
         }
    </script>
    <script async defer
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAmZCnSJBCnBrJ2V70CIbX27A0yFl-06A0&callback=initMap">
    </script>



</asp:Content>
