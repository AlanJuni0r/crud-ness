using Microsoft.EntityFrameworkCore;

namespace CRUD_NESS_ALAN.Models.Contexto
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> option) : base(option) => Database.EnsureCreated();


        public DbSet<Personagem> Personagem { get; set; } 
    }
}
