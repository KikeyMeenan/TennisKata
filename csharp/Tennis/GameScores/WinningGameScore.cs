namespace Tennis
{
    class WinningGameScore : GameScore
    {
        public WinningGameScore(Player Player1, Player Player2) : base(Player1, Player2) { }

        public override bool Condition()
        {
            return player1.HasWonAgainst(player2) || player2.HasWonAgainst(player1);
        }

        public override string Output
        {
            get
            {
                if (player1.HasWonAgainst(player2)) return $"Win for {player1.name}";
                return $"Win for {player2.name}";
            }
        }
    }
}

