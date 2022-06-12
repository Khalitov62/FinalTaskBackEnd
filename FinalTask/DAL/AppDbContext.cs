using FinalTask.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalTask.DAL
{
    public class AppDbContext:IdentityDbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Card> Carts { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Statistica> Statics { get; set; }
    }
}
