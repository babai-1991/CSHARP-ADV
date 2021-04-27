namespace CSAdvance.Generics
{
    /*
     Okay, what is this used for? Well in C#, as you know, value types cannot be null, so an integer
     should have a value like 0 1 2 3. It cannot be null. We can use this class to give our value types the
     ability to be Nullable.
    */
    public class Nullable<T> where T : struct
    {
        private readonly object _value;
        public Nullable()
        {
            
        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get
            {
                return _value != null;
            }
        }

        public T GetValueOrDefault()
        {
            if (this.HasValue)
            {
                return (T)_value;
            }
            else
            {
                //getting default value , using builtin default keyword
                //for int it will be 0 and so on.
                return default(T);
            }
        }
    }
}