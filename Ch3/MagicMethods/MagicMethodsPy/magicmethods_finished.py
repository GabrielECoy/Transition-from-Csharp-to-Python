# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini


class magicmethods():
    def __init__(self, name, size):
        self._name = name
        self._size = size

    # use str for a more human-readable string
    def __str__(self):
        return f"Magic methods object '{self._name}' is {self._size}"

    # use __repr__ to create a string useful for debugging
    def __repr__(self):
        return f"<magicmethods class (name:{self._name}), (size:{self._size})>"

    # use eq to test for equality
    def __eq__(self, other):
        return self._name == other._name and self._size == other._size


mm1 = magicmethods("Foo", 10)
mm2 = magicmethods("Bar", 20)
mm3 = magicmethods("Foo", 10)

print(mm1)
print(repr(mm2))

print(mm1 == mm2)
print(mm1 == mm3)
