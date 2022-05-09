using Quiz.Data;
using Quiz.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Service.Concrete
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private QuizDbContext _quizDbContext;

        public RepositoryWrapper(QuizDbContext quizDbContext)
        {
            _quizDbContext = quizDbContext;
        }

        private IPlayerRepository _player;
        private IEventRepository _event;
        private IQuestionRepository _question;

        public IPlayerRepository Player
        {
            get
            {
                if (_player == null)
                {
                    _player = new PlayerRepository(_quizDbContext);
                }
                return _player;
            }
        }

        public IEventRepository Event
        {
            get
            {
                if (_event == null)
                {
                    _event = new EventRepository(_quizDbContext);
                }
                return _event;
            }
        }

        public IQuestionRepository Question
        {
            get
            {
                if (_question == null)
                {
                    _question = new QuestionRepository(_quizDbContext);
                }
                return _question;
            }
        }

        public async Task SaveAsync()
        {
            await _quizDbContext.SaveChangesAsync();
        }
    }
}
