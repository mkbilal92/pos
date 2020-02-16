using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Demo.Database.Entities.Identity
{
    public class Group : Base
    {
        public Group()
        {
            GroupId = Guid.NewGuid().ToString();
        }

        public string Description { get; set; }
        [BsonId]
        [BsonElement("Id")]
        public string GroupId { get; set; }

        public DateTimeOffset Created { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        public GroupStatus Status { get; set; }
    }

    public enum GroupStatus
    {
        Active,
        Inactive,
        Deleted
    }
}
