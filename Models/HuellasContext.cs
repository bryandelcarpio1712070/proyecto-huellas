using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace proyecto_huellas.Models
{
    public class HuellasContext : IdentityDbContext
    {
        public HuellasContext(DbContextOptions<HuellasContext> options)
        : base(options){

        }
        

        public DbSet<P_Adopcion> Adopcion { get; set; }
        public DbSet<P_Perdidos> P_Perdidos { get; set; }
        public DbSet<P_Veterinarias> P_Veterinarias { get; set; }
        public DbSet<Usuario> Usuario{get;set;}
        
    }
}