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
        public int id { get; set; }

        [Required]
        public City grad { get; set; }
        public string description;
        [Required]
        public int daysRequired { get; set; }

        public string header;

        public Activity()
        {
        }

        public Activity(int id, City grad, string description, int daysRequired, string header)
        {
            this.id = id;
            this.grad = grad;
            this.description = description;
            this.daysRequired = daysRequired;
            this.header = header;
        }
    }
}
