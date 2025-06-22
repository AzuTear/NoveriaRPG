using backend.Entities;

namespace backend.Interfaces.Repositories;

public interface IPlayerRepository
{
    Task<Player?> AddAsync(Player player);
    Task<Player?> GetByIdAsync(Guid id);
    Task<IEnumerable<Player>> GetAllAsync();
}