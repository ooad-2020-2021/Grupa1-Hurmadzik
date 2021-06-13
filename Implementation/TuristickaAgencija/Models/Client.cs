using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.Models
{
    public class Client
    {
        [Key]
        [Required]
        public int id;
        [Required]
        public Reservation reservation;
        [Required]
        public Payment payment;

    }
}
