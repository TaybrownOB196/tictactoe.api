using tictactoe.api.dataaccess.models;

namespace tictactoe.api.dataaccess.creators
{
    public class PlayersCreator : IEntityCreator<Player>
    {
        private readonly TictactoeDbContext _db;
        public PlayersCreator(TictactoeDbContext dbContext)
        {
            _db = dbContext;
        } 

        public Player CreateEntity(Player entity)
        {
            var player = _db.Players.Add(entity);
            _db.SaveChanges();
            return player.Entity;
        }
    }
}