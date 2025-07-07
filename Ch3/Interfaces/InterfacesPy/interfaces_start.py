# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini

from abc import ABC, abstractmethod


class graphicshape(ABC):
    def __init__(self):
        super().__init__()

    @abstractmethod
    def calc_area(self):
        pass


class square(graphicshape):
    def __init__(self, side):
        self._side = side

    def calc_area(self):
        return self._side * self._side


s = square(10)
print("Square area is ", s.calc_area())
