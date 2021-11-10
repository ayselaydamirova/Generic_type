using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_type
{
    class Book
    {
        static int _totalCount;
        public Book()
        {
            _totalCount++;
            No = 0 + _totalCount;
        }
        public int No;
        public string Name;
        public string AuthorName;
        public int PageCount;

    }
    


}
