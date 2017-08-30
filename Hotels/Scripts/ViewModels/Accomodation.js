function Accomodation() {

    var self = this;
    self.Countries = ko.observableArray();
    self.Cities = ko.observableArray();


    self.Id = ko.observable();
    self.Name = ko.observable();

    self.details = function (data) {
        self.Id(data.Id);
        self.Name(data.Name);
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
                    //redirect('Account/Login');
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

}