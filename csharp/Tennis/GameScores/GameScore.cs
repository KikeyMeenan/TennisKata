namespace Tennis
{
    public abstract class GameScore
    {
        protected Player player1;
        protected Player player2;
        public GameScore(Player Player1, Player Player2)
        {
            player1 = Player1;
            player2 = Player2;
        }
        public abstract bool Condition();
        public abstract string Output { get; }
    }
}

