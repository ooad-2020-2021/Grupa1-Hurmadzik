using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.Models
{
    //nista
    public class Activity
    {
        [Key] 
        [Required]
        public int id;

        [Required]
        public City grad;
        public string description;
        [Required]
        public int daysRequired;

        public string header;
    }
}
