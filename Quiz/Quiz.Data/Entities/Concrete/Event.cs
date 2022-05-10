using Quiz.Data.Entities.Abstraction;
using static Quiz.Data.Entities.Abstraction.IEvent;

namespace Quiz.Data.Entities.Concrete
{
    public class Event : Base, IEvent
    {
        private Player _Player;
        private Guid _PlayerId;
        private List<Guid>? _QuestionIds;
        private _Joker _Joker;

        public Guid PlayerId { get => _PlayerId; set => _PlayerId = value; }
        public List<Guid>? QuestionIds { get => _QuestionIds; set => _QuestionIds = value; }
        //public _Joker Joker { get => _Joker; set => _Joker = value; }
    }
}
