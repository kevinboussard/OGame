﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ImieApplication.Models
{
    // Vous pouvez ajouter des données de profil pour l'utilisateur en ajoutant plus de propriétés à votre classe ApplicationUser ; consultez http://go.microsoft.com/fwlink/?LinkID=317594 pour en savoir davantage.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Notez qu'authenticationType doit correspondre à l'élément défini dans CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Ajouter les revendications personnalisées de l’utilisateur ici
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public System.Data.Entity.DbSet<ImieApplication.Models.OGameCoordinate> OGameCoordinates { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<ImieApplication.Models.OGameTypeBuilding> OGameTypeBuildings { get; set; }

        public System.Data.Entity.DbSet<ImieApplication.Models.OGamePlanet> OGamePlanets { get; set; }

        public System.Data.Entity.DbSet<ImieApplication.Models.OGameResource> OGameResources { get; set; }

        public System.Data.Entity.DbSet<ImieApplication.Models.OGameFleet> OGameFleets { get; set; }

        public System.Data.Entity.DbSet<ImieApplication.Models.OGameSpaceShip> OGameSpaceShips { get; set; }
    }
}