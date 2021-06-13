using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.Models
{
    public class Rating
    {
        [Key]
        [Required]
        public int id;
        [Required]
        public int voteCount;
        
        public List<Tuple<int,int>>votes;
    }
}
