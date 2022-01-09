using Dio.Lab2.POO.Domain;
using Dio.Lab2.POO.Infrastructure.Context;
using Dio.Lab2.POO.Infrastructure.Contracts;
using System.Linq.Expressions;

namespace Dio.Lab2.POO.Infrastructure.Repository
{
    public class CategoryRepository : AbstractRepository, ICategoryRepository
    {
        public CategoryRepository(Database db) : base(db)
        {
        }

        public CategoryEntity Delete(int id)
            => Db.Category.Delete(id);

        public IEnumerable<CategoryEntity> FindAll(Expression<Func<CategoryEntity, bool>> expression)
            => Db.Category.Select(expression);

        public CategoryEntity Get(int id)
            => Db.Category.Select(id);

        public IEnumerable<CategoryEntity> GetAll()
            => Db.Category.Select();

        public CategoryEntity Save(CategoryEntity entity)
            => Db.Category.Insert(entity);

        public CategoryEntity Update(int id, CategoryEntity entity)
            => Db.Category.Update(id, entity);
    }
}
