<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterP.Master" AutoEventWireup="true" CodeBehind="Estaciones.aspx.cs" Inherits="SisMonAmbiental.Paginas.Estaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style>
      #map {
       height: 600px;
       width: 989px;
       overflow: hidden;
       float: left;
       border: thin solid #333;
       margin: auto;
       flex-align:center;
       
       }
       
    </style>
     <div class="container">
            <div class="row">            
                <div class="col-sm-6">
                    <figure>
                        <figcaption><h4>Estaciones</h4></figcaption>
                        <div id="map"></div></figure>
                </div>
            </div>
         <div id="map" class="map"></div>
       <%-- mapMarkersScript --%>
        <script type='text/javascript'>
            var map;
            var Markers = {};
            var infowindow;
            var locations = JSON.parse('[{"Id":3,"Nombre":"Campo El Mexicano,Sonora","Latitud":30.817068,"Longitud":-112.56534},{"Id":5,"Nombre":"PROFYH,Sonora","Latitud":30.711045,"Longitud":-112.163607},{"Id":1,"Nombre":"Vicente Guerrero","Latitud":30.845956,"Longitud":-112.86311},{"Id":2,"Nombre":"Campo San Juan, Sonora","Latitud":30.735558,"Longitud":-112.742067},{"Id":4,"Nombre":"Campo El Tecolote,Sonora","Latitud":30.969744,"Longitud":-113.017752}]');

        function initMap() {
            var mapOptions = { zoom: 4, center: origin };
            var map = new google.maps.Map(document.getElementById('map'), {
                zoom: 7,
                center: { lat: 30.7808, lng: -112.446 }
            });
            infowindow = new google.maps.InfoWindow();

            for (i = 0; i < locations.length; i++) {
                var position = new google.maps.LatLng(locations[i].Latitud, locations[i].Longitud);
                var marker = new google.maps.Marker({
                    position: position,
                    map: map,
                });
                google.maps.event.addListener(marker, 'click', (function (marker, i) {
                    return function () {
                        var contenidoLabel = "<div> <b>Nombre:</b> " + locations[i].Nombre + "<br><b>Latitud</b>: " + locations[i].Latitud + "<br><b>Longitud:</b> " + locations[i].Longitud + "<br> </p>  <a href='Graficas.aspx?estacion=" + locations[i].Id + "'> Información...</a> </div>";
                        infowindow.setContent(contenidoLabel);
                        infowindow.setOptions({ maxWidth: 200 });
                        infowindow.open(map, marker);
                    }
                })(marker, i));
                Markers[locations[i].Numero] = marker;
            }
            locate(0);
        }
        function locate(marker_id) {
            var myMarker = Markers[marker_id];
            var markerPosition = myMarker.getPosition();
            map.setCenter(markerPosition);
            google.maps.event.trigger(myMarker, 'click');
        }
    </script>
    <%-- mapMarkersScriptEnd --%>

        
<%--    <script type="text/javascript">
        function initMap() {

            map = new google.maps.Map(document.getElementById('map'), {
                center: new google.maps.LatLng(30.7808, -112.446),
                zoom: 4,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            });

            var src = 'http://clima.inifap.gob.mx/caborca/estaciones_12.kml';

            var kmlLayer = new google.maps.KmlLayer(src, {
                preserveViewport: false,
                map: map
            });

        }
    </script>--%>
    <script async defer
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAmZCnSJBCnBrJ2V70CIbX27A0yFl-06A0&callback=initMap">
    </script>

</asp:Content>
