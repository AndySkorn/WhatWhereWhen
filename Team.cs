using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W3
{
    class Team
    {
        public string nameTeam { get; set; }
        public string league { get; set; }
        public int teamId { get; set; }
        public int countQuestion { get; set; }
       
        public Team(string _nameTeam, string _league, int _teamId)
        {
            nameTeam = _nameTeam;
            league = _league;
            teamId = _teamId;
            countQuestion = 0;
            
        }
        
        
    }

}
