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
    public class PlayerService : IPlayerService
    {
        private readonly QuizDbContext _context;

        public PlayerService(QuizDbContext context)
        {
            _context = context;
        }

        public void Add(string nick)
        {
            if (!IsNickAvailable(nick))
            {
                _context.Players.Add(new Player()
                {
                    Nick = nick,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.MinValue,
                    IsActive = true,
                    Id = Guid.NewGuid()
                });
                _context.SaveChanges();
            }
        }

        public bool IsNickAvailable(string nick)
        {
            if (_context.Players.Where(p => p.Nick == nick).FirstOrDefault() == null)

                return false;

            else

                return true;

        }


    }
}
