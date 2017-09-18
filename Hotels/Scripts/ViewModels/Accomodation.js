function Accomodation() {

    var self = this;
    self.Countries = ko.observableArray();
    self.Cities = ko.observableArray();
    self.Acomodations = ko.observableArray();
    self.Rooms = ko.observableArray();
    self.Reviews = ko.observableArray();

    self.CityId = ko.observable();
    self.AcomodationId = ko.observable();
    self.Id = ko.observable();
    self.Name = ko.observable();
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
    self.NumberOfPeople = ko.observable();
    self.Lat = ko.observable();
    self.Lng = ko.observable();


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
        var cid=event.target.value;
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

    self.addAccomodation = function (data,event) {
        var url = '/Home/AddAcomodation';
        $.ajax(url, {
            data: {
                type: AcomodationType.value,
                address: Address.value,
                name: Name.value,
                numberOfStars: NumberOfStars.value,
                //photo: AcomodationPhoto.value,
                description: Description.value,
                phoneNumber: PhoneNumber.value,
                website: WebSite.value,
                cityId: self.CityId(),
                lat: Lat.value,
                lng: Lng.value
            },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                self.Acomodations(data.Acomodations);
                document.getElementById("succes").style.visibility = "visible";
                
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });
    };

    self.addNewRoom = function (data,event) {
        var url = '/Home/AddRoom';
        $.ajax(url, {
            data: {
                type: RoomType.value,
                price: Price.value,
                numberOdAdults: NumberOfAdults.value,
                numberOfChildren: NumberOfChildren.value,
                //photo: RoomPhoto.value,
                description: Description.value,
                numberOfRoomsAvailable: NumberOfRoomsAvailable.value,
                accomodationId: self.AcomodationId()
            },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                self.Rooms(data.Rooms);
                document.getElementById("succesRoom").style.visibility = "visible";
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });
    };

    self.addReview = function (data, event) {
        var url = '/Home/AddReview';
        $.ajax(url, {
            data: {
                description: Description.value,
                acomodationId: self.AcomodationId()
            },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                self.Reviews(data.Reviews);
                document.getElementById("succesReview").style.visibility = "visible";
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });
    };
}