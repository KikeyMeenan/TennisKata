using System.Collections.Generic;
using System.Linq;

namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private List<Player> players;
        private List<IGameScore> gameScores;

        public TennisGame1(string player1Name, string player2Name)
        {
            players.Add(new Player(player1Name));
            players.Add(new Player(player2Name));
            gameScores = new List<IGameScore>()
            {
                new NormalGameScore(players[0], players[1]),
                new TieGameScore(players[0], players[1]),
                new AdvantageGameScore(players[0], players[1]),
                new WinningGameScore(players[0], players[1])
            };
        }

        public void WonPoint(string playerName)
        {
            players.Single(x => x.name == playerName).WonPoint();
        }

        public string GetScore()
        {
            return gameScores.Single(x => x.Condition == true).Output;
        }
    }
}

