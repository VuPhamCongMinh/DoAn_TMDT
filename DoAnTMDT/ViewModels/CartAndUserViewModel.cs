using DoAnTMDT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTMDT.ViewModels
{
    public class CartAndUserViewModel
    {
        public CartAndUserViewModel(IEnumerable<Cart> carts, ApplicationUser user)
        {
            Carts = carts;
            User = user;
        }

        public IEnumerable<Cart> Carts { get; }
        public ApplicationUser User { get; }

        
    }
}
