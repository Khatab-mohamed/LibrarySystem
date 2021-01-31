using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Api.Entities;
using LibrarySystem.Api.ResourceParameter;

namespace LibrarySystem.Api.Interfaces
{
    public interface IBooksRepository
    {
        IEnumerable<Book> GetBooks(BookResourceParameter parameter);
    }
}
