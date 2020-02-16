using System;
using System.Collections.Generic;
using System.Text;
using Demo.Database.Entities.Identity;
using MongoDB.Driver;
using Action = Demo.Database.Entities.Identity.Action;

namespace Demo.Database.Entities
{
    public class DbContext
    {
        private readonly IMongoDatabase _dbContext;

        public DbContext()
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            _dbContext = client.GetDatabase("Identity");

            var userFilter = Builders<User>.Filter.Empty;
            var moduleFilter = Builders<Module>.Filter.Empty;
            var groupFilter = Builders<Group>.Filter.Empty;
            var actionFilter = Builders<Action>.Filter.Empty;
            var groupRoleFilter = Builders<GroupRole>.Filter.Empty;

            var userDocument = Users.Count(userFilter);
            var moduleDocument = Modules.Count(moduleFilter);
            var groupDocument = Groups.Count(groupFilter);
            var actionDocument = Actions.Count(actionFilter);
            var groupRoleDocument = GroupRoles.Count(groupRoleFilter);

            if (userDocument == 0) UserSeed();

            if (moduleDocument == 0) ModuleSeed();

            if (groupDocument == 0) GroupSeed();

            if (actionDocument == 0) ActionSeed();

            if (groupRoleDocument == 0) GroupRoleSeed();

        }

