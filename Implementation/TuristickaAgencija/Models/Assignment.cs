using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.Models
{
    public class Assignment
    {
        [Key]
        [Required]
        public int id;
        [Required]
        public DateTime startingDate;
        [Required]
        public DateTime endingDate;

        public Assignment()
        {
        }

        public Assignment(int id, DateTime startingDate, DateTime endingDate)
        {
            this.id = id;
            this.startingDate = startingDate;
            this.endingDate = endingDate;
        }
    }
}
