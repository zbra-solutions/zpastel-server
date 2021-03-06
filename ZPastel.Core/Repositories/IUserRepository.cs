﻿using System.Threading.Tasks;
using ZPastel.Model;

namespace ZPastel.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> FindByFirebaseId(string firebaseId);
        Task<User> FindById(long id);
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(User user);
    }
}
