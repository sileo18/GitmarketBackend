using Microsoft.EntityFrameworkCore;
using MusicsAPI.Domains;

namespace MusicsAPI.Context
{
    public partial class InLockContext : DbContext
    {
        protected InLockContext(DbContextOptions<InLockContext> opts)
            : base(opts)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Listum> Lista { get; set ; }

        public DbSet<Item> Item { get; set; }

        public DbSet<VersaoListum> Versao_Lista { get; set ; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
