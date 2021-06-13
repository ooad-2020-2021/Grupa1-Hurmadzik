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
    }
}
