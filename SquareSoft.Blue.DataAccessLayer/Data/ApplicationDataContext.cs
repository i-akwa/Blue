using Microsoft.AspNet.Identity.EntityFramework;
using SquareSoft.Blue.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSoft.Blue.DataAccessLayer.Data
{
    public class ApplicationDataContext:IdentityDbContext
    {
        public ApplicationDataContext() : base("DefaultConnection")
        { }

        public static ApplicationDataContext Create()
        {
            return new ApplicationDataContext();
        }
        public DbSet<UsersReg> staffs { get; set; }
        public DbSet<Sales> sales { get; set; }
        public DbSet<Stock> stocks { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<ProductSales> products_sales { get; set; }
    }
}
