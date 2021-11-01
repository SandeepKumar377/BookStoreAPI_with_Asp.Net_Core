using BookStoreAPI.Data;
using BookStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<List<BookModel>> GetAllBookAsync()
        {
            var records = await _context.Books.Select(x=> new BookModel()
            { 
            Id=x.Id,
            Title=x.Title,
            Description=x.Description
            }).ToListAsync();

            return records;
        }
        public async Task<BookModel> GetBookAsync(int bookId)
        {
            var records = await _context.Books.Where(x=>x.Id==bookId).Select(x=> new BookModel()
            { 
            Id=x.Id,
            Title=x.Title,
            Description=x.Description
            }).FirstOrDefaultAsync();

            return records;
        }
    }
}
