using Dio.Lab2.POO.Domain;
using Dio.Lab2.POO.Infrastructure.Context;
using Dio.Lab2.POO.Infrastructure.Contracts;

using System.Linq.Expressions;

namespace Dio.Lab2.POO.Infrastructure.Repository
{
    public class ItemRepository : AbstractRepository, IItemRepository
    {
        public ItemRepository(Database db) : base(db)
        {
        }

        public ItemEntity Delete(int id)
            => Db.Item.Delete(id);

        public IEnumerable<ItemEntity> FindAll(Expression<Func<ItemEntity, bool>> expression)
            => Db.Item.Select(expression);

        public ItemEntity Get(int id)
            => Db.Item.Select(id);

        public IEnumerable<ItemEntity> GetAll()
            => Db.Item.Select();

        public ItemEntity Save(ItemEntity entity)
            => Db.Item.Insert(entity);

        public ItemEntity Update(int id, ItemEntity entity)
            => Db.Item.Update(id, entity);
    }
}
