using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.Models
{
    public class Arrangement
    {
        [Key] 
        [Required]
        public int id { get; set; }
        [Required]
        public DateTime dateOfArrival;
        [Required]
        public DateTime dateOfDeparture;
        [Required]
        public int passengerCount;
        [Required]
        public double price;
        [Required]
        public Guide guide;
        [Required]
        public Hotel hotel;
        [Required]
        public List<Activity> activities;

        public Arrangement()
        {
        }

        public Arrangement(int id, DateTime dateOfArrival, DateTime dateOfDeparture, int passengerCount, double price, Guide guide, Hotel hotel, List<Activity> activities)
        {
            this.id = id;
            this.dateOfArrival = dateOfArrival;
            this.dateOfDeparture = dateOfDeparture;
            this.passengerCount = passengerCount;
            this.price = price;
            this.guide = guide;
            this.hotel = hotel;
            this.activities = activities;
        }
    }
}
