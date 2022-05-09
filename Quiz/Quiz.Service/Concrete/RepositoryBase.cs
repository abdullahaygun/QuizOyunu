using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quiz.Data;
using Quiz.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Service.Concrete
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected QuizDbContext QuizDbContext { get; set; }

        public RepositoryBase(QuizDbContext quizDbContext)
        {
            QuizDbContext = quizDbContext;
        }

        public void Create(T entity)
        {
            QuizDbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            QuizDbContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return QuizDbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return QuizDbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            QuizDbContext.Set<T>().Update(entity);
        }
    }
}
