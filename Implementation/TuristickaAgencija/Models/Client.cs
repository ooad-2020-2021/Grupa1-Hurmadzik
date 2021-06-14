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
        public int id { get; set; }
        [Required]
        public Reservation reservation;
        [Required]
        public Payment payment;

        public Client()
        {
        }

        public Client(int id, Reservation reservation, Payment payment)
        {
            this.id = id;
            this.reservation = reservation;
            this.payment = payment;
        }
    }
}
