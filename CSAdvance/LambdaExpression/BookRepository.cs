using System.Collections.Generic;

namespace CSAdvance.LambdaExpression
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() {Id = 1, Title = "C# in depth", Price = 10},
                new Book() {Id = 2, Title = "jQuery in Action", Price = 7},
                new Book() {Id = 3, Title = "GIT Source control management", Price = 5},
            };
        }
    }
}
