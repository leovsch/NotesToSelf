using Microsoft.EntityFrameworkCore;

namespace NotesToSelf.DAL.Contexts
{
    public class BaseContext<TEntity> : DbContext where TEntity : class
    {
        public BaseContext(DbContextOptions<BaseContext<TEntity>> options) : base(options)
        {
        }

        public DbSet<TEntity> Items { get; set; }
    }
}
