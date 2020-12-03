using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAnTMDT.DbContext;
using DoAnTMDT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnTMDT.Controllers
{
    public class AdminController : Controller
    {
        private readonly DoAnTMDT_Entities _context;

        public AdminController(DoAnTMDT_Entities context)
        {
            _context = context;
        }

        public IActionResult Product()
        {
         
            return View(_context.ProductTable.ToList());
        }

        public IActionResult Order()
        {
            return View(_context.CartTable.ToList());
        }

        public IActionResult User()
        {
            return View(_context.Users.ToList());
        }

        public IActionResult DetailOrder(string id)
        {
            return View(_context.CartDetailTable.Where(s => s.CartID == id).Include(x=>x.Product).ToList());
        }

        public IActionResult DetailProduct(int id)
        {
            return View(_context.ProductTable.Where(s => s.ProductID == id).FirstOrDefault());
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            return View(_context.ProductTable.Where(s => s.ProductID == id).FirstOrDefault());
        }

       
        [HttpPost]
        public IActionResult EditProduct(int id, Product cate)
        {
            try
            {
                // TODO: Add update logic here
                //if (cate.ImageUpload != null)
                //{
                //    string filename = Path.GetFileNameWithoutExtension(cate.ImageUpload.FileName);
                //    string extension = Path.GetExtension(cate.ImageUpload.FileName);
                //    filename = filename + extension;
                //    cate.Images = "~/images/" + filename;
                //    cate.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/images/"), filename));
                //}
                cate = _context.ProductTable.Where(s => s.ProductID == id).FirstOrDefault();
                TryUpdateModelAsync(cate);
                _context.SaveChanges();
                return RedirectToAction("Product");
            }
            catch
            {
                return View();
            }
        }

        // Delete product
        [HttpGet]
        public ActionResult DeleteProduct(int id)
        {
            return View(_context.ProductTable.Where(s => s.ProductID == id).FirstOrDefault());
        }

        
        [HttpPost]
        public ActionResult DeleteProduct(int id, Product cate)
        {
            try
            {
                // TODO: Add delete logic here
                cate = _context.ProductTable.Where(s => s.ProductID == id).FirstOrDefault();
                _context.ProductTable.Remove(cate);
                _context.SaveChanges();
                return RedirectToAction("Product");
            }
            catch
            {
                return View();
            }
        }

        // Delete user
        [HttpGet]
        public ActionResult DeleteUser(string id)
        {
            return View(_context.Users.Where(s => s.Id == id).FirstOrDefault());
        }

        
        [HttpPost]
        public ActionResult DeleteUser(string id, ApplicationUser cate)
        {
            try
            {
                // TODO: Add delete logic here
                cate = _context.Users.Where(s => s.Id == id).FirstOrDefault();
                _context.Users.Remove(cate);
                _context.SaveChanges();
                return RedirectToAction("User");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AddProduct()
        {
            Product sa = new Product();
            return View(sa);
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult AddProduct(Product cate)
        {
            try
            {
                //if (cate.ImageUpload != null)
                //{
                //    string filename = Path.GetFileNameWithoutExtension(cate.ImageUpload.FileName);
                //    string extension = Path.GetExtension(cate.ImageUpload.FileName);
                //    filename = filename + extension;
                //    cate.Images = "~/images/" + filename;
                //    cate.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/images/"), filename));
                //}
                _context.ProductTable.Add(cate);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}