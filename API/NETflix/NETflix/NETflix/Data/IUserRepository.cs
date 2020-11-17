using NETflix.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETflix.Data
{
    public interface IUserRepository
    {
        void Create(User user);
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Remove(User user);
        void Update(User user);
    }
}
