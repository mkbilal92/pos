using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Windows.Input;

namespace Demo.Database.Entities.Identity
{
    public class Module : Base
    {
        public string Description { get; set; }
        public string Icon { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        public string ModuleCode { get; set; }
        [BsonId]
        [BsonElement("Id")]
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
