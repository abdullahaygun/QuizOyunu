using Microsoft.AspNetCore.Mvc;
using Quiz.Data;
using Quiz.Data.Entities.Concrete;
using Quiz.Service.Abstraction;
using Quiz.Service.Concrete;

namespace Quiz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private IRepositoryWrapper _repository;

        public PlayersController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [Route("action")]
        [HttpPost]
        public async Task<IActionResult> Add(Player player)
        {
            _repository.Player.CreatePlayer(player);
           await _repository.SaveAsync();
            return Ok(player);
        }
    }
}
