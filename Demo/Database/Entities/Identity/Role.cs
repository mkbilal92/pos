using System;

namespace Demo.Database.Entities.Identity
{
    public class Role : Base
    {
        public Role()
        {
            RoleId = Guid.NewGuid().ToString();
        }
        public string RoleId { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        public RoleStatus Status { get; set; }
    }

    public enum RoleStatus
    {
        Active,
        Inactive,
        Deleted
    }
}
