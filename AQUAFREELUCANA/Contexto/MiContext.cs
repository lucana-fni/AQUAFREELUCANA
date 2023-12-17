using AQUAFREELUCANA.Models;
using Microsoft.EntityFrameworkCore;

namespace AQUAFREELUCANA.Contexto
{
    public class MiContext : DbContext
    {
        public MiContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
        }
    }
