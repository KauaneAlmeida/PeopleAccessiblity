using DisabledPeopleRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace DisabledPeopleRegister
{
    public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
    {
        public DbSet<Usuario> User { get; set; }

        public DbSet<ParticipacaoUsuario> UserParticipation { get; set; }
        public DbSet<AtividadesUsuario> Activities { get; set; }
        
        
    }
}
