﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


public class AppDbContext:DbContext
{
    public DbSet<Wallet> Wallets { get; set; }
        public AppDbContext(DbContextOptions options):base(options)
    {
        
    }
}
