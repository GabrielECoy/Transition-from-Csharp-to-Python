using System;

// .NET 9 top-level statements style
Book b1 = new Book("Leo Tolstoy", "War and Peace", 21.95m);
Book b2 = new Book("Aldous Huxley", "Brave New World", 24.95m);

Console.WriteLine(b1);
Console.WriteLine(b1.mTitle);
Console.WriteLine(b2);
Console.WriteLine(b2.mAuthor);

class Book(string mTitle, string mAuthor, decimal mPrice)
{
    public string mTitle { get; set; } = mTitle;
    public string mAuthor { get; set; } = mAuthor;
    public decimal mPrice { get; set; } = mPrice;

    public override string ToString() => $"{mTitle} by {mAuthor}, price ${mPrice}";
}
