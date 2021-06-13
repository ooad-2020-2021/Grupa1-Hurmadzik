using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.Models
{
    public class User
    {
        [Key]
        [Required]
        public int id;
        [Required]
        
        public string firstName;
        [Required]
        public string lastName;
        [Required]
        public string email;
        [Required]
        public Address address;

    }
}
