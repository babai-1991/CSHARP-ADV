using System;
using System.Net.NetworkInformation;

namespace CSAdvance.Generics
{
    public class GenericList<T>
    {
        public void Add(T value)
        {
            throw new NetworkInformationException();
        }

        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}