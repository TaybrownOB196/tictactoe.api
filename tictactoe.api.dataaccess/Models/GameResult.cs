namespace tictactoe.api.dataaccess.models
{
    public class GameResult : BaseEntity
    {
        public GameResult() {}

        public int playerOneId { get; set; }
        public int? playerTwoId { get; set; }
        public int? sessionId { get; set; }
        public int winnerId { get; set; }
    }
}