using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.Models
{
    public class Address
    {
        [Key]
        [Required] 
        public int id;
        [Required]
        public string city;
        [Required]
        public string streetName;

        public Address()
        {
        }

        public Address(int id, string city, string streetName)
        {
            this.id = id;
            this.city = city;
            this.streetName = streetName;
        }
    }

}
