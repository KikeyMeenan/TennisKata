namespace Tennis
{
    class NormalGameScore : GameScore
    {
        public NormalGameScore(Player Player1, Player Player2) : base(Player1, Player2) { }

        public override bool Condition()
        {
            return player1.score <=3 && player2.score <=3;
        }

        public override string Output
        {
            get
            {
                return $"{Utils.Score[player1.score]}-{Utils.Score[player2.score]}";
            }
        }
    }
}

