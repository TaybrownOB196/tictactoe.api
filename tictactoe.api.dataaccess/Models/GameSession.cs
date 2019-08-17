using System;

namespace tictactoe.api.dataaccess.models
{
    public class GameSession : BaseEntity
    {
        public GameSession() {}

        public int playerOneId { get; set; }
        public int? playerTwoId { get; set; }
    }
}