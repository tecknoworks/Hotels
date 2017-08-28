using Hotels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime DateOfReservation { get; set; }
        public DateTime  DateOfStart { get; set; }
        public DateTime DateOfEnd { get; set; }
        public float TotalPayment { get; set; }
        public int NumberOfPeople { get; set; }
        public int RoomReservationId { get; set; }
        public RoomReservation Room { get; set; }
        public string User_Id { get; set; }
        public ApplicationUser User { get; set;}
        public Reservation()
		{

		}

        public Reservation(DateTime dateOfReservation,DateTime dateOfStart,DateTime dateOfEnd,float totalPayment,int numberOfPeople,int roomReservationId,string userId)
        {
            this.DateOfReservation = dateOfReservation;
            this.DateOfStart =dateOfStart;
            this.DateOfEnd = dateOfEnd;
            this.TotalPayment = totalPayment;
            this.NumberOfPeople = numberOfPeople;
            this.RoomReservationId = roomReservationId;
            this.User_Id = userId;
        }
    }
}
