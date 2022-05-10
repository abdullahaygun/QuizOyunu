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
    public class EventService: IEventService
    {
        private readonly QuizDbContext _context;

        public EventService(QuizDbContext context)
        {
            _context = context;
        }

        public void InitAndAddQuestions15(Guid playerId)
        {
            Event _event = new Event();
            _event.Id = Guid.NewGuid();
            _event.IsActive = true;
            _event.ModifiedDate = DateTime.MinValue;
            _event.CreatedDate = DateTime.UtcNow;

            List<Guid> questionIds = new();
            var easies = _context.Questions.Where(q => q.Difficulty == Data.Entities.Abstraction.IQuestion._Difficulty.Easy).Select(q => q.Id).OrderBy(q => Guid.NewGuid()).Take(5).ToList();
            var mediums = _context.Questions.Where(q => q.Difficulty == Data.Entities.Abstraction.IQuestion._Difficulty.Medium).Select(q => q.Id).OrderBy(q => Guid.NewGuid()).Take(5).ToList();
            var hards = _context.Questions.Where(q => q.Difficulty == Data.Entities.Abstraction.IQuestion._Difficulty.Hard).Select(q => q.Id).OrderBy(q => Guid.NewGuid()).Take(5).ToList();
            questionIds = easies.Concat(mediums).Concat(hards).ToList();
            _event.PlayerId = playerId;
            _event.QuestionIds = questionIds;
            _context.Events.Add(_event);
            _context.SaveChanges();

        }

    }
}
