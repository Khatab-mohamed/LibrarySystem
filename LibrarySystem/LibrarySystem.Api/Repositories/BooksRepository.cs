using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Api.Context;
using LibrarySystem.Api.Entities;
using LibrarySystem.Api.Interfaces;
using LibrarySystem.Api.ResourceParameter;

namespace LibrarySystem.Api.Repositories
{
    public class BooksRepository:IBooksRepository
    {
        private readonly LibraryDbContext _context;
        public BooksRepository(LibraryDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        private IEnumerable<Book> GetBooks()
        {
            return _context.Books.OrderBy(c => c.Name).ToList();
        }

        public IEnumerable<Book> GetBooks(BookResourceParameter bookResourceParameter)
        {

            if (string.IsNullOrWhiteSpace(bookResourceParameter.MainCategory)|| string.IsNullOrWhiteSpace(bookResourceParameter.MainCategory))
                return GetBooks();
            var collection = _context.Books as IQueryable<Book>;
            if (!string.IsNullOrWhiteSpace(bookResourceParameter.MainCategory))
            {
                var mainCategory = bookResourceParameter.MainCategory.Trim();
                collection = collection.Where(a => a.MainCategory == mainCategory);
            }

            if (string.IsNullOrWhiteSpace(bookResourceParameter.MainCategory)) return collection.ToList();
            {
                var subCategory = bookResourceParameter.SubCategory.Trim();
                collection = collection.Where(a => a.SubCategory == subCategory);
            }

            return collection.ToList();
        }

       
    }
}
