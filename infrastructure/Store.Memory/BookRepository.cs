using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "Art of Programming"),
            new Book(2, "Refactoring"),
            new Book(3, "C Programming Language")
        };

        public Book[] GetByTitle(string titlePart)
        {
            return books
                .Where(b => b.Title.Contains(titlePart))
                .ToArray();
        }
    }
}
