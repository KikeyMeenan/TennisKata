using System.Collections.Generic;

namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int player1Score = 0;
        private int player2Score = 0;
        private readonly string player1Name;
        private readonly string player2Name;
        private bool isEvenScore { get { return player1Score == player2Score; } }
        private bool isEndGameScore { get { return player1Score >= 4 || player2Score >= 4; } }

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1Name)
                player1Score += 1;
            else
                player2Score += 1;
        }

        private string GetEvenScore()
        {
            if (player1Score <= 2)
            {
                return $"{Score[player1Score]}-All";
            }

            return "Deuce";
        }

        private string GetEndGameScore()
        {
            var minusResult = player1Score - player2Score;
            if (minusResult == 1) return $"Advantage {player1Name}";
            else if (minusResult == -1) return $"Advantage {player2Name}";
            else if (minusResult >= 2) return $"Win for {player1Name}";
            return $"Win for {player2Name}";
        }

        private Dictionary<int, string> Score = new Dictionary<int, string>(){
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        private string GetNormalScore()
        {
            return $"{Score[player1Score]}-{Score[player2Score]}";
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

