using Dio.Lab2.POO.Domain;
using Dio.Lab2.POO.Infrastructure.Context.Contracts;
using System;

namespace Dio.Lab2.POO.Infrastructure.Context
{
    public class Database
    {
        private IDbSet<CategoryEntity> _category;
        private IDbSet<ItemEntity> _item;

        public Database()
        {
            _category = new DbSet<CategoryEntity>();
            _item = new DbSet<ItemEntity>();
        }

        public IDbSet<CategoryEntity> Category => _category;
        public IDbSet<ItemEntity> Item => _item;
    }
}
