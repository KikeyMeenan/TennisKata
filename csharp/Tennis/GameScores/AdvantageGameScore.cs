namespace Tennis
{
    class AdvantageGameScore : GameScore
    {
        public AdvantageGameScore(Player Player1, Player Player2) : base(Player1, Player2) { }

        public override bool Condition()
        {
            return player1.HasAdvantageAgainst(player2) || player2.HasAdvantageAgainst(player1);
        }

        public override string Output
        {
            get
            {
                if (player1.HasAdvantageAgainst(player2)) return $"Advantage {player1.name}";
                return $"Advantage {player2.name}";
            }
        }
    }
}

