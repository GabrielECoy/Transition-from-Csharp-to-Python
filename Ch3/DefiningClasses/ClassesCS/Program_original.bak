using System;

namespace ClassesCS
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

    class Book
    {
        private string _mTitle;
        private string _mAuthor;
        private decimal _mPrice;

        public Book(string title, string author, decimal price)
        {
            mTitle = title;
            mAuthor = author;
            mPrice = price;
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
