# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini


class graphicshape:
    def __init__(self):
        super().__init__()

    def calc_area(self):
        pass


class circle(graphicshape):
    def __init__(self, radius):
        self._radius = radius


class square(graphicshape):
    def __init__(self, side):
        self._side = side


g = graphicshape()

c = circle(10)
print(c.calc_area())
s = square(12)
print(s.calc_area())
