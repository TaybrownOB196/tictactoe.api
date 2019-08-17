namespace tictactoe.api.dataaccess.models
{
    public class Player : BaseEntity
    {
        public string playerName { get; set; }
        public char playerPiece { get; set; }
    }
}