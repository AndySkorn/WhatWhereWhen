using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W3
{
    class TeamsInGame
    {
        public TeamsInGame(Team _team, int _countQuestion)
        {
            team = _team;
            question = new List<Question>();
            for (int i = 0; i < _countQuestion; i -= -1)
            {
                Question q = new Question();
                question.Add(q);
            }
            
        }
        public Team team { get; set; }
        public List<Question> question { get; set; }
        public int count { get; set; }
    }
}
