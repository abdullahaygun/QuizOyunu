using Microsoft.EntityFrameworkCore;
using Quiz.Data;
using Quiz.Data.Entities.Concrete;
using Quiz.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Service.Concrete
{
    public class PlayerRepository : RepositoryBase<Player>, IPlayerRepository
    {
        public PlayerRepository(QuizDbContext quizDbContext) : base(quizDbContext)
        { }

        public void CreatePlayer(Player player)
        {
            Create(player);
        }

        public void DeletePlayer(Player player)
        {
            Delete(player);
        }

        public async Task<IEnumerable<Player>> GetAllPlayersAsync()
        {
            return await FindAll().OrderByDescending(p => p.CreatedDate).ToListAsync();
        }

        public async Task<Player> GetPlayerByIdAsync(Guid playerId)
        {
            return await FindByCondition(p=>p.Id == playerId).FirstOrDefaultAsync();
        }

        public void UpdatePlayer(Player player)
        {
            Update(player);
        }
    }
}
