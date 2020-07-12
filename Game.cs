using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W3
{
    class Game
    {
        public string nameGame { get; set; } //Название команды 
        public int numberTours { get; set; } // количество туров
        public int numberQuestions { get; set; } // Количество вопросов в туре
        public int gameID { get; set; } // ID игры
        public int amt { get; set; } // Общее количество вопросов
        public int countQuestion { get; set; } // Счётчик вопросв
        public List<TeamsInGame> teamsInGame { get; set; } //Список команд в игре
        public Game() { }

        public Game(string _nameGame, int _numberTours, int _numberQuestions, int _gameID, List<TeamsInGame> _teamsInGames, int _amt)
        {
            nameGame = _nameGame;
            numberTours = _numberTours;
            numberQuestions = _numberQuestions;
            teamsInGame = _teamsInGames;
            amt = _amt;
            countQuestion = 0;
        }
    }
}
