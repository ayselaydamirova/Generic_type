using System;

namespace Generic_type
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book();
            var book2 = new Book();
            var book3 = new Book();
            var book4 = new Book();

            Console.WriteLine(book1.No);
            Console.WriteLine(book2.No);
            Console.WriteLine(book3.No);
            Console.WriteLine(book4.No);

            BookList bookList = new BookList();
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);
        }
    }
}
