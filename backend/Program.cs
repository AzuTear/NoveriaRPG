using Microsoft.EntityFrameworkCore;

namespace backend;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddInfrastructure();

        // Configuration for SQLite
        var connectionString = builder.Configuration.GetConnectionString("ConnectionString");

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(connectionString));

        // Add services to the container.
        builder.Services.AddAuthorization();

        var app = builder.Build();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.Run();
    }
}