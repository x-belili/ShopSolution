﻿namespace ShopSolution.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using ShopSolution.Web.Data.Entities;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
