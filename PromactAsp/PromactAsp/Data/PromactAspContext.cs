using Microsoft.EntityFrameworkCore;
using PromactAsp.Models;

namespace PromactAsp.Data
{
    public class PromactAspContext : DbContext
    {
        public PromactAspContext(DbContextOptions<PromactAspContext> options)
            : base(options)
        {
        }

        public DbSet<Message> Message { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Message>().HasData(
                new Message { messageid = 1, message = "I am Ironman", username = "Ironman", msglikes = 3000, iscomment = 0, parentid = 0, isshared = 0, shareid = 0 });
            modelBuilder.Entity<Message>().HasData(
               new Message { messageid = 2, message = "Bring me Thanos", username = "Thor", msglikes = 4000, iscomment = 0, parentid = 0, isshared = 0, shareid = 0 });
            modelBuilder.Entity<Message>().HasData(
               new Message { messageid = 3, message = "Avengers Assemble", username = "Captain America", msglikes = 2000, iscomment = 0, parentid = 0, isshared = 0, shareid = 0 });
        }
    }
}