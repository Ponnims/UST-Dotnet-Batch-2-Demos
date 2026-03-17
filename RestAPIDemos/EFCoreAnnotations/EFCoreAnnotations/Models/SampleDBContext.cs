using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAnnotations.Models
{
    internal class SampleDBContext:DbContext
    {
        public DbSet<Learner> Learners { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=UST_EFCORE_Annotations;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
