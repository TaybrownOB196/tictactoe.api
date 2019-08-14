using System;

namespace tictactoe.api.dataaccess.models
{
    public class GameSession : DbModel
    {
        public GameSession() {}

        public GameSession(Player p1, Player p2)
        {
            playerOneId = p1.id;
            playerTwoId = p2.id;
        }

        public int playerOneId { get;set; }
        public int playerTwoId { get;set; }
    }
}