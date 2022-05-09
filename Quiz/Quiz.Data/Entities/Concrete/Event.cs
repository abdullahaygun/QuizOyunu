using Quiz.Data.Entities.Abstraction;
using static Quiz.Data.Entities.Abstraction.IEvent;

namespace Quiz.Data.Entities.Concrete
{
    public class Event : Base, IEvent
    {
        private Player _Player;
        private Guid _PlayerId;
        private List<Question> _Questions;
        private _Joker _Joker;

        public Player Player { get => _Player; set => _Player = value; }
        public Guid PlayerId { get => _PlayerId; set => _PlayerId = value; }
        public List<Question> Questions { get => _Questions; set => _Questions = value; }
        public _Joker Joker { get => _Joker; set => _Joker = value; }
    }
}
