using System;
using System.Collections.Generic;

namespace CSAdvance.LambdaExpression
{
    public class Exercise
    {
        public void Start()
        {
            BookRepository repository = new BookRepository();
            List<Book> books = repository.GetBooks();

            List<Book> list = books.FindAll((book) => book.Price < 10);
        }

        //predicate function
        //bool IsCheaperThan10Dollar(Book book)
        //{
        //    return book.Price < 10;
        //}

    }
}
