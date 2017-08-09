function Countries() {
    var self = this;
    self.Countries = ko.observableArray();
    self.Cities = ko.observableArray();
   
    self.Acomodations = ko.observableArray();
    self.Id = ko.observable();
    self.Type = ko.observable();
    self.Address = ko.observable();
    self.Name = ko.observable();
    self.NumberOfStars = ko.observable();
    self.Description = ko.observable();
    self.PhoneNumber = ko.observable();
    self.WebSite = ko.observable();

    self.details = function (data) {
    	self.Id(data.Id);
    	self.Type(data.Type);
    	self.Address(data.Address);
    	self.Name(data.Name);
    	self.NumberOfStars(data.NumberOfStars);
    	self.Description(data.Description);
    	self.PhoneNumber(data.PhoneNumber);
    	self.WebSite(data.WebSite);

    };

    self.refresh = function () {
        var url = '/Home/GetAllCountries';
        $.ajax(url, {
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                //console.log(data);
                self.Countries(data.Countries);
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
    			$("#cities").show();
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
    				$("#acomodations").show();
    			},
    			error: function (jqXHR, textStatus, errorThrown) {
    				console.log(textStatus + ': ' + errorThrown);
    			}
    		});
    	}
    }
}
