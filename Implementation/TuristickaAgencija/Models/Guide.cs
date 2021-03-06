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
        public int id { get; set; }
        [Required]
        public Rating rating;
        [Required]
        public Assignment assignment;

        public Guide()
        {
        }

        public Guide(int id, Rating rating, Assignment assignment)
        {
            this.id = id;
            this.rating = rating;
            this.assignment = assignment;
        }
    }
}
