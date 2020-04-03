using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace NationalParksClient.Models
{
  public class NationalParksClientFactory : IDesignTimeDbContextFactory<NationalParksClientContext>
  {

    NationalParksClientContext IDesignTimeDbContextFactory<NationalParksClientContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<NationalParksClientContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new NationalParksClientContext(builder.Options);
    }
  }
}