using System;

namespace CSAdvance.Generics
{
    public class Exercise
    {
        public static void Start()
        {
            ////using .NET > 2.0
            //var numbers = new List();
            //numbers.Add(1);

            var book = new Book() { Id = 1, Name = "C# in depth" };
            //var booklist = new BookList();
            //booklist.Add(book);


            //// generic list come into action 
            //var genericList1 = new GenericList<int>();
            //genericList1.Add(1);
            //var genericList2 = new GenericList<Book>();
            //genericList2.Add(book);

            //using multiple template variable
            //var genericDictionary = new GenericDictionary<string,Book>();
            //genericDictionary.Add("book-1",book);

            //using constraint as value type
            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value?"+number.HasValue);
            Console.WriteLine("Get value: "+number.GetValueOrDefault());

            var number2 = new Nullable<int>();
            Console.WriteLine("Has Value?" + number2.HasValue);
            Console.WriteLine("Get value: " + number2.GetValueOrDefault());
        }
    }
}
