using System;
using Generics;

namespace CsharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book
            {
                Id = 1,
                Name = "FixItNooo"
            };

            var books = new GenericList<Book>();
            books.Add(book);

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("test", book);

            var number = new Generics.Nullable<int>();
            Console.WriteLine("Has Value?"+number.HasValue);
            Console.WriteLine("Value"+number.GetValueOrDefault());

            Console.WriteLine("Hello World!");
        }
    }
}
