using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Service.Abstraction
{
    public interface IRepositoryWrapper
    {
        IPlayerRepository Player { get; }
        IQuestionRepository Question { get; }
        IEventRepository Event { get; }
        Task SaveAsync();
    }
}
