using Microsoft.AspNetCore.Mvc;
using Quiz.Data;
using Quiz.Data.Entities.Concrete;
using Quiz.Service.Abstraction;
using Quiz.Service.Concrete;

namespace Quiz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private IRepositoryWrapper _repository;

        public EventsController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [Route("action")]
        [HttpPost]
        public async Task<IActionResult> Add(Event _event)
        {
            _repository.Event.CreateEvent(_event);
            await _repository.SaveAsync();
            return Ok(_event);
        }
    }
}
