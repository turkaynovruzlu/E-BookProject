using Repository.Interfaces;
using DATA.Data;
using DATA.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class UserRepository:GenericRepository<User>,IUserRepository
    {
        public UserRepository(BookDbContext bookDbContext) : base(bookDbContext) { }

    }
}
