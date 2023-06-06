using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public List<Book> Books { get; set; }

        public Library(params Book[] books)
        {
            Books = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return Books.GetEnumerator();   
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
