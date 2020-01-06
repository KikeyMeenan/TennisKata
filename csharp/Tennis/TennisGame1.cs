using System.Collections.Generic;
using System.Linq;

namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        // use a list of players instead? could use linq to identify player then
        private Player player1;
        private Player player2;
        private List<IGameScore> gameScores;

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1 = new Player(player1Name);
            this.player2 = new Player(player2Name);
            gameScores = new List<IGameScore>()
            {
                new NormalGameScore(player1, player2),
                new TieGameScore(player1, player2),
                new AdvantageGameScore(player1, player2),
                new WinningGameScore(player1, player2)
            };
        }

        private Player GetPlayer(string playerName)
        {
            return playerName == player1.name ? player1 : player2;
        }

        public void WonPoint(string playerName)
        {
            GetPlayer(playerName).WonPoint();
        }

        public string GetScore()
        {
            return gameScores.Single(x => x.Condition == true).Output;
        }
    }
}

