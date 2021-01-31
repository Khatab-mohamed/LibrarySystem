using System;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Api.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public Guid AuthorId { get; set; }
    }
}
