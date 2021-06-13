using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TuristickaAgencija.Models;

namespace TuristickaAgencija.Data
{
    public class HurmadzikContext : DbContext
    {
        public HurmadzikContext(DbContextOptions<HurmadzikContext> options)
            : base(options)
        {
        }
        public DbSet<TuristickaAgencija.Models.Client> Client { get; set; }
        public DbSet<TuristickaAgencija.Models.Arrangement> Arrangements { get; set; }
        public DbSet<TuristickaAgencija.Models.Address> Addresses { get; set; }
        public DbSet<TuristickaAgencija.Models.Activity> Activities { get; set; }
        public DbSet<TuristickaAgencija.Models.Assignment> Assignments { get; set; }
        public DbSet<TuristickaAgencija.Models.City> Cities { get; set; }
        //public DbSet<TuristickaAgencija.Models.ErrorViewModel> ErrorViewModels { get; set; }
        public DbSet<TuristickaAgencija.Models.Guide> Guides { get; set; }
        public DbSet<TuristickaAgencija.Models.Hotel> Hotels { get; set; }
        public DbSet<TuristickaAgencija.Models.Payment> Payments { get; set; }
        public DbSet<TuristickaAgencija.Models.Rating> Ratings { get; set; }
        public DbSet<TuristickaAgencija.Models.Reservation> Reservations { get; set; }
        public DbSet<TuristickaAgencija.Models.User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Arrangement>().ToTable("Arrangement");
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<Activity>().ToTable("Activity");
            modelBuilder.Entity<Assignment>().ToTable("Assignment");
            modelBuilder.Entity<City>().ToTable("City");
            modelBuilder.Entity<Guide>().ToTable("Guide");
            modelBuilder.Entity<Hotel>().ToTable("Hotel");
            modelBuilder.Entity<Payment>().ToTable("Payment");
            modelBuilder.Entity<Rating>().ToTable("Rating");
            modelBuilder.Entity<Reservation>().ToTable("Reservation");
            modelBuilder.Entity<User>().ToTable("User");

        }


    }
}
