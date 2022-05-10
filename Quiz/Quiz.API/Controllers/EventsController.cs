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
    public class EventsController : ControllerBase
    {
        private readonly QuizDbContext _context;
        private readonly IEventService _eventService;

        public EventsController(QuizDbContext context, IEventService eventService)
        {
            _context = context;
            _eventService = eventService;
        }

        [HttpPost]
        [Route("[action]")]
        public void EventOlustur()
        {
            _eventService.InitAndAddQuestions15();
        }
    }
}
