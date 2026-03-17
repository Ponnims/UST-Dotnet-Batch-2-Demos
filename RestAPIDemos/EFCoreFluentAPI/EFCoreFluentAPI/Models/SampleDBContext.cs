using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreFluentAPI.Models
{
    public class SampleDBContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=USTEFCOREFLUENTAPI;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("tbl_Customer");
            modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            modelBuilder.Entity<Customer>().Property(c => c.Id).ValueGeneratedNever().IsRequired();

            modelBuilder.Entity<Customer>().Property(c => c.Name).HasColumnName("Cust_Name").IsRequired(); ;
            modelBuilder.Entity<Customer>().Property(c => c.Name).HasColumnType("varchar(25)").IsRequired();

            modelBuilder.Entity<Customer>().Property(c => c.City).HasDefaultValue("Chennai");

            modelBuilder.Entity<Customer>().HasCheckConstraint("ck_age", "Age>=18");









            modelBuilder.Entity<Product>().ToTable("tbl_Product");
            modelBuilder.Entity<Category>().ToTable("tbl_Category");
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Category>().HasKey(c => c.Id);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);


            modelBuilder.Entity<Product>().HasIndex(p => p.Name).IsUnique();









        }
    }
}
