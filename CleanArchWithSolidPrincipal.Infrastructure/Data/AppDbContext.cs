﻿using CleanArchWithSolidPrincipal.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchWithSolidPrincipal.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Product> Products { get; set; }
    }
}
