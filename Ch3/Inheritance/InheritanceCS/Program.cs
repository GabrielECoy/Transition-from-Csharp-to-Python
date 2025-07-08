using System;

// .NET 9 top-level statements and primary constructors
Book b1 = new Book("Leo Tolstoy", "War and Peace", 21.95m);
Book b2 = new Book("Aldous Huxley", "Brave New World", 24.95m);

Console.WriteLine(b1);
Console.WriteLine(b1.Title);
Console.WriteLine(b2);
Console.WriteLine(b2.Author);

class Publication(string Title, decimal Price)
{
    public string Title { get; set; } = Title;
    public decimal Price { get; set; } = Price;
}

class Book(string Title, string Author, decimal Price) : Publication(Title, Price)
{
    public string Author { get; set; } = Author;

    public override string ToString() => $"{Title} by {Author}, price ${Price}";
}
