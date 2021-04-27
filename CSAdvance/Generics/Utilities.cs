using System;

namespace CSAdvance.Generics
{
    //5 types of constrains.....

    //1. where T:ICompareable [applying a constraint to an interface ]
    //2. where T:struct/int/other value type [applying a constraint on a value type ]
    //3. where T:Product etc [In this case T is product or any of its children]
    //4. where T:class [ where T is a class as in it has to be a reference type.]
    //5.where T:new() [Or , where T is an object that has a default constructor.]
    public class Utilities<T> where T:IComparable, new()
    {
        /* let's say we would like to create a method that gets two parameters,
         let's say two numbers, and returns the bigger one.
        */

        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T DoSomething()
        {
            var TNew = new T();
            return TNew;
        }
        //generic version of Max()
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}