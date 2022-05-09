using Quiz.Data.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Quiz.Data.Entities.Abstraction.IQuestion;

namespace Quiz.Data.Entities.Concrete
{
    public class Question : Base, IQuestion
    {
        private string _QuestionBody;
        private List<string> _Answers;
        private int _IndexCorrectAnswer;
        private _Difficulty _Difficulty;

        public string QuestionBody { get => _QuestionBody; set => _QuestionBody = value; }
        public List<string> Answers { get => _Answers; set => _Answers = value; }
        public int IndexCorrectAnswer { get => _IndexCorrectAnswer; set => _IndexCorrectAnswer = value; }
        public _Difficulty Difficulty { get => _Difficulty; set => _Difficulty = value; }
    }
}
