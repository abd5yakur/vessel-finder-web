// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$.getJSON("https://services.marinetraffic.com/api/exportvessel/v:5/b186c8770811802437498071f03bce29c873bb50/timespan:20/mmsi:310627000/protocol:jsono", function (data) {
    console.log(data);

    var lat, x;
    lat = data;
    //var lat = data.;
    //console.log(lat);
    //$('.lat').append(lat);
    //var long = data.long;
    //$.(".long").append(long);
    //var MMSI = data.MMSI;
    //$.(".mmsi").append(MMSI);
});