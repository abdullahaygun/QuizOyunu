using Quiz.Data.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Service.Abstraction
{
    public interface IPlayerRepository : IRepositoryBase<Player>
    {
        Task<IEnumerable<Player>> GetAllPlayersAsync();
        Task<Player> GetPlayerByIdAsync(Guid playerId);
        //Task<Player> GetOwnerWithDetailsAsync(Guid playerId);
        void CreatePlayer(Player player);
        void UpdatePlayer(Player player);
        void DeletePlayer(Player player);
    }
}
