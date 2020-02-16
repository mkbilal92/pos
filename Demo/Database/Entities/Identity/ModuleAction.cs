using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Demo.Database.Entities.Identity
{
   public class ModuleAction
    {
        #region Public Properties

        public ModuleAction()
        {
            ModuleActionId = Guid.NewGuid().ToString();
        }

        public string ActionId { get; set; }

        [BsonId]
        [BsonElement("Id")]
        public string ModuleActionId { get; set; }

        public string ModuleId { get; set; }

        #endregion Public Properties
    }
}
