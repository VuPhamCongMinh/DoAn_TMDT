using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTMDT.Models
{
    public class CartDetail
    {
        [Key]
        public int CartDetailID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }
        [ForeignKey("Cart")]
        public string CartID { get; set; }
        public Cart Cart { get; set; }
    }
}
