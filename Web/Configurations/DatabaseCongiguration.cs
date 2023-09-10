using Db.DbSettings;
using Microsoft.EntityFrameworkCore;

namespace Web.Configurations;

public static class DatabaseCongiguration
{
    public static void Init(WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(connectionString,  b => b.MigrationsAssembly("Web")));
    }
}