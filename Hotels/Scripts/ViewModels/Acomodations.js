function Acomodations(){
    var self = this;
    self.Acomodations = ko.observableArray();
    self.Id = ko.observable();
    self.Type = ko.observable();
    self.Address = ko.observable();
    self.Name = ko.observable();
    self.NumberOfStars = ko.observable();
    self.Description = ko.observable();
    self.PhoneNumber = ko.observable();
    self.WebSite = ko.observable();

    self.details=function(data){
        self.Id(data.Id);
        self.Type(data.Type);
        self.Address(data.Address);
        self.Name (data.Name);
        self.NumberOfStars(data.NumberOfStars);
        self.Description(data.Description);
        self.PhoneNumber(data.PhoneNumber);
        self.WebSite (data.WebSite);
    }

    self.refresh=function(){
        var url = '/Home/GetAllAcomodations';
        $.ajax(url, {
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
}