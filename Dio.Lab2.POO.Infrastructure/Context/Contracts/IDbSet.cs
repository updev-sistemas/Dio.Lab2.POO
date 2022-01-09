using Dio.Lab2.POO.Domain;
using System.Linq.Expressions;


namespace Dio.Lab2.POO.Infrastructure.Context.Contracts
{
    public interface IDbSet<T> where T : class
    {
        void Flush();
        int Count();
        int Count(Expression<Func<T, bool>> expression);
        IQueryable<T> Query();
        IEnumerable<T> Select();
        T Select(int id);
        IEnumerable<T> Select(Expression<Func<T, bool>> expression);
        T Insert(T entity);
        T Update(int id, T entity);
        T Delete(int id);
    }
}
