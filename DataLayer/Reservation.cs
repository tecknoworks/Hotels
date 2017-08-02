﻿using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime DateOfReservation { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfEnd { get; set; }
        public float TotalPayment { get; set; }
        public int NumberOfPeople { get; set; }
        public int RoomReservationId { get; set; }
        public RoomReservation Room { get; set; }
        public int UserId { get; set; }
        public ApplicationUser User { get; set;}

        public Reservation(int Id,DateTime DateOfReservation,DateTime DateOfStart,DateTime DateOfEnd,float TotalPayment,int NumberOfPeople,int RoomReservationId,int UserId)
        {
            this.Id = Id;
            this.DateOfReservation = DateOfReservation;
            this.DateOfStart = DateOfStart;
            this.DateOfEnd = DateOfEnd;
            this.TotalPayment = TotalPayment;
            this.NumberOfPeople = NumberOfPeople;
            this.RoomReservationId = RoomReservationId;
            this.UserId = UserId;
        }
    }
}
