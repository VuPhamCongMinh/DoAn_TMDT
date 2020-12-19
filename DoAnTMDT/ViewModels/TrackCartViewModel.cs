using DoAnTMDT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTMDT.ViewModels
{
    public class TrackCartViewModel
    {
        public IEnumerable<Cart> CompletedOrders { get; }
        public IEnumerable<Cart> InCompletedOrders { get; }

        public TrackCartViewModel(IEnumerable<Cart> completedOrders, IEnumerable<Cart> inCompletedOrders)
        {
            CompletedOrders = completedOrders;
            InCompletedOrders = inCompletedOrders;
        }
    }
}
