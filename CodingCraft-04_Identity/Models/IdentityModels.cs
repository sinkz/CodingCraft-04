using CodingCraft_04_Identity.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentitySample.Models
{
    

    public class ApplicationDbContext : IdentityDbContext<Usuario, Grupo, long, UsuarioLogin, UsuarioGrupo, UsuarioIdentificacao>
    {
        public ApplicationDbContext()
            : base("CodingCraft04_Identity")
        {
        }

        static ApplicationDbContext()
        {
            // Set the database intializer which is run once during application start
            // This seeds the database with admin user credentials and admin role
            Database.SetInitializer<ApplicationDbContext>(new ApplicationDbInitializer());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}