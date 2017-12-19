using NotesToSelf.DAL.Contexts;
using NotesToSelf.DAL.Repositories.Interfaces;

namespace NotesToSelf.DAL.Repositories.Implementations
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    { 
        private readonly BaseContext<TEntity> _context;

        public BaseRepository(BaseContext<TEntity> context)
        {
            _context = context;
        }

        public void Add(TEntity toAdd)
        {
            _context.Items.Add(toAdd);
            _context.SaveChanges();
        }
    }
}
