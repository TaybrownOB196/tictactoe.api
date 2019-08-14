namespace tictactoe.api.dataaccess.models
{
    public class GameResult : DbModel
    {
        public GameResult() {}

        public GameResult(Player p)
        {
            player = p;
        }
        public Player player { get; set; }
        public int winCount { get; set; }
        public int lossCount { get; set; }
        public int gamesPlayed { get; set; }
        //true is winner, false is loser, null is draw
        public bool? isWinner { get; set; }

        public static GameResult getDummy()
        {
            return new GameResult
            {
                player = new Player
                {
                    playerName = "player one", 
                    playerPiece = 'X'
                },
                winCount = 0,
                lossCount = 0,
                gamesPlayed = 0,
                isWinner = null
            };
        }
    }
}