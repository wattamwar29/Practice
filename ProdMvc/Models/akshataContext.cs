using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace ProdMvc.Models;
public class akshataContext:DbContext
{
    public virtual DbSet<Product> Product{get;set;}
    public akshataContext(){}
    public akshataContext(DbContextOptions<akshataContext>options):base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("User ID=sa; password=examlyMssql@123; server=localhost;Database=Akshata;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
        }
    }

}
