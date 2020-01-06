namespace Tennis
{
    public class Player
    {
        public int score;
        public string name;

        public Player(string name)
        {
            this.name = name;
            this.score = 0;
        }

        public void WonPoint()
        {
            this.score++;
        }

        public bool HasAdvantageAgainst(Player otherPlayer){
            if(score > 3 && score - otherPlayer.score == 1){
                return true;
            }
            return false;
        }

        public bool HasWonAgainst(Player otherPlayer){
            if(score > 3 && score - otherPlayer.score >= 2){
                return true;
            }
            return false;
        }
    }
}

