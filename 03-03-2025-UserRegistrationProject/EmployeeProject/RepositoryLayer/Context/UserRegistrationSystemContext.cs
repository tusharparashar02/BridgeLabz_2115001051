using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Context
{
    public class UserRegistrationSystemContext : DbContext
    {
        public UserRegistrationSystemContext(DbContextOptions<UserRegistrationSystemContext> options) : base(options) { }

        public DbSet<Entity.UserEntity> Users { get; set; }
    }
}
