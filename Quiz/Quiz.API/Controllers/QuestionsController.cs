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
    public class QuestionsController : ControllerBase
    {
        private readonly QuizDbContext _context;
        private readonly IQuestionService _questionService;

        public QuestionsController(QuizDbContext context, IQuestionService questionService)
        {
            _context = context;
            _questionService = questionService;
        }

        [HttpGet]
        [Route("[action]/{eventId}")]
        public IActionResult GetList(Guid eventId)
        {
            return Ok(_questionService.GetList(eventId)); 
        }
    }
}
