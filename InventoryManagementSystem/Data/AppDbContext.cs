﻿using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InventoryManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
