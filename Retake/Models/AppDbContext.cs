using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Mvc;
namespace Retake.Models;
public class AppDbContext : DbContext
{
    public virtual DbSet<Books>Books{get;set;}
    public AppDbContext(){}
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    if(!optionsBuilder.IsConfigured)
    {
        optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=bdb;trusted_connection=false;Persist Security Info=False;Encrypt=False");
    }
    }
}