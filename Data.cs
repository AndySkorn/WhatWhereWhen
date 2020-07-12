using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W3
{
    class Data
    {
        private static Data instance;

        private Data()
        {
            teams = new List<Team>();
            games = new List<Game>();
        }

        public static Data getInstance()
        {
            if (instance == null)
                instance = new Data();
            return instance;
        }

        public Team createdTeam { get; set; }
        public List<Team> teams { get; set; }
        public Game createdGame { get; set; }
        public Game selectedGame { get; set; }
        public List<Game> games { get; set; }
        public Question question { get; set; }
        public List<TeamsInGame> teamsInGame { get; set; }
        public int countQuestion { get; set; }
    }
}
