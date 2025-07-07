# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini

from abc import ABC, abstractmethod


class graphicshape(ABC):
    # Inheriting from ABC indicates that this is an abstract base class
    def __init__(self):
        super().__init__()

    # declaring a method as abstract requires a subclass to implement it
    @abstractmethod
    def calc_area(self):
        pass


class circle(graphicshape):
    def __init__(self, radius):
        self._radius = radius

    def calc_area(self):
        return 3.14 * (self._radius ** 2)


class square(graphicshape):
    def __init__(self, side):
        self._side = side

    def calc_area(self):
        return self._side * self._side


# Abstract classes can't be instantiated themselves
# g = graphicshape() # this will error

c = circle(10)
print("Circle area is ", c.calc_area())
s = square(12)
print("Square areas is ", s.calc_area())
