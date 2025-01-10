using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PruebaCatedra3.src.Models;

namespace PruebaCatedra3.src.Data
{
    /// <summary>
    /// Clase para la conexión con la base de datos
    /// </summary>
    public class ApplicationDBContext : IdentityDbContext<User>
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="options">Opciones base</param>
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        /// <summary>
        /// Tabla de posts
        /// </summary>
        public DbSet<Post> Posts { get; set; } = null!;
    }
}