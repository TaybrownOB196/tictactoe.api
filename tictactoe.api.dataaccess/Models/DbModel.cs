using System;

namespace tictactoe.api.dataaccess.models
{
    public abstract class DbModel
    {
        public int id { get; set; }
        public bool isActive { get; protected set; }
        public DateTime createDate { get; set; }
    }
}