using System;
using System.Collections.Generic;
using System.Text;
using Demo.Database.Entities.Identity;
using MongoDB.Driver;

namespace Demo.Database.Entities
{
    public class DbContext : IDbContext
    {
        private readonly IMongoDatabase _dbContext;

        public DbContext()
        {
            var client = new MongoClient("");
            _dbContext = client.GetDatabase("");

            var userFilter = Builders<User>.Filter.Empty;
            var moduleFilter = Builders<Module>.Filter.Empty;
            var groupFilter = Builders<Group>.Filter.Empty;
            var roleFilter = Builders<Role>.Filter.Empty;
            var permissionFilter = Builders<Permission>.Filter.Empty;

            var userDocument = Users.Count(userFilter);
            var moduleDocument = Modules.Count(moduleFilter);
            var groupDocument = Groups.Count(groupFilter);
            var roleDocument = Roles.Count(roleFilter);
            var permissionDocument = Permissions.Count(permissionFilter);

            if (userDocument == 0) UserSeed();

            if(moduleDocument == 0) ModuleSeed();

            if(groupDocument == 0) GroupSeed();

            if(roleDocument == 0) RoleSeed();

            if(permissionDocument == 0) PermissionSeed();

        }

        public IMongoCollection<User> Users => _dbContext.GetCollection<User>("User");
        public IMongoCollection<Role> Roles  => _dbContext.GetCollection<Role>("Role");
        public IMongoCollection<UserGroup> UserGroups =>  _dbContext.GetCollection<UserGroup>("UserGroup");
        public IMongoCollection<Permission> Permissions => _dbContext.GetCollection<Permission>("Permission");
        public IMongoCollection<ModuleAction> ModuleActions => _dbContext.GetCollection<ModuleAction>("ModuleAction");
        public IMongoCollection<Module> Modules => _dbContext.GetCollection<Module>("Module");
        public IMongoCollection<GroupRole> GroupRoles => _dbContext.GetCollection<GroupRole>("GroupRole");
        public IMongoCollection<Group> Groups => _dbContext.GetCollection<Group>("Group");



        private void UserSeed()
        {
            var users = new List<User>
            {
                new User
                {
                    Code = "Arsalan",
                    Created = DateTimeOffset.UtcNow,
                    CreatedBy = 1,
                    Description = "Arsalan",
                    EmailAddress = "programmerarsalaniu@gmail.com",
                    EmployeeNumber = "03132619201",
                    Image = "",
                    InstitutionId = 1,
                    InvalidAttempts = 0,
                    LastUpdated = DateTimeOffset.UtcNow,
                    LastUpdatedBy = 1,
                    Name = "Muhammad Arsalan",
                    Password = "Arsalan",
                    Status = UserStatus.Active,
                    UserId = Guid.NewGuid().ToString()
                    
                }
            };

            Users.InsertMany(users);
        }
        private void ModuleSeed()
        {
        }
        private void GroupSeed()
        {
        }
        private void RoleSeed()
        {
        }
        private void PermissionSeed()
        {
        }
    }
}
