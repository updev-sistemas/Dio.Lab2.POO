using Dio.Lab2.POO.Infrastructure.Context;
using Dio.Lab2.POO.Infrastructure.Contracts;
using Dio.Lab2.POO.Infrastructure.Repository;
using System;

namespace Dio.Lab2.POO.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
            var db = new Database();

            _category = new CategoryRepository(db);
            _item = new ItemRepository(db);
        }

        private ICategoryRepository _category = null;
        public ICategoryRepository Category => _category;

        private IItemRepository _item = null;
        public IItemRepository Item => _item;
    }
}
