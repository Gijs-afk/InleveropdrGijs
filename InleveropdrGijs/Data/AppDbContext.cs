using Microsoft.EntityFrameworkCore;
using InleveropdrGijs.Models;

namespace InleveropdrGijs.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions)
            : base(contextOptions)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Winkel> Winkels { get; set; }
        public DbSet<Locatie> Locaties { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public IEnumerable<Account> InleveropdrGijs { get; internal set; }
    }
}
