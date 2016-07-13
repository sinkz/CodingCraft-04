using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CodingCraft_04_Identity.Models
{
    public class Usuario : IdentityUser<long, UsuarioLogin, UsuarioGrupo, UsuarioIdentificacao>
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Usuario, long> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}