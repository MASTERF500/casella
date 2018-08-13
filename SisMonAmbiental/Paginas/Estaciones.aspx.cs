using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisMonAmbiental.Paginas
{
    public partial class Estaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["flag"] = null;

//            #region map1
//                string map= @" 
//<script type='text/javascript'>
//jQuery(function($) {
//    // Asynchronously Load the map API 
//    var script = document.createElement('script');
//    script.src = '//maps.googleapis.com/maps/api/js?sensor=false&callback=initialize';
//    document.body.appendChild(script);
//});
//
//function initialize() {
//    var map;
//    var bounds = new google.maps.LatLngBounds();
//    var mapOptions = {
//        mapTypeId: 'roadmap'
//    };
//                    
//    // Display a map on the page
//    map = new google.maps.Map(document.getElementById('map_canvas'), mapOptions);
//    map.setTilt(45); "+
    
//    @"// Multiple Markers
//    var markers = [
//        ['London Eye, London', 51.503454,-0.119562],
//        ['Palace of Westminster, London', 51.499633,-0.124755]
//    ];"+
 
        
//    @"// Display multiple markers on a map
//    var infoWindow = new google.maps.InfoWindow(), marker, i;
//    
//    // Loop through our array of markers & place each one on the map  
//    for( i = 0; i < markers.length; i++ ) {
//        var position = new google.maps.LatLng(markers[i][1], markers[i][2]);
//        bounds.extend(position);
//        marker = new google.maps.Marker({
//            position: position,
//            map: map,
//            title: markers[i][0]
//        });
//        
//
//
//        // Automatically center the map fitting all markers on the screen
//        map.fitBounds(bounds);
//    }
//
//    // Override our map zoom level once our fitBounds function runs (Make sure it only runs once)
//    var boundsListener = google.maps.event.addListener((map), 'bounds_changed', function(event) {
//        this.setZoom(14);
//        google.maps.event.removeListener(boundsListener);
//    });
//    
//}</script>";
//            #endregion
//            ClientScript.RegisterStartupScript(this.GetType(), "MAP1", map);
        }
    }
}