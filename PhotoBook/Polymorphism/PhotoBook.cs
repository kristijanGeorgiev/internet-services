using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBook.Polymorphism
{
    class Book
    {
        public int numPages { get; set; }
        public Book()
        {
            numPages = 16;
        }
        public Book(int numPages)
        {
            this.numPages = numPages;
        }
        public virtual int GetNumPages()
        {
            return numPages;
        }
    }
    class BigPhotoBook : Book
    {
        public BigPhotoBook(int numPages) : base(numPages)
        {
            this.numPages = numPages;
        }
        public BigPhotoBook()
        {
            this.numPages = 15;
        }
        public override int GetNumPages()
        {
            return numPages;
        }
    }
}
