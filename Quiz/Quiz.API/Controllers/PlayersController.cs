using Microsoft.AspNetCore.Mvc;
using Quiz.Data;
using Quiz.Data.Entities.Concrete;
using Quiz.Service.Abstraction;
//using Quiz.Service.Abstraction;
using Quiz.Service.Concrete;

namespace Quiz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly QuizDbContext _context;
        private readonly IPlayerService _playerService;

        public PlayersController(QuizDbContext context, IPlayerService playerService)
        {
            _context = context;
            _playerService = playerService;
        }

        [HttpPost]
        [Route("[action]/{nick}")]
        public void Add(string nick)
        {
            _playerService.Add(nick);
        }
    }
}
