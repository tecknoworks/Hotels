function Accomodation() {

    var self = this;
    self.Countries = ko.observableArray();
    self.Cities = ko.observableArray();
    self.Acomodations = ko.observableArray();
    self.Rooms = ko.observableArray();


    self.Id = ko.observable();
    self.Name = ko.observable();

    self.details = function (data) {
        self.Id(data.Id);
        self.Name(data.Name);
        self.Address = ko.observable();
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
        self.Lat = ko.observable();
        self.Lng = ko.observable();
    };


    self.refresh = function () {
        var url = '/Home/GetAllCountries';
        $.ajax(url, {
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                self.Countries(data.Countries);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });
    };

    this.CountryChanged = function (obj, event) {

        var url = '/Home/GetCities';

        $.ajax(url, {
            data: { countryId: event.target.value },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data == "") {
                    window.location.href = "Account/Login";
                }
                else {
                    self.Cities(data.Cities);
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
            data: { countryId: event.target.value },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                    self.Cities(data.Cities);
                   
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });
    };

    self.getAcomodations = function (data) {
        var url = '/Home/GetAcomodations';
        $.ajax(url, {
            data: { cityId: event.target.value },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                self.Acomodations(data.Acomodations);

            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });
    };

    self.addAccomodation = function (data) {
        var url = '/Home/AddAcomodation';
        $.ajax(url, {
            data: {
                type: data.AcomodationType,
                address: data.Address,
                name: data.Name,
                numberOfStars: data.NumberOfStars,
                photo: data.AcomodationPhoto,
                description: data.Description,
                phoneNumber: data.PhoneNumber,
                website: data.WebSite,
                cityId: data.Id,
                lat: data.Lat,
                lng: data.Lng
            },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                self.Acomodations(data.Acomodations);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });
    };

    self.addRoom = function (data) {
        var url = '/Home/AddRoom';
        $.ajax(url, {
            data: {
                type: data.RoomType,
                price: data.Price,
                numberOfAdults: data.NumberOfAdults,
                numberOfChildren: data.NumberOfChildren,
                photo: data.RoomPhoto,
                description: data.Description,
                numberOfRoomsAvailable: data.NumberOfRoomsAvailable,
                acomodationId: data.Id
            },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                self.Rooms(data.Rooms);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });
    };

}