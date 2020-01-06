namespace Tennis
{
    class TieGameScore : GameScore
    {
        public TieGameScore(Player Player1, Player Player2) : base(Player1, Player2) { }

        public override bool Condition
        {
            get => player1.score == player2.score;
        }

        public override string Output
        {
            get
            {
                if(player1.score > 2)
                {
                    return "Deuce";
                }

                return $"{Utils.Score[player1.score]}-All";
            }
        }
    }
}

