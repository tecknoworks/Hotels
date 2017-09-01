function Locations() {
    var self = this;
    self.Countries = ko.observableArray();
    self.Cities = ko.observableArray();
    self.Acomodations = ko.observableArray();
    self.Rooms = ko.observableArray();
    self.Reservation = ko.observableArray();
    self.RoomReservation = ko.observableArray();
    self.AcomodationFacilities = ko.observableArray();
    self.Reviews = ko.observableArray();
    self.Photos = ko.observableArray();

    self.Id = ko.observable();
    self.Type = ko.observable();
    self.Address = ko.observable();
    self.Name = ko.observable();
    self.NumberOfStars = ko.observable();
    self.Description = ko.observable();
    self.PhoneNumber = ko.observable();
    self.WebSite = ko.observable();
    self.Price = ko.observable();
    self.NumberOfAdults = ko.observable();
    self.NumberOfChildren = ko.observable();
    self.NumberOfRoomsAvailable = ko.observable();
    self.AcomodationType = ko.observable();
    self.RoomType = ko.observable();
    self.RoomPhoto = ko.observable();
    self.AcomodationPhoto = ko.observable();
    self.NumberOfPeople = ko.observable();
    self.TotalPayment = ko.observable();
    self.DateOfEnd = ko.observable();
    self.DateOfStart = ko.observable();
    self.DateOfReservation = ko.observable();
    self.NrOfPeople = ko.observable();
    self.FacilityDescription = ko.observable();
    self.Lat = ko.observable();
    self.Lng = ko.observable();
    self.Stars = ko.observable();
    self.AccomodationPhoto = ko.observable();



    self.details = function (data) {
        self.Id(data.Id);
        self.Type(data.Type);
        self.Address(data.Address);
        self.Name(data.Name);
        self.NumberOfStars(data.NumberOfStars);
        self.Description(data.Description);
        self.PhoneNumber(data.PhoneNumber);
        self.WebSite(data.WebSite);
        self.Price(data.Price);
        self.NumberOfAdults(data.NumberOfAdults);
        self.NumberOfChildren(data.NumberOfChildren);
        self.NumberOfRoomsAvailable(data.NumberOfRoomsAvailable);
        self.AcomodationType(data.AcomodationType);
        self.RoomType(data.RoomType);
        self.RoomPhoto(data.RoomPhoto);
        self.AcomodationPhoto(data.AcomodationPhoto);
        self.NumberOfPeople(data.NumberOfPeople);
        self.TotalPayment(data.TotalPayment);
        self.DateOfStart(data.DateOfStart);
        self.DateOfEnd(data.DateOfEnd);
        self.NrOfPeople(data.NrOfPeople);
        self.FacilityDescription(data.FacilityDescription);
        self.Lat(data.lat);
        self.Lng(data.Lng);
        self.Stars(data.Stars);
        self.AccomodationPhoto(data.AccomodationPhoto);
        
    };

    self.refresh = function () {
        var url = '/Home/GetAllCountries';
        $.ajax(url, {
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                self.Countries(data.Countries);
                $("#cities").hide();
                $("#acomodations").hide();
                $("#rooms").hide();
                $("#facilities").hide();
                $("#reviews").hide();
                if (data.Countries.length > 0) {
                    $("#countries").show();
                }
                else {
                    $("#countries").hide();
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });
    };
    //self.getPhotos=function(data){
    //    var url = '/Home/GetPhotos';
    //    $.ajax(url, {
    //        data:{acomodationId:data.Id},
    //        type: "get",
    //        contentType: "application/json; charset=utf-8",
    //        success: function (data) {
    //            self.AccomodationPhoto(data.AccomodationPhoto);
    //        },
    //        error: function (jqXHR, textStatus, errorThrown) {
    //            console.log(textStatus + ': ' + errorThrown);
    //        }
    //    });
    //};

    self.setMapLocation = function (data) {
        var input = document.getElementById('pac-input');
        input.value = data.Name;
        var latt = parseFloat(data.Lat);
        var lngg = parseFloat(data.Lng);
        var x = { lat: latt, lng: lngg };
        var map = new google.maps.Map(document.getElementById('map'), {
            zoom: 4,
            center: x,
            mapTypeId: 'roadmap'
        });
        document.getElementById("map").style.visibility = "visible";
        var marker = new google.maps.Marker({
            position: x,
            map: map
        });
        var searchBox = new google.maps.places.SearchBox(input);
        map.controls[google.maps.ControlPosition.TOP_LEFT].push(input);

        // Bias the SearchBox results towards current map's viewport.
        map.addListener('bounds_changed', function () {
            searchBox.setBounds(map.getBounds());
        });

        var markers = [];
        // Listen for the event fired when the user selects a prediction and retrieve
        // more details for that place.
        searchBox.addListener('places_changed', function () {
            var places = searchBox.getPlaces();

            if (places.length == 0) {
                return;
            }
            // Clear out the old markers.
            markers.forEach(function (marker) {
                marker.setMap(null);
            });
            markers = [];
            // For each place, get the icon, name and location.
            var bounds = new google.maps.LatLngBounds();
            places.forEach(function (place) {
                if (!place.geometry) {
                    console.log("Returned place contains no geometry");
                    return;
                }
                var icon = {
                    url: place.icon,
                    size: new google.maps.Size(71, 71),
                    origin: new google.maps.Point(0, 0),
                    anchor: new google.maps.Point(17, 34),
                    scaledSize: new google.maps.Size(25, 25)
                };

                // Create a marker for each place.
                markers.push(new google.maps.Marker({
                    map: map,
                    icon: icon,
                    title: place.name,
                    position: place.geometry.location
                }));

                if (place.geometry.viewport) {
                    // Only geocodes have viewport.
                    bounds.union(place.geometry.viewport);
                } else {
                    bounds.extend(place.geometry.location);
                }
            });
            map.fitBounds(bounds);
        });
    }

    self.setMapLocationCity = function (data) {
        var input = document.getElementById('pac-input');
        input.value = data.Name;
        var latt = parseFloat(data.Lat);
        var lngg = parseFloat(data.Lng);
        var x = { lat: latt, lng: lngg };
        var map = new google.maps.Map(document.getElementById('map'), {
            zoom: 10,
            center: x,
            mapTypeId: 'roadmap'
        });
        document.getElementById("map").style.visibility = "visible";
        var marker = new google.maps.Marker({
            position: x,
            map: map
        });
        var searchBox = new google.maps.places.SearchBox(input);
        map.controls[google.maps.ControlPosition.TOP_LEFT].push(input);

        // Bias the SearchBox results towards current map's viewport.
        map.addListener('bounds_changed', function () {
            searchBox.setBounds(map.getBounds());
        });

        var markers = [];
        // Listen for the event fired when the user selects a prediction and retrieve
        // more details for that place.
        searchBox.addListener('places_changed', function () {
            var places = searchBox.getPlaces();

            if (places.length == 0) {
                return;
            }
            // Clear out the old markers.
            markers.forEach(function (marker) {
                marker.setMap(null);
            });
            markers = [];
            // For each place, get the icon, name and location.
            var bounds = new google.maps.LatLngBounds();
            places.forEach(function (place) {
                if (!place.geometry) {
                    console.log("Returned place contains no geometry");
                    return;
                }
                var icon = {
                    url: place.icon,
                    size: new google.maps.Size(71, 71),
                    origin: new google.maps.Point(0, 0),
                    anchor: new google.maps.Point(17, 34),
                    scaledSize: new google.maps.Size(25, 25)
                };

                // Create a marker for each place.
                markers.push(new google.maps.Marker({
                    map: map,
                    icon: icon,
                    title: place.name,
                    position: place.geometry.location
                }));

                if (place.geometry.viewport) {
                    // Only geocodes have viewport.
                    bounds.union(place.geometry.viewport);
                } else {
                    bounds.extend(place.geometry.location);
                }
            });
            map.fitBounds(bounds);
        });
    }
    self.setMapLocationAcomodation = function (data) {
        var input = document.getElementById('pac-input');
        input.value = data.Name;

        var latt = parseFloat(data.Lat);
        var lngg = parseFloat(data.Lng);
        var x = { lat: latt, lng: lngg };
        var map = new google.maps.Map(document.getElementById('map'), {
            zoom: 18,
            center: x,
            mapTypeId: 'roadmap'
        });
        document.getElementById("map").style.visibility = "visible";
        var marker = new google.maps.Marker({
            position: x,
            map: map
        });
        var searchBox = new google.maps.places.SearchBox(input);
        map.controls[google.maps.ControlPosition.TOP_LEFT].push(input);

        // Bias the SearchBox results towards current map's viewport.
        map.addListener('bounds_changed', function () {
            searchBox.setBounds(map.getBounds());
        });

        var markers = [];
        // Listen for the event fired when the user selects a prediction and retrieve
        // more details for that place.
        searchBox.addListener('places_changed', function () {
            var places = searchBox.getPlaces();

            if (places.length == 0) {
                return;
            }
            // Clear out the old markers.
            markers.forEach(function (marker) {
                marker.setMap(null);
            });
            markers = [];
            // For each place, get the icon, name and location.
            var bounds = new google.maps.LatLngBounds();
            places.forEach(function (place) {
                if (!place.geometry) {
                    console.log("Returned place contains no geometry");
                    return;
                }
                var icon = {
                    url: place.icon,
                    size: new google.maps.Size(71, 71),
                    origin: new google.maps.Point(0, 0),
                    anchor: new google.maps.Point(17, 34),
                    scaledSize: new google.maps.Size(25, 25)
                };

                // Create a marker for each place.
                markers.push(new google.maps.Marker({
                    map: map,
                    icon: icon,
                    title: place.name,
                    position: place.geometry.location
                }));

                if (place.geometry.viewport) {
                    // Only geocodes have viewport.
                    bounds.union(place.geometry.viewport);
                } else {
                    bounds.extend(place.geometry.location);
                }
            });
            map.fitBounds(bounds);
        });
        //Get facilities

        var url1 = '/Home/GetFacilities';
        $.ajax(url1, {
            data: { acomodationId: data.Id },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                self.AcomodationFacilities(data.AcomodationFacilities);
                if (data.AcomodationFacilities.length > 0) {
                    $("#facilities").show();
                }
                else {
                    $("#facilities").hide();
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }

        });

        //Get reviews
        var url = '/Home/GetReviews';
        $.ajax(url, {
            data: { acomodationId: data.Id },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                self.Reviews(data.Reviews);
                if (data.Reviews.length > 0) {
                    $("#reviews").show();
                }
                else {
                    $("#reviews").hide();
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });

    };

    self.getCities = function (data) {
        var url = '/Home/GetCities';
        
        $.ajax(url, {
            data: { countryId: data.Id },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                $("#acomodations").hide();
                $("#rooms").hide();
                $("#facilities").hide();
                $("#reviews").hide();
                if (data == "") {
                    //redirect('Account/Login');
                    window.location.href = "Account/Login";
                }
                else {
                    self.Cities(data.Cities);
                    if (data.Cities.length > 0) {
                        $("#cities").show();
                    }
                    else {
                        $("#cities").hide();
                    }
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });
    };

    self.getAcomodations = function (data) {
        var url = '/Home/GetAcomodations';
        $.ajax(url, {
            data: { cityId: data.Id },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                self.Acomodations(data.Acomodations);
                $("#rooms").hide();
                $("#facilities").hide();
                $("#reviews").hide();

                if (data.Acomodations.length > 0) {
                    $("#acomodations").show();
                }
                else {
                    $("#acomodations").hide();
                }

            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });
    };

    self.getRooms = function (data) {
        var url = '/Home/GetRooms';
        $.ajax(url, {
            data: { acomodationId: data.Id },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                self.Rooms(data.Rooms);
                if (data.Rooms.length > 0) {
                    $("#rooms").show();
                }
                else {
                    $("#rooms").hide();
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });
    };

    self.getStars = function (data) {
        var url = '/Home/GetAcomodationByStars';
        $.ajax(url, {
            data: { acomodationId: data.Id },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                self.Rooms(data.Rooms);
                if (data.Rooms.length > 0) {
                    $("#rooms").show();
                }
                else {
                    $("#rooms").hide();
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });
    };


    self.bookRoom = function (data) {
        var url = '/Home/AddReservation';
        $.ajax(url, {
            data: {
                dateOfStart: DateOfStart.value,
                dateOfEnd: DateOfEnd.value,
                numberOfPeople: NrOfPeople.value,
                totalPayment: TotalPayment.value,
                roomId: data.Id
            },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                self.Reservation(data.Reservation);
                document.getElementById("succes").style.visibility = "visible";
                window.setTimeout(function () { location.reload() }, 3000);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }

        });
    };

    self.getTotalPayment = function (data) {
        var url = '/Home/GetTotalPayment';
        $.ajax(url, {
            data: {
                dateOfEnd: DateOfEnd.value,
                dateOfStart: DateOfStart.value,
                price: data.Price
            },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                $("#TotalPayment").val(data.TotalPayment);
                $("#btnBook").show();
                $("#btnGetPrice").hide();
                $("#DateOfStart").attr("readonly", true);
                $("#DateOfEnd").attr("readonly", true);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });
    };

    
}