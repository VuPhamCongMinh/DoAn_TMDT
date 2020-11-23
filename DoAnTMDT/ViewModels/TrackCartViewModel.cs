using DoAnTMDT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTMDT.ViewModels
{
    public class TrackCartViewModel
    {
        public IEnumerable<Cart> PayedCart { get; }
        public IEnumerable<Cart> UnpayedCart { get; }

        public TrackCartViewModel(IEnumerable<Cart> payedCart, IEnumerable<Cart> unpayedCart)
        {
            PayedCart = payedCart;
            UnpayedCart = unpayedCart;
        }
    }
}
