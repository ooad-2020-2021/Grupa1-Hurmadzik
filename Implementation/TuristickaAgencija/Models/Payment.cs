using System.ComponentModel.DataAnnotations;

namespace TuristickaAgencija.Models
{
    public class Payment
    {
        [Key]
        [Required]
        public int id;
        [Required]
        public int price;
    }
}