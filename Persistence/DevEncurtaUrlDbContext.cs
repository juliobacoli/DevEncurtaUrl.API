using DevEncurtaUrl.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevEncurtaUrl.API.Persistence
{
    public class DevEncurtaUrlDbContext : DbContext
    {

        public DevEncurtaUrlDbContext(DbContextOptions<DevEncurtaUrlDbContext> options) : base(options)
        {
            
        }

        public DbSet<ShortenedCustomLink> Links { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurando a chave primaria e dizendo que ela é o Id
            modelBuilder.Entity<ShortenedCustomLink>(e =>{
                e.HasKey(l => l.Id);
            });
        }
    }
}
