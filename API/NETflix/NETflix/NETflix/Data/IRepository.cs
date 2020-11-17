using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETflix.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Update(T entity);
        void Remove(T entity);
    }
}
