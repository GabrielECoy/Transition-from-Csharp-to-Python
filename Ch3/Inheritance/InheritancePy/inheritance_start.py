# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini


class Book:
    def __init__(self, title, author, price):
        # properties that start with _ are a hint that they should be considered private
        self._title = title
        self._author = author
        self._price = price

    # public properties can be indicated with a property decorator
    # this one creates a getter
    @property
    def title(self):
        return self._title

    # this one creates a setter
    @title.setter
    def title(self, value):
        self._title = value

    @property
    def author(self):
        return self._author

    @author.setter
    def author(self, value):
        self._author = value

    @property
    def price(self):
        return self._price

    @price.setter
    def price(self, value):
        self._price = value


# Create an instance of the class
b1 = Book("War and Peace", "Leo Tolstoy", 21.95)
print(b1.title)
b1.title = "Anna Karenina"
print(b1.title)
print(b1.price)
