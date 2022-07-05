using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodShop.Models;

namespace FoodShop.Data
{
    public class FoodShopContext : DbContext
    {
        public FoodShopContext (DbContextOptions<FoodShopContext> options)
            : base(options)
        {
        }

        public DbSet<FoodShop.Models.Product> Product { get; set; }
    }
}
