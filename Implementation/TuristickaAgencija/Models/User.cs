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
        public int id { get; set; }
        [Required]
        
        public string firstName;
        [Required]
        public string lastName;
        [Required]
        public string email;
        [Required]
        public Address address;

        public User()
        {
        }

        public User(int id, string firstName, string lastName, string email, Address address)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.address = address;
        }
    }
}
