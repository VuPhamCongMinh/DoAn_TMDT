using DoAnTMDT.DbContext;
using DoAnTMDT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTMDT.ViewModels
{
    public class DisplayProductsViewComponent : ViewComponent
    {
        private readonly DoAnTMDT_Entities _context;
        public DisplayProductsViewComponent(DoAnTMDT_Entities context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke(int currentPage = 1)
        {
            return View("_ShowProduct", GetItemsAsync(currentPage));

        }


        private IEnumerable<Product> GetItemsAsync(int currentPage = 1)
        {
            int itemToDisplay = 8;
            int itemToSkip = (currentPage - 1) * itemToDisplay;
            return _context.ProductTable.Skip(itemToSkip).Take(itemToDisplay).ToList();
        }
    }
}
