using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.Linq;
using System.Linq.Expressions;

namespace Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(PlutoContext context) 
            : base(context)
        {
        }

        public PlutoContext PlutoContext
        {
            get { return _context as PlutoContext; }
        }
    }
}
