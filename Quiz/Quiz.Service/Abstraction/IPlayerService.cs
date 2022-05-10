using Quiz.Data;
using Quiz.Data.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Service.Abstraction
{
    public interface IPlayerService
    {
        public void Add(string nick);
    }
}
