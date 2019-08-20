namespace tictactoe.api.dataaccess.creators
{
    public interface IEntityCreator<T> where T : class, IEntity
    {
        T CreateEntity(T entity);
    }
}