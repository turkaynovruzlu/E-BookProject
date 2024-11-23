using Repository.Interfaces;
using DATA.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<List<Book>> SearchBook(string x);
        Task<List<Book>> SearchBook(int x);

    }
}
