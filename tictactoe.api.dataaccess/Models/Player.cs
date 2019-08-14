namespace tictactoe.api.dataaccess.models
{
    public class Player : DbModel
    {
        public string playerName { get; set; }
        public char playerPiece { get; set; }
    }
}