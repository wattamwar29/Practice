using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace Retake.Models;
public class AppDbContext : DbContext
{
    public virtual DbSet<Books>Books{get;set;}
    public AppDbContext(){}
    public AppDbContext(DbContext)
}