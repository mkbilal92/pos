using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Demo.Database.Entities.Identity
{
   public class User : Base
    {
        public User()
        {
            UserId = Guid.NewGuid().ToString();
        }

        [BsonId]
        [BsonElement("Id")]
        public string UserId { get; set; }
        public string Image { get; set; }
        public int InvalidAttempts { get; set; }
        public IList<string> PasswordHistory { get; set; }
        public DateTimeOffset PasswordSettingDateTime { get; set; }
        public string Description { get; set; }
        public string EmailAddress { get; set; }
        public string EmployeeNumber { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Password { get; set; }
        public UserStatus Status { get; set; }

    }

   public enum UserStatus
   {
       Active,
       Inactive,
       Deleted,
       ForcePasswordChange,
       Blocked
   }
}
