using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Data.Entities.Abstraction
{
    public interface IQuestion
    {
        public string QuestionBody { get; set; }
        public List<string> Answers { get; set; }
        public int IndexCorrectAnswer { get; set; }
        public _Difficulty Difficulty { get; set; }
        public enum _Difficulty
        {
            Easy, Medium, Hard
        }

    }
}
