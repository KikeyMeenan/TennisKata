namespace Tennis
{
    public abstract class GameScore: IGameScore
    {
        protected Player player1;
        protected Player player2;
        public GameScore(Player Player1, Player Player2)
        {
            player1 = Player1;
            player2 = Player2;
        }
        public abstract bool Condition { get; }
        public abstract string Output { get; }
    }
}

