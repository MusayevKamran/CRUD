using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data
{
    public class MVCDbContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }

        public MVCDbContext(DbContextOptions<MVCDbContext> options)
            : base(options)
        { }
    }
}
