function Cities() {
	var self = this;
	self.Cities = ko.observableArray();
	self.Id = ko.observable();
	self.Name = ko.observable();

	self.details = function (data) {
		self.Id(data.Id);
		self.Name(data.Name);
	};

	self.refresh = function () {
		var url = '/Home/GetAllCities';
		$.ajax(url, {
			type: "get",
			contentType: "application/json; charset=utf-8",
			success: function (data) {
				//console.log(data);
				self.Cities(data.Cities);
			},
			error: function (jqXHR, textStatus, errorThrown) {
				console.log(textStatus + ': ' + errorThrown);
			}
		});
	};

	
}