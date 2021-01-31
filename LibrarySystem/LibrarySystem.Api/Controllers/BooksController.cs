using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Api.Entities;
using LibrarySystem.Api.Interfaces;
using LibrarySystem.Api.ResourceParameter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository _booksRepository;

        public BooksController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        [HttpGet]
        [HttpHead]
        public ActionResult<IEnumerable<Book>> GetAuthors(
            [FromQuery] BookResourceParameter bookResourceParameter)
        {
            var books = _booksRepository.GetBooks(bookResourceParameter);
            
            return Ok(books);
        }
    }
}
