using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTMDT.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Point { get; set; }
        public ICollection<AddressAndPhone> DeliveryInfo { get; set; }
    }
}
