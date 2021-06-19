using Microsoft.EntityFrameworkCore;
using Website_TecSys_NetCore.Models;

namespace Website_TecSys_NetCore.Data
{
    public class TecsysDbContext : DbContext
    {
        public DbSet<Configuracoes> Configuracoes{get;set;}
        public TecsysDbContext(DbContextOptions<TecsysDbContext> options):base(options)
        {
        }
    }
}