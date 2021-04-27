namespace CSAdvance.Generics
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class DiscountCalculator<TBook> where TBook : Book
    {
        public double Calculate(TBook book)
        {
            return book.Price * .1;
        }
    }
}