using backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Player> Players => Set<Player>();
    public DbSet<PlayerResource> PlayerResources => Set<PlayerResource>();
}