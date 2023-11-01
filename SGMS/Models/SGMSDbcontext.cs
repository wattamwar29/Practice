using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace SGMS.Models;
public class SGMSDbContext : DbContext
{
    public virtual DbSet<Student> Students{get;set;}
    public virtual DbSet<Grade> Grades{get;set;}
    public SGMSDbContext(){}
    public SGMSDbContext(DbContextOptions<SGMSDbContext>options):base (options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        if(!optionBuilder.IsConfigured)
        {
            optionBuilder.UseSqlServer("User ID=sa; password=examlyMssql@123; server=localhost;Database=SGMSDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");

        }
    }

}