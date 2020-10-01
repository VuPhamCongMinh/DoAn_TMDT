using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTMDT.Models
{
    public class Cart
    {
        [Key]
        public int ID { get; set; }
        public string CartID { get; set; }
        public string UserID { get; set; }
        public bool IsPayed { get; set; }
        public ICollection<CartDetail> CartDetails { get; set; }

    }
}
