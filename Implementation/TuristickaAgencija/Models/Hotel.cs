using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.Models
{
    public class Hotel
    {
        [Key]
        [Required] 
        public int id { get; set; }
        [Required]
        public Address address;
        [Required]
        public Rating rating;

        public Hotel()
        {
        }

        public Hotel(int id, Address address, Rating rating)
        {
            this.id = id;
            this.address = address;
            this.rating = rating;
        }
    }
}
