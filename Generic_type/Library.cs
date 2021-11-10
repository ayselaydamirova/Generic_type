using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_type
{
    class Library
    {
        Book books = new Book();
        List<Book> list = new List<Book>();
        private int _totalCount;
        private object _books;

        public int No { get; private set; }

        public void Add(Book book)
        {

            _totalCount++;
            No = 0 + _totalCount;

        }

        public string FindAllBooksByName(string book)
        {
            return _books[];
        }
    }
}
