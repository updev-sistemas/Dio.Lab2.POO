
using Dio.Lab2.POO.Domain;
using Dio.Lab2.POO.Infrastructure.Context.Contracts;

namespace Dio.Lab2.POO.Infrastructure.Context
{
    public class DbSet<T> : IDbSet<T> where T : EntityBase
    {
        private int _id;

        private IDictionary<int, T> _collection;

        public DbSet() : base()
        {
            _collection = new Dictionary<int, T>();
            _id = 0;
        }

        public DbSet(int id, IDictionary<int, T> collection)
        {
            _id = id;
            _collection = collection;
        }

        public void Dispose()
        {
        }
        
        public void Flush()
            => _collection.Clear();

        public int Count()
            => Query().Count();

        public int Count(System.Linq.Expressions.Expression<Func<T, bool>> expression)
            => Query().Count(expression);

        public T Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Insert(T entity)
        {
            DateTime now = DateTime.Now;

            entity.CreatedAt = now;
            entity.UpdatedAt = now;

            entity.Id = ++_id;

            _collection.Add(entity.Id.Value, entity);
            return entity;
        }

        public IQueryable<T> Query() 
            => _collection.Values.AsQueryable<T>();

        public IEnumerable<T> Select()
            => _collection.Values.Where(x => x != null).ToList();

        public T Select(int id)
        {
            if(!_collection.ContainsKey(id))
            {
                throw new Exception($"Entidade {id} não foi localizada.");
            }
            return _collection[id];
        }

        public IEnumerable<T> Select(System.Linq.Expressions.Expression<Func<T, bool>> expression)
            => Query()
                .Where(expression)
                .ToList();
        
        public T Update(int id, T entity)
        {
            if(!_collection.ContainsKey(id))
            {
                throw new Exception($"Entidade {id} não foi localizada.");
            }

            entity.UpdatedAt = DateTime.Now;
            _collection[id] = entity;

            return entity;
        }

    }
}
