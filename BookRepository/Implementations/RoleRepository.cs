using DATA.Data;
using DATA.Data.Entity;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class RoleRepository:GenericRepository<Role>,IRoleRepository
    {
        public RoleRepository(BookDbContext bookDbContext) : base(bookDbContext) { }

    }
}
