function Gallery() {
    var site = this;
    site.Photos = ko.observableArray();
    site.Acomodations = ko.observableArray();

    site.AccomodationPhoto = ko.observable();
    site.Id = ko.observable();

    site.details = function (data) {
        site.Id(data.Id);
        site.AccomodationPhoto(data.AccomodationPhoto);
    }

    site.getPhotos = function (data) {
        var url = '/Home/GetPhotos';
        $.ajax(url, {
            data: { acomodationId: data.Id },
            type: "get",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                site.AccomodationPhoto(data.AccomodationPhoto);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ': ' + errorThrown);
            }
        });

        site.models.Gallery = function () {
            var self = this;
            this.itemsObservables = ko.observableArray();
            this.init = function (data) {
                ko.utils.arrayForEach(data, function (item) {
                    self.itemsObservables.push(new site.models.GalleryItem(item));
                });
            }
        }

        ko.utils.arrayForEach(data, function (item) {
            self.itemsObservables.push(new site.models.GalleryItem(item));
        });

        site.models.GalleryItem = function (el) {
            this.isSelected = ko.observable(false);
            this.src = el.href;
            this.caption = el.innerHTML;
        }

        $(function () {
            var viewModel = new site.models.Gallery();
            viewModel.init($('ul.origin a'));
            ko.applyBindings(viewModel, $('body').get(0));
        });
    }
}
