using System;

namespace Demo.Database.Entities.Identity
{
    public class Action : Base
    {
        #region Public Properties

        public int ActionId { get; set; }

        public string Description { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        public ActionStatus Status { get; set; }

        #endregion Public Properties
    }

    public enum ActionStatus
    {
        Active,
        Inactive,
        Deleted
    }
}
