using backend.Entities;
using backend.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories;

public class PlayerRepository(ApplicationDbContext context) : IPlayerRepository
{
    public async Task<Player?> AddAsync(Player player)
    {
        context.Add(player);
        await context.SaveChangesAsync();
        return player;
    }

    public async Task<Player?> GetByIdAsync(Guid id)
    {
        return await context.Players.FindAsync(id);
    }

    public async Task<IEnumerable<Player>> GetAllAsync()
    {
        return await context.Players.ToListAsync();
    }
}