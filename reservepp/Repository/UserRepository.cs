using Microsoft.EntityFrameworkCore;


namespace reservepp
{
    public class UserRepository<T> where T : UserEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public UserRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>(); // Получаем DbSet для нужного типа
        }

        public T GetById(int docID)
        {
            return _dbSet.Find(docID);
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int docID)
        {
            var entity = _dbSet.Find(docID);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }
    }


}