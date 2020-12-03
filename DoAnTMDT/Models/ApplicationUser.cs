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
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
