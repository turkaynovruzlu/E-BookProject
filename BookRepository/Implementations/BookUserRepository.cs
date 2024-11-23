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
    public class BookUserRepository:GenericRepository<BookUser>,IBookUserRepository
    {
        public BookUserRepository(BookDbContext bookDbContext):base(bookDbContext) { }
        
    }
}