        public IMongoCollection<User> Users => _dbContext.GetCollection<User>("User");
        public IMongoCollection<Role> Roles => _dbContext.GetCollection<Role>("Role");
        public IMongoCollection<UserGroup> UserGroups => _dbContext.GetCollection<UserGroup>("UserGroup");
        public IMongoCollection<Permission> Permissions => _dbContext.GetCollection<Permission>("Permission");
        public IMongoCollection<ModuleAction> ModuleActions => _dbContext.GetCollection<ModuleAction>("ModuleAction");
        public IMongoCollection<Module> Modules => _dbContext.GetCollection<Module>("Module");
        public IMongoCollection<GroupRole> GroupRoles => _dbContext.GetCollection<GroupRole>("GroupRole");
        public IMongoCollection<Group> Groups => _dbContext.GetCollection<Group>("Group");
        public IMongoCollection<Identity.Action> Actions => _dbContext.GetCollection<Action>("Action");


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
                    UserId = "1"

                }
            };

            Users.InsertMany(users);
        }
        private void ModuleSeed()
        {

            var modules = new List<Module>
            {
                 // Management modules with childrens

                new Module
                {
                Code ="ManagementModule",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "Managment Screen",
                ModuleCode = "M",
                Name = "Management",
                InstitutionId = 1,
                ModuleId = "1",
                Status = ModuleStatus.Active
                },
                new Module
                {
                Code ="Dashboard",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "Dashboard Screen",
                ModuleCode = "D",
                Name = "Dashboard",
                InstitutionId = 1,
                ParentId = "1",
                ModuleId = "2",
                Status = ModuleStatus.Active
                },
                new Module
                {
                Code ="Document",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "Document Screen",
                ModuleCode = "Doc",
                Name = "Document",
                InstitutionId = 1,
                ParentId = "1",
                ModuleId = "3",
                Status = ModuleStatus.Active
                },
                new Module
                {
                Code ="Product",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "Product Screen",
                ModuleCode = "Pro",
                Name = "Product",
                InstitutionId = 1,
                ParentId = "1",
                ModuleId = "4",
                Status = ModuleStatus.Active
                },
                new Module
                {
                Code ="Stock",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "Stock Screen",
                ModuleCode = "S",
                Name = "Stock",
                InstitutionId = 1,
                ModuleId = "5",
                ParentId = "1",
                Status = ModuleStatus.Active
                },
                new Module
                {
                Code ="Reporting",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "Reporting Screen",
                ModuleCode = "R",
                Name = "Reporting",
                InstitutionId = 1,
                ModuleId = "6",
                ParentId = "1",
                Status = ModuleStatus.Active
                },
                new Module
                {
                Code ="CS",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "Customer & Supplier Screen",
                ModuleCode = "CS",
                Name = "Customer & Supplier",
                InstitutionId = 1,
                ModuleId = "7",
                ParentId = "1",
                Status = ModuleStatus.Active
                },
                new Module
                {
                Code ="PA",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "Promotions & Action Screen",
                ModuleCode = "PA",
                Name = "Promotions & Action",
                InstitutionId = 1,
                ModuleId = "8",
                ParentId = "1",
                Status = ModuleStatus.Active
                },
                new Module
                {
                Code ="US",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "User & Security Screen",
                ModuleCode = "US",
                Name = "User & Security",
                InstitutionId = 1,
                ModuleId = "9",
                ParentId = "1",
                Status = ModuleStatus.Active
                },
                new Module
                {
                Code ="PT",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "Payment Types Screen",
                ModuleCode = "PT",
                Name = "Payment Types",
                InstitutionId = 1,
                ModuleId = "10",
                ParentId = "1",
                Status = ModuleStatus.Active
                },
                new Module
                {
                Code ="TR",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "Tax Rate Screen",
                ModuleCode = "TR",
                Name = "Tax Rate",
                InstitutionId = 1,
                ModuleId = "11",
                ParentId = "1",
                Status = ModuleStatus.Active
                },
                new Module
                {
                Code ="MC",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "My Company Screen",
                ModuleCode = "MC",
                Name = "My Company",
                InstitutionId = 1,
                ModuleId = "12",
                ParentId = "1",
                Status = ModuleStatus.Active
                },

                // View sales history module
                 new Module
                {
                Code ="VSH",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "View Sales History Screen",
                ModuleCode = "VSH",
                Name = "View Sales History",
                InstitutionId = 1,
                ModuleId = "13",
                Status = ModuleStatus.Active
                },
                 // Cash In / Out
                 new Module
                {
                Code ="CIO",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "Cash In / Out Screen",
                ModuleCode = "CIO",
                Name = "Cash In / Out",
                InstitutionId = 1,
                ModuleId = "14",
                Status = ModuleStatus.Active
                },

                 // End Of Day
                 new Module
                {
                Code ="EOD",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "End Of Day Screen",
                ModuleCode = "EOD",
                Name = "End Of Day",
                InstitutionId = 1,
                ModuleId = "15",
                Status = ModuleStatus.Active
                },
                   // User Info
                 new Module
                {
                Code ="UI",
                Created = DateTime.UtcNow,
                CreatedBy = 1,
                Description = "User Info Screen",
                ModuleCode = "UI",
                Name = "User Info",
                InstitutionId = 1,
                ModuleId = "16",
                Status = ModuleStatus.Active
                },
            };


            var modulesActions = new List<ModuleAction>
            {
                new ModuleAction
                {
                    ModuleActionId ="1",
                    ActionId = "1",
                    ModuleId = "1"
                },
                new ModuleAction
                {
                    ModuleActionId = "2",
                    ActionId = "2",
                    ModuleId = "1"

                },
                new ModuleAction
                {
                    ModuleActionId = "3",
                    ActionId = "3",
                    ModuleId = "1"

                },
                new ModuleAction
                {
                    ModuleActionId = "4",
                    ActionId = "4",
                    ModuleId = "1"

                },
            };

            var roles = new List<Role>
            {
                new Role
                {
                    Code = "Admin",
                    Created = DateTime.UtcNow,
                    CreatedBy = 1,
                    Description = "Admin role",
                    Name = "Admin",
                    InstitutionId = 1,
                    RoleId ="1",
                    Status = RoleStatus.Active
                }
            };

            // Permissions
            var permissions = new List<Permission>
           {
               new Permission
               {
                   ModuleActionId = "1",
                   RoleId = "1"
               },
                new Permission
               {
                   ModuleActionId = "2",
                   RoleId = "1"
               },
                 new Permission
               {
                   ModuleActionId = "3",
                   RoleId = "1"
               },
                  new Permission
               {
                   ModuleActionId = "4",
                   RoleId = "1"
               },
           };


            Modules.InsertMany(modules);
            ModuleActions.InsertMany(modulesActions);
            Roles.InsertMany(roles);
            Permissions.InsertMany(permissions);
        }
        private void GroupSeed()
        {
            var groups = new List<Group>
            {
                new Group
                {
                    Code = "AdminGroup",
                    GroupId = "1",
                    Created = DateTime.UtcNow,
                    CreatedBy = 1,
                    Description = "Admin Group",
                    InstitutionId = 1,
                    LastUpdatedBy = 1,
                    Name = "Admin",
                    Status = GroupStatus.Active
                }
            };

            var userGroup = new List<UserGroup>
            {
                new UserGroup
                {
                    GroupId  = "1",
                    UserId = "1"
                }
            };
            Groups.InsertMany(groups);


            UserGroups.InsertMany(userGroup);
        }
        private void ActionSeed()
        {
            var actions = new List<Identity.Action>
            {
                new Identity.Action
                {
                    ActionId = "1",
                    Created = DateTime.UtcNow,
                    CreatedBy = 1,
                    Description = "Action Added",
                    InstitutionId = 1,
                    Name = "Add",
                    Status = ActionStatus.Active
                },
                  new Identity.Action
                {

                    ActionId = "2",
                    Code = "E",
                    Created = DateTime.UtcNow,
                    CreatedBy = 1,
                    Description = "Action Edit",
                    InstitutionId = 1,
                    Name = "Edit",
                    Status = ActionStatus.Active
                },
                    new Identity.Action
                {

                    ActionId = "3",
                    Code = "V",
                    Created = DateTime.UtcNow,
                    CreatedBy = 1,
                    Description = "Action View",
                    InstitutionId = 1,
                    Name = "View",
                    Status = ActionStatus.Active
                },
                      new Identity.Action
                {

                    ActionId = "4",
                    Code = "D",
                    Created = DateTime.UtcNow,
                    CreatedBy = 1,
                    Description = "Action Delete",
                    InstitutionId = 1,
                    Name = "Delete",
                    Status = ActionStatus.Active
                }
            };

            Actions.InsertMany(actions);
        }
        private void GroupRoleSeed()
        {


            var groupRoles = new List<GroupRole>
        {
            new GroupRole
            {
                GroupId = "1",
                RoleId = "1"
            },
        };

            GroupRoles.InsertMany(groupRoles);
        }
    }

}
