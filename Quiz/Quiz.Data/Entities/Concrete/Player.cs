using Quiz.Data.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Data.Entities.Concrete
{
    public class Player : Base, IPlayer
    {
        private string _Nick;

        public string Nick { get => _Nick; set => _Nick = value; }
    }
}
