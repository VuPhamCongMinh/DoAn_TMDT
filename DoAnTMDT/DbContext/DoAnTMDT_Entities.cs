using DoAnTMDT.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTMDT.DbContext
{
    public class DoAnTMDT_Entities : IdentityDbContext<IdentityUser>
    {
        public DoAnTMDT_Entities(DbContextOptions<DoAnTMDT_Entities> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Product>().HasData(
            new Product
            {
                ProductID = 1,
                ProductName = "'thinkthank' print oversize T-shirt",
                ProductPrice = 650,
                SmallSizeQuantity = 10,
                MediumSizeQuantity = 10,
                LargeSizeQuantity = 10,
                ImagePath = "~/images/tshirt-1.jpg",
            },
             new Product
             {
                 ProductID = 2,
                 ProductName = "Gucci disk print oversize T-shirt",
                 ProductPrice = 300,
                 SmallSizeQuantity = 10,
                 MediumSizeQuantity = 10,
                 LargeSizeQuantity = 10,
                 ImagePath = "~/images/tshirt-1.jpg",
             },
              new Product
              {
                  ProductID = 3,
                  ProductName = "Gucci Hawaii print oversize T-shirt",
                  ProductPrice = 450,
                  SmallSizeQuantity = 10,
                  MediumSizeQuantity = 10,
                  LargeSizeQuantity = 10,
                  ImagePath = "~/images/tshirt-1.jpg",
              },
               new Product
               {
                   ProductID = 4,
                   ProductName = "Double G stripe wool cotton polo",
                   ProductPrice = 550,
                   SmallSizeQuantity = 10,
                   MediumSizeQuantity = 10,
                   LargeSizeQuantity = 10,
                   ImagePath = "~/images/tshirt-1.jpg",
               },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Striped T-shirt with piglet patch",
                    ProductPrice = 750,
                    SmallSizeQuantity = 10,
                    MediumSizeQuantity = 10,
                    LargeSizeQuantity = 10,
                    ImagePath = "~/images/tshirt-1.jpg",
                },
                 new Product
                 {
                     ProductID = 6,
                     ProductName = "Gucci Sexiness print oversize T-shirt",
                     ProductPrice = 420,
                     SmallSizeQuantity = 10,
                     MediumSizeQuantity = 10,
                     LargeSizeQuantity = 10,
                     ImagePath = "~/images/tshirt-1.jpg",
                 },
                  new Product
                  {
                      ProductID = 7,
                      ProductName = "Original Gucci print oversize T-shirt",
                      ProductPrice = 280,
                      SmallSizeQuantity = 10,
                      MediumSizeQuantity = 10,
                      LargeSizeQuantity = 10,
                      ImagePath = "~/images/tshirt-1.jpg",
                  },
                   new Product
                   {
                       ProductID = 8,
                       ProductName = "Disney x Gucci oversize T-shirt",
                       ProductPrice = 600,
                       SmallSizeQuantity = 10,
                       MediumSizeQuantity = 10,
                       LargeSizeQuantity = 10,
                       ImagePath = "~/images/tshirt-1.jpg",
                   }
        );
        }
        public DbSet<Product> ProductTable { get; set; }
        public DbSet<Cart> CartTable { get; set; }
        public DbSet<CartDetail> CartDetailTable { get; set; }
    }
}
