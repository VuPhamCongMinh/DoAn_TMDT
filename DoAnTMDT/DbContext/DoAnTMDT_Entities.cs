﻿using DoAnTMDT.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTMDT.DbContext
{
    public class DoAnTMDT_Entities : IdentityDbContext<ApplicationUser>
    {
        public DoAnTMDT_Entities(DbContextOptions<DoAnTMDT_Entities> options) : base(options)
        {

        }

        public DbSet<Product> ProductTable { get; set; }
        public DbSet<Cart> CartTable { get; set; }
        public DbSet<CartDetail> CartDetailTable { get; set; }
        public DbSet<AddressAndPhone> DeliveryInfoTable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CartDetail>()
           .HasOne(i => i.Cart)
           .WithMany(c => c.CartDetails)
           .IsRequired()
           .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<AddressAndPhone>(entity => entity.HasCheckConstraint("CK_DeliveryInfoTable_AddressValueColumn", "[AddressValue] >= 1 AND [AddressValue] <=2"));
        }
    }
}
