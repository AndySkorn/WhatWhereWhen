using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W3
{
    class League
    {
        string leagueName;
        System.Int32 leagueId;
        List<Team> team;
        System.Int32 countTeam = 0;

        public League(string _leagueName, System.Int32 _leagueId)
        {
            leagueName = _leagueName;
            leagueId = _leagueId;
        }
        public void setTeam(Team _team)
        {
            team.Add(_team);
            countTeam += 1;
        }
        public string getName => leagueName;
        public System.Int32 getId => leagueId;
        public System.Int32 getCount => countTeam;
        
    }
}
