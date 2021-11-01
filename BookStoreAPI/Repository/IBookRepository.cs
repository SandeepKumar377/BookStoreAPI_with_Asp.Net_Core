using BookStoreAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStoreAPI.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBookAsync();
        Task<BookModel> GetBookAsync(int bookId);
    }
}
