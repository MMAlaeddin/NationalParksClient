using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NationalParksClient.Models
{
    public class NationalParksClientContext : IdentityDbContext<ApplicationUser>
    {
      public NationalParksClientContext(DbContextOptions options) : base(options) { }
    }
}