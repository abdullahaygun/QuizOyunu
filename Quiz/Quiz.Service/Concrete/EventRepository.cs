using Microsoft.AspNetCore.Mvc;
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
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
        public EventRepository(QuizDbContext quizDbContext) : base(quizDbContext)
        { }

        public void CreateEvent(Event _event)
        {
            Create(_event);
        }

        public void DeleteEvent(Event _event)
        {
            Delete(_event);
        }

        public async Task<IEnumerable<Event>> GetAllEventsAsync()
        {
            return await FindAll().OrderByDescending(p => p.CreatedDate).ToListAsync();
        }

        public async Task<Event> GetEventByIdAsync(Guid eventId)
        {
            return await FindByCondition(p => p.Id == eventId).FirstOrDefaultAsync();
        }

        public void UpdateEvent(Event _event)
        {
            Update(_event);
        }
    }
}
