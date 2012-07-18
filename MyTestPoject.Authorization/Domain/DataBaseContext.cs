using System.Data.Entity;

namespace MyTestPoject.Authorization.Domain
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<MatrialStatus> MatrialStatuses { get; set; }

        public DbSet<Gender> Genders { get; set; }
    }
}