using Dio.Lab2.POO.Infrastructure.Context;
using System;

namespace Dio.Lab2.POO.Infrastructure.Repository
{
    public abstract class AbstractRepository
    {
        protected AbstractRepository(Database database) => _db = database;
        private Database _db { get; set; }
        protected Database Db => _db;
    }
}
