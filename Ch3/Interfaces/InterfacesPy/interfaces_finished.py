# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini

from abc import ABC, abstractmethod


class graphicshape(ABC):
    def __init__(self):
        super().__init__()

    @abstractmethod
    def calc_area(self):
        pass


class jsonify(ABC):
    @abstractmethod
    def to_json(self):
        pass


class square(graphicshape, jsonify):
    def __init__(self, side):
        self._side = side

    def calc_area(self):
        return self._side * self._side

    def to_json(self):
        return f"{{ \"square\": {str(self.calc_area())} }}"


s = square(10)
print("Square area is ", s.calc_area())
print("Square to JSON code is: ", s.to_json())
