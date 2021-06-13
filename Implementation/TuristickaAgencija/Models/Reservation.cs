using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.Models
{
    public class Reservation
    {
        [Key]
        [Required]
        public int id;
        [Required]
        public Arrangement arrangement;
        [Required]
        public double price;

        public Reservation()
        {
        }

        public Reservation(int id, Arrangement arrangement, double price)
        {
            this.id = id;
            this.arrangement = arrangement;
            this.price = price;
        }
    }
}
