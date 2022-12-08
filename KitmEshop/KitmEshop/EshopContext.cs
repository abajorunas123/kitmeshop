﻿using KitmEshop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitmEshop
{
    public class EshopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public EshopContext(DbContextOptions<EshopContext> options) : base(options)
        {
        }
    }
}
