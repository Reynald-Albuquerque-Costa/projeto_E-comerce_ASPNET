using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Egeladinho.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace Egeladinho.Src.Contexts
{
    public class EgeladinhoDBC : DbContext
    {
        public EgeladinhoDBC(DbContextOptions<EgeladinhoDBC>options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
    }
}