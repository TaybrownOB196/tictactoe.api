using System;

namespace tictactoe.api.dataaccess.models
{
    public abstract class BaseEntity : IEntity
    {
        public int id { get; set; }
        public bool isActive { get; protected set; }
        public DateTime createDate { get; set; }
    }
}