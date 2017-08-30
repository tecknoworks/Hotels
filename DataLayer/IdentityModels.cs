﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using DataLayer;

namespace Hotels.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext()
			: base("DefaultConnection", throwIfV1Schema: false)
		{
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}

		public DbSet<Country> Countries { get; set; }

		public DbSet<City> Cities { get; set; }

		public DbSet<Acomodation> Acomodations { get; set; }

		public DbSet<Facility> Facilities { get; set; }

		public DbSet<AcomodationFacility> AcomodationFacilities { get; set; }

		public DbSet<Nearby> NearbyPlaces { get; set; }

		public DbSet<AcomodationNearby> AcomodationNearbyPlaces { get; set; }

		public DbSet<Review> Reviews { get; set; }

		public DbSet<Room> Rooms { get; set; }

		public DbSet<RoomReservation> RoomReservations { get; set; }

		public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Photo> Photos { get; set; }

	}
}