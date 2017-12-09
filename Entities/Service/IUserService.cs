using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public interface IUserService
    {
        IEnumerable<User> GetAllData();
    }
}
