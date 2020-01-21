using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Interfaces;
using MVC.Models;

namespace MVC.Services
{
    public class ProductService : GenericService<Product>, IProduct
    {

        public ProductService(MVCDbContext context) : base(context)
        { }
        
    }
}