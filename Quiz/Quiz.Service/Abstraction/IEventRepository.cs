using Quiz.Data.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Service.Abstraction
{
    public interface IEventRepository : IRepositoryBase<Event>
    {
        Task<IEnumerable<Event>> GetAllEventsAsync();
        Task<Event> GetEventByIdAsync(Guid eventId);
        //Task<Player> GetOwnerWithDetailsAsync(Guid playerId);
        void CreateEvent(Event _event);
        void UpdateEvent(Event _event);
        void DeleteEvent(Event _event);
    }
}
