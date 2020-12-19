using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTMDT.Models
{
    public class AddressAndPhone
    {
        [Key]
        public int ID { get; set; }
        public ApplicationUser User { get; set; }
        public int AddressValue { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

    }
}
