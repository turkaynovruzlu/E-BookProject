using Repository.Implementations;
using DATA.Data;
using DATA.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repository.Implementations
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        private readonly BookDbContext bookDbContext;
        public BookRepository(BookDbContext bookDbContext) : base(bookDbContext)
        {
            this.bookDbContext = bookDbContext;
        }

        public async Task<List<Book>> SearchBook(string x)
        {
            return await bookDbContext.Books.Where(m => x == m.Bookname || x == m.Genre || x == m.Publisher ).ToListAsync();
        }

        public async Task<List<Book>> SearchBook(int x)
        {
            return await bookDbContext.Books.Where(m=>x==m.Price||x==m.PageCount).ToListAsync();
        }
    }
}
