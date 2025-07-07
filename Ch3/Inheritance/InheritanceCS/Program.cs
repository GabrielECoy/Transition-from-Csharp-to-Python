using System;

namespace InheritanceCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Leo Tolstoy", "War and Peace", 21.95m);
            Book b2 = new Book("Aldous Huxley", "Brave New World", 24.95m);

            Console.WriteLine(b1);
            Console.WriteLine(b1.mTitle);
            Console.WriteLine(b2);
            Console.WriteLine(b2.mAuthor);
        }
    }

    class Publication
    {
        protected string _mTitle;
        protected decimal _mPrice;

        public Publication(string title, decimal price)
        {
            _mTitle = title;
            _mPrice = price;
        }
    }

    class Book : Publication
    {
        protected string _mAuthor;

        public Book(string title, string author, decimal price) :
            base(title, price)
        {
            _mAuthor = author;
        }
        public override string ToString()
        {
            return $"{mTitle} by {mAuthor}, price ${mPrice}";
        }

        public string mTitle
        {
            get { return _mTitle; }
            set { _mTitle = value; }
        }
        public string mAuthor
        {
            get { return _mAuthor; }
            set { _mAuthor = value; }
        }
        public decimal mPrice
        {
            get { return _mPrice; }
            set { _mPrice = value; }
        }
    }
}
