function Countries() {
    var self = this;
    self.Countries = ko.observableArray();
    self.Cities = ko.observableArray();
    self.Acomodations = ko.observableArray();
    self.Rooms = ko.observableArray();

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
    self.Picture = ko.observable();
    self.Photo = ko.observable();
    self.AcomodationPhoto=ko.observable();
   

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
    	self.Picture(data.Picture);
    	self.Photo(data.Photo);
    	self.AcomodationPhoto(data.AcomodationPhoto); 
    };

    self.refresh = function () {
        var url = '/Home/GetAllCountries';
        $.ajax(url, {
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                //console.log(data);
                self.Countries(data.Countries);
                $("#cities").hide();
                $("#acomodations").hide();
                $("#rooms").hide();
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
    self.getCities = function (data) {
    	var url = '/Home/GetCities';
    	$.ajax(url, {
    		data: { countryId: data.Id },
    		type: "get",
    		contentType: "application/json; charset=utf-8",
    		success: function (data) {
    			self.Cities(data.Cities);
    			$("#acomodations").hide();
    			$("#rooms").hide();
    			if (data.Cities.length > 0) {
    			    $("#cities").show();
    			}
    			else {
    			    $("#cities").hide();
    			}
    		},
    		error: function (jqXHR, textStatus, errorThrown) {
    			console.log(textStatus + ': ' + errorThrown);
    		}
    	});
    	self.getAcomodations = function (data) {
    		var url = '/Home/GetAcomodations';
    		$.ajax(url, {
    			data: { cityId: data.Id },
    			type: "get",
    			contentType: "application/json; charset=utf-8",
    			success: function (data) {
    				self.Acomodations(data.Acomodations);
    				$("#rooms").hide();
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
    	}
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
    	}
    }
}
