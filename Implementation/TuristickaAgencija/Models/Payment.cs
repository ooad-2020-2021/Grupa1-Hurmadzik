using System.ComponentModel.DataAnnotations;

namespace TuristickaAgencija.Models
{
    public class Payment
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public int price;

        public Payment()
        {
        }

        public Payment(int id, int price)
        {
            this.id = id;
            this.price = price;
        }
    }
}