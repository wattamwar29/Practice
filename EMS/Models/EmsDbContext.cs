﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace EMS.Models;

public partial class EmsDbContext : DbContext
{
    public virtual DbSet<Employee>Employees {get;set;} 
    public virtual DbSet<Department> Departments {get;set;} 
    public EmsDbContext()
    {
    }

    public EmsDbContext(DbContextOptions<EmsDbContext> options)
        : base(options)
    {
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    

        => optionsBuilder.UseSqlServer("User ID=sa;password= examlyMssql@123;server=localhost;Database=EmsDb;trusted_connection=false; Persist Security Info=False;Encrypt=false;");
    


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("Department");

            entity.Property(e => e.DeptName).HasMaxLength(30);
            entity.Property(e => e.Location)
                .HasMaxLength(30)
                .HasColumnName("location");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.HasIndex(e => e.DeptId, "IX_Employees_DeptId");

            entity.HasIndex(e => e.Email, "IX_Employees_Email").IsUnique();

            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(30);

            entity.HasOne(d => d.Dept).WithMany(p => p.Employees).HasForeignKey(d => d.DeptId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
