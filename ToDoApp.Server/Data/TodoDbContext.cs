using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ToDoApp.Server.Models;

namespace ToDoApp.Server.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>()
                .Property(t => t.CompletedDate)
                .HasConversion(v=>v.UtcDateTime,v=>new DateTimeOffset(v,TimeSpan.Zero));

            modelBuilder.Entity<Todo>()
                .Property(t => t.CreatedDate)
                .HasConversion(v => v.UtcDateTime, v => new DateTimeOffset(v, TimeSpan.Zero));

            modelBuilder.Entity<Todo>()
                .Property(t => t.DeletedDate)
                .HasConversion(v => v.UtcDateTime, v => new DateTimeOffset(v, TimeSpan.Zero));
        }
    }
}
