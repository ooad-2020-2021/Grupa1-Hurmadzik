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
        public int id;
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


    }
}
