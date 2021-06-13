using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.Models
{
    public class Guide
    {
        [Key]
        [Required]
        public int id;
        [Required]
        public Rating rating;
        [Required]
        public Assignment assignment;
    }
}
