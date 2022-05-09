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
    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
        public QuestionRepository(QuizDbContext quizDbContext) : base(quizDbContext)
        { }

        public void CreateQuestion(Question question)
        {
            Create(question);
        }

        public void DeleteQuestion(Question question)
        {
            Delete(question);
        }

        public async Task<IEnumerable<Question>> GetAllQuestionsAsync()
        {
            return await FindAll().OrderByDescending(p => p.CreatedDate).ToListAsync();
        }

        public async Task<Question> GetQuestionByIdAsync(Guid questionId)
        {
            return await FindByCondition(p => p.Id == questionId).FirstOrDefaultAsync();
        }

        public void UpdateQuestion(Question question)
        {
            Update(question);
        }
    }
}
