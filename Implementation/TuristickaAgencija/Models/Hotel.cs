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
        public int id;
        [Required]
        public Address address;
        [Required]
        public Rating rating;

    }
}
