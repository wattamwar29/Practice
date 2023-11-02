using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
namespace Practice.Models;
// public class PDbContext : DbContext
// {
//     public PDbContext(){}
//     public virtual DbSet<Practice> Practice{get;set;}
//     public PDbContext(DbContextOptions<PDbContext>options):base(options)
//     {}

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//         if(!optionsBuilder.IsConfigured)
//         {
//             optionsBuilder.UseSqlServer("User ID=sa; password=examlyMssql@123; server=localhost;Database=EmsDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
//         }
//     }
// }





public class PDbContext : DbContext
{
    public virtual DbSet<Practice>Practice{get;set;}
    public PDbContext (){}
    public PDbContext(DbContextOptions<Practice>options)
}