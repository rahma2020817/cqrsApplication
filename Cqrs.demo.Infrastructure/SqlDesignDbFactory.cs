using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Cqrs.demo.Infrastructure;

public class SqlDesignDbFactory : IDesignTimeDbContextFactory<PostContext>
{
    public PostContext CreateDbContext(string[] args)
    {
        IConfiguration configuration = new ConfigurationManager()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.local.json")
            .Build();
        //for local developpement
        var builder = new DbContextOptionsBuilder<PostContext>()
            .UseNpgsql(configuration.GetConnectionString("PostDb"));

        return new PostContext(builder.Options);
    }
}