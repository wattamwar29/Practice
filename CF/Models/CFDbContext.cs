using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace CF.Models;
public class CFDbContext : DbContext
{
    public virtual DbSet<Product>Products{get;set;}
    public CFDbContext(){}
    public CFDbContext(DbContextOptions<CFDbContext>options):base(options)
    {
    }
        protected override void OnConfiguring (DbContextOptionsBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer("User ID=sa; password=examlyMssql@123; server=localhost;Database=CFDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
            }
        }

    }

