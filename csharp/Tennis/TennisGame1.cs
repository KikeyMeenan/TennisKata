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
            switch (player1Score)
            {
                case 0:
                    return "Love-All";
                case 1:
                    return "Fifteen-All";
                case 2:
                    return "Thirty-All";
                default:
                    return "Deuce";

            }
        }

        private string GetEndGameScore()
        {
            var minusResult = player1Score - player2Score;
            if (minusResult == 1) return "Advantage player1";
            else if (minusResult == -1) return "Advantage player2";
            else if (minusResult >= 2) return "Win for player1";
            return "Win for player2";
        }

        public string GetScore()
        {
            string score = "";
            var tempScore = 0;
            if (isEvenScore)
            {
                score = GetEvenScore();
            }
            else if (isEndGameScore)
            {
                score = GetEndGameScore();
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = player1Score;
                    else { score += "-"; tempScore = player2Score; }
                    switch (tempScore)
                    {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            return score;
        }
    }
}

