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
    public class QuestionService : IQuestionService
    {
        private readonly QuizDbContext _context;

        public QuestionService(QuizDbContext context)
        {
            _context = context;
        }

        public List<Question> GetList(Guid eventId)
        {
            var _event = _context.Events.FirstOrDefault(e => e.Id == eventId);
            var questionIds = _event.QuestionIds;
            var questions = _context.Questions.Where(q => questionIds.Contains(q.Id)).ToList();

            return questions;
        }
    }
}
