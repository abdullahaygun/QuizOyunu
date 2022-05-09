using Quiz.Data;
using Quiz.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Service.Concrete
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        public QuizDbContext _quizDbContext { get; set; }

        public RepositoryWrapper(QuizDbContext quizDbContext)
        {
            _quizDbContext = quizDbContext;
        }

        public IPlayerRepository Player { get; set; }
        public IQuestionRepository Question { get; set; }
        public IEventRepository Event { get; set; }
        public async Task SaveAsync()
        {
            await _quizDbContext.SaveChangesAsync();
        }
    }
}
