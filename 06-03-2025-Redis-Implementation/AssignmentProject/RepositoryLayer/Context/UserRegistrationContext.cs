using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Context
{
    public class UserRegistrationContext : DbContext
    {
        public UserRegistrationContext(DbContextOptions<UserRegistrationContext> options) : base(options)
        {
        }
        public DbSet<Entity.UserEntity> Users { get; set; }
    }
}
