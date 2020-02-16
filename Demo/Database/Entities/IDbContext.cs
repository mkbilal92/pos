using Demo.Database.Entities.Identity;
using MongoDB.Driver;

namespace Demo.Database.Entities
{
    public interface IDbContext
    {
        IMongoCollection<User> Users { get; }
        IMongoCollection<Role> Roles { get; }
        IMongoCollection<UserGroup> UserGroups { get; }
        IMongoCollection<Permission> Permissions { get; }
        IMongoCollection<ModuleAction> ModuleActions { get; }
        IMongoCollection<Module> Modules { get; }
        IMongoCollection<GroupRole> GroupRoles { get; }
        IMongoCollection<Group> Groups { get; }

    }
}
