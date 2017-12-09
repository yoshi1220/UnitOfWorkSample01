using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Repositories;

namespace Services
{
    public class UserService : IUserService
    {
        public IEnumerable<User> GetAllData()
        {
            using (var uow = new UnitOfWork(new PlutoContext()))
            {
                return uow.Users.GetAll();
            }
        }
    }
}
