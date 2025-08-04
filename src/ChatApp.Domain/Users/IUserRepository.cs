using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Domain.Users
{
    public interface IUserRepository
    {
        void Add(User user);
        void Update(User user);
        void Remove(User user);
        Task<User?> GetByEmail(string email);
        Task<User?> GetById(long id);

    }
}