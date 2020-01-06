using System.Collections.Generic;

namespace Tennis
{
    class Player {
        public int score;
        public string name;

        public Player(string name) {
            this.name = name;
            this.score = 0;
        }

        public void WonPoint(){
            this.score ++;
        }
    }

    class TennisGame1 : ITennisGame
    {
        private Player player1;
        private Player player2;
        private bool isEvenScore { get { return player1.score == player2.score; } }
        private bool isEndGameScore { get { return player1.score >= 4 || player2.score >= 4; } }

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1 = new Player(player1Name);
            this.player2 = new Player(player2Name);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1.name)
                player1.WonPoint();
            else
                player2.WonPoint();
        }

        private string GetEvenScore()
        {
            if (player1.score <= 2)
            {
                return $"{Score[player1.score]}-All";
            }

            return "Deuce";
        }

        private string GetEndGameScore()
        {
            var minusResult = player1.score - player2.score;
            if (minusResult == 1) return $"Advantage {player1.name}";
            else if (minusResult == -1) return $"Advantage {player2.name}";
            else if (minusResult >= 2) return $"Win for {player1.name}";
            return $"Win for {player2.name}";
        }

        private Dictionary<int, string> Score = new Dictionary<int, string>(){
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        private string GetNormalScore()
        {
            return $"{Score[player1.score]}-{Score[player2.score]}";
        }

        public string GetScore()
        {
            if (isEvenScore)
            {
                return GetEvenScore();
            }
            if (isEndGameScore)
            {
                return GetEndGameScore();
            }
            return GetNormalScore();
        }
    }
}

