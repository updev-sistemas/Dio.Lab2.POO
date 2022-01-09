using Dio.Lab2.POO.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dio.Lab2.POO.Infrastructure
{
    public interface IUnitOfWork
    {
        public ICategoryRepository Category { get; }
        public IItemRepository Item { get; }
    }
}
