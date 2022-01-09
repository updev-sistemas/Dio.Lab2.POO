using Dio.Lab2.POO.Domain;
using System.Linq.Expressions;

namespace Dio.Lab2.POO.Infrastructure.Contracts
{
    public interface IDefaultRepository<T> where T : EntityBase
    {
        T Get(int id);

        IEnumerable<T> GetAll();

        IEnumerable<T> FindAll(Expression<Func<T, bool>> expression);

        T Save(T entity);

        T Update(int id, T entity);

        T Delete(int id);
    }
}
