using LogisticAppDAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticAppDAL
{
    public class LogisticDbContext:IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-Q78RQP5\SQLEXPRESS;Initial Catalog=LogisticDb;Integrated Security=True");

        }
        
        public DbSet<Item> Items { get; set; }
        public DbSet<Item_Category> Item_Categories{ get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Vender> Venders { get; set; }

        public DbSet<Quotation> Quotations { get; set; }
        public DbSet<Quotation_Item> Quotation_Items { get; set; }
        public DbSet<PO> POs { get; set; }
        public DbSet<PO_Item> PO_Items { get; set; }
        public DbSet<Purchase_Bill> Purchase_Bills { get; set; }
        public DbSet<Purchase_Bill_Item> Purchase_Bill_Items { get; set; }
        public DbSet<Invoice> Invoices{ get; set; }
        public DbSet<Invoice_Item> Invoice_Items { get; set; }
        public DbSet<Delivery_Chalan> Delivery_Chalans { get; set; }
        public DbSet<Delivery_Chalan_Item> Delivery_Chalan_Items { get; set; }


        public DbSet<Payment> Payments{ get; set; }
        public DbSet<Deposit_Slip> Deposit_Slips{ get; set; }
        public DbSet<Cheque> Cheques{ get; set; }
        public DbSet<Bank> Banks{ get; set; }
    }
}
