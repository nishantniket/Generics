using System;
using CsharpPractice;

namespace Generics
{
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index] => throw new NotImplementedException();
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index] => throw new NotImplementedException();
    }

    public class Utilities<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b) 
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    //This is an example of Constraint with =>  where T is a product class type or any of the children of the class Product
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

    //This is an example of Constraint with => where T is a Value Type , struct in this case
    public class Nullable<T> where T : struct
    {
        public Nullable()
        {

        }
        //This is boxing. 
        private readonly object _value;
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue => _value != null;

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                //this is unboxing
                return (T)_value;
            }

            return default(T);

        }
    }

    //This is an example of Constraint with => where T is an object that has a default constructor .Also multiple Constraint
    public class UtilitiesMultiple<T> where T : IComparable,new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            //This worked there because of the constraint new() which allowed the default constructor to be used.
            var obj = new T();
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
