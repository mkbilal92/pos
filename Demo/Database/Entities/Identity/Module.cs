using System;
using System.Windows.Input;

namespace Demo.Database.Entities.Identity
{
    public class Module : Base
    {
        public Module()
        {
            ModuleId = Guid.NewGuid().ToString();
        }
        public string Description { get; set; }
        public string Icon { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        public string ModuleCode { get; set; }

        public string ModuleId { get; set; }

        public string ParentId { get; set; }
        public string Route { get; set; }
        public ModuleStatus Status { get; set; }
    }

    public enum ModuleStatus
    {
        Active,
        Inactive,
        Deleted,
        SecondaryActive
    }
}
