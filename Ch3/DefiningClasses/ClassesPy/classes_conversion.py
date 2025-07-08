class Book:
    def __init__(self, title, author, price):
        self.title = title
        self.author = author
        self.price = price

    def __str__(self):
        return f"{self.title} by {self.author}, price ${self.price}"

b1 = Book("Leo Tolstoy", "War and Peace", 21.95)
b2 = Book("Aldous Huxley", "Brave New World", 24.95)

print(b1)
print(b1.title)
print(b2)
print(b2.author)