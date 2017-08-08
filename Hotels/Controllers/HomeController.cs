using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Hotels.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
			//AcomodationService service = new AcomodationService();
           // service.GetAcomodations(1);

			return View();
        }

        public JsonResult GetAllCountries()
        {
            AcomodationService service = new AcomodationService();
            var countries = service.GetAllCountries();
            return new JsonResult() { Data = new { Countries = countries}, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult GetAllCountries()
        {
            AcomodationService service = new AcomodationService();
            var countries = service.GetAllCountries();
            return new JsonResult() { Data = new { Countries = countries }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAllCities()
        {
            AcomodationService service = new AcomodationService();
            var cities = service.GetAllCities();
            return new JsonResult() { Data = new { Cities=cities }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAllAcomodations()
        {
            AcomodationService service = new AcomodationService();
            var acomodations = service.GetAllAcomodations();
            return new JsonResult() { Data = new { Acomodations=acomodations }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAllFacilities()
        {
            AcomodationService service = new AcomodationService();
            var facilities = service.GetAllFacilities();
            return new JsonResult() { Data = new { Facilities=facilities }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAllAcomodationFacilities()
        {
            AcomodationService service = new AcomodationService();
            var acomodationFacilities = service.GetAllAcomodationFacilities();
            return new JsonResult() { Data = new { AcomodationFacilities=acomodationFacilities }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAllAcomodationNearbies()
        {
            AcomodationService service = new AcomodationService();
            var acomodationNearbies = service.GetAllAcomodationNearbies();
            return new JsonResult() { Data = new { AcomodationNearbies = acomodationNearbies }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAllNearbyPlaces()
        {
            AcomodationService service = new AcomodationService();
            var nearbyplaces = service.GetAllNearbyPlaces();
            return new JsonResult() { Data = new { Nearbyplaces=nearbyplaces }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAllReviews()
        {
            AcomodationService service = new AcomodationService();
            var reviews = service.GetAllReviews();
            return new JsonResult() { Data = new { Reviews=reviews }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAllRooms()
        {
            RoomService service = new RoomService();
            var rooms = service.GetAllRooms();
            return new JsonResult() { Data = new {Rooms=rooms },ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAllRoomReservations()
        {
            RoomService service = new RoomService();
            var roomReservations = service.GetAllRoomReservation();
            return new JsonResult() { Data = new { RoomReservations=roomReservations }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAllReservations()
        {
            RoomService service = new RoomService();
            var reservations = service.GetAllReservations();
            return new JsonResult() { Data = new { Reservations = reservations}, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetRooms(int acomodationId)
        {
            RoomService service = new RoomService();
            var rooms = service.GetRooms(acomodationId);
            return new JsonResult() { Data = new { Rooms = rooms }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


        public JsonResult GetRoomReservations(int roomId, int reservationId)
        {
            RoomService service = new RoomService();
            var rooms = service.GetRoomReservations(roomId,reservationId);
            return new JsonResult() { Data = new { Rooms = rooms }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetCities(int countryId)
        {
            AcomodationService service = new AcomodationService();
            var cities = service.GetCities(countryId);
            return new JsonResult() { Data = new { Cities=cities }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAcomodations(int cityId)
        {
            AcomodationService service = new AcomodationService();
            var acomodations = service.GetAcomodations(cityId);
            return new JsonResult() { Data = new { Acomodations=acomodations }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


        public JsonResult GetAcomodationsByType(AcomodationType type)
        {
            AcomodationService service = new AcomodationService();
            var acomodations = service.GetAcomodationsByType(type);
            return new JsonResult() { Data = new { Acomodations = acomodations }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAcomodationsByStars(int numberOfStars)
        {
            AcomodationService service = new AcomodationService();
            var acomodations = service.GetAcomodationsByStars(numberOfStars);
            return new JsonResult() { Data = new { Acomodations = acomodations }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


        public JsonResult GetRoomsByPrice(float price1, float price2)
        {
            AcomodationService service = new AcomodationService();
            var rooms = service.GetRoomsByPrice(price1,price2);
            return new JsonResult() { Data = new {Rooms=rooms }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetRoomsOrderByPrice(bool asc)
        {
            AcomodationService service = new AcomodationService();
            var rooms = service.GetRoomsOrderByPrice(asc);
            return new JsonResult() { Data = new { Rooms = rooms }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAcomodationsOrderByStars(bool asc)
        {
            AcomodationService service = new AcomodationService();
            var acomodations = service.GetAcomodationsOrderByStars(asc);
            return new JsonResult() { Data = new {Acomodations=acomodations }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


        public JsonResult GetFacilities(int acomodationId)
        {
            AcomodationService service = new AcomodationService();
            var acomodationFacilities = service.GetFacilities(acomodationId);
            return new JsonResult() { Data = new { Acomodations = acomodationFacilities }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAcomodationNearbies(int acomodationId,int nearbyId)
        {
            AcomodationService service = new AcomodationService();
            var acomodations = service.GetAcomodationNearbies(acomodationId,nearbyId);
            return new JsonResult() { Data = new { Acomodations = acomodations }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetReviews(int acomodationId)
        {
            AcomodationService service = new AcomodationService();
            var acomodations = service.GetReviews(acomodationId);
            return new JsonResult() { Data = new { Acomodations = acomodations }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult AddRoom(RoomType type, float price, int numberOdAdults, int numberOfChildren, byte[] photo, string description, int numberOfRoomsAvailable, int accomodationId)
        {
            RoomService service = new RoomService();
            var room = service.AddRoom(type,price, numberOdAdults,  numberOfChildren, photo,  description,  numberOfRoomsAvailable,  accomodationId);
            return new JsonResult() { Data = new {Room=room}, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult AddRoomReservation(DateTime dateOfStart, DateTime dateOfEnd, int roomId, int reservationId)
        {
            RoomService service = new RoomService();
            var room = service.AddRoomReservation(dateOfStart, dateOfEnd, roomId, reservationId);
            return new JsonResult() { Data = new { Room = room }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult AddCountry(string name)
        {
            AcomodationService service = new AcomodationService();
            var country = service.AddCountry(name);
            return new JsonResult() { Data = new { Country = country }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult AddCity(string name,int countryId)
        {
            AcomodationService service = new AcomodationService();
            var city = service.AddCity(name,countryId);
            return new JsonResult() { Data = new { City=city }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


        public JsonResult AddAcomodation(AcomodationType type, string address, string name, int numberOfStars, byte[] photo, string description, string phoneNumber, string website, int cityId)
        {
            AcomodationService service = new AcomodationService();
            var acomodation = service.AddAcomodation(type, address, name, numberOfStars, photo, description, phoneNumber, website, cityId);
            return new JsonResult() { Data = new { Acomodation=acomodation }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult AddReservation(DateTime dateofReservation, DateTime dateOfStart, DateTime dateOfEnd, float totalPayment, int numberOfPeople, int roomReservationId, int userId)
        {
            AcomodationService service = new AcomodationService();
            var resevation = service.AddReservation(dateofReservation, dateOfStart, dateOfEnd, totalPayment, numberOfPeople, roomReservationId, userId);
            return new JsonResult() { Data = new { Reservation=resevation}, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult AddFacility(string description)
        {
            AcomodationService service = new AcomodationService();
            var facility = service.AddFacility(description);
            return new JsonResult() { Data = new { Facility=facility }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult AddNearby(string name, string location, NearbyType type)
        {
            AcomodationService service = new AcomodationService();
            var nearbyPlace = service.AddNearby(name, location, type);
            return new JsonResult() { Data = new { NearbyPlace=nearbyPlace }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult AddReview(DateTime date, string description, int userId, int acomodationId)
        {
            AcomodationService service = new AcomodationService();
            var review = service.AddReview(date,description,userId,acomodationId);
            return new JsonResult() { Data = new {Review=review }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult AddAcomodationNearby(int nearbyId, int acomodationId)
        {
            AcomodationService service = new AcomodationService();
            var acomodationNearbyPlace = service.AddAcomodationNearby(nearbyId, acomodationId);
            return new JsonResult() { Data = new { AcomodationNearbyPlace = acomodationNearbyPlace }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


        public JsonResult AddAcomodationFacility(int facilityId, int acomodationId)
        {
            AcomodationService service = new AcomodationService();
            var acomodationFacility = service.AddAcomodationFacility(facilityId, acomodationId);
            return new JsonResult() { Data = new { AcomodationFacility=acomodationFacility }, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }






    }
}