using Microsoft.AspNetCore.Mvc;
using Quiz.Data;
using Quiz.Data.Entities.Concrete;
using Quiz.Service.Abstraction;
using Quiz.Service.Concrete;

namespace Quiz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private IRepositoryWrapper _repository;

        public QuestionsController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [Route("action")]
        [HttpPost]
        public async Task<IActionResult> Add(Question question)
        {
            _repository.Question.CreateQuestion(question);
            await _repository.SaveAsync();
            return Ok(question);
        }
    }
}
