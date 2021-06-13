using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.Models
{
    public class City
    {
        [Key]
        [Required]
        public int id;
        [Required]
        public string name;

        public City()
        {
        }

        public City(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
