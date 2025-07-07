# Example file for the Python for the C# Developer LinkedIn Learning course by Joe Marini

# Variables can be declared without an explicit type
# Type hints are supported, but they are just for convenience
f: int = 0
print(f)
b: bool = True
print(b)

# re-declaring the variable works
f = "abc"
print(f)

# ERROR: variables of different types cannot be combined
# print("string type " + 123)
print("string type " + str(123))

# Global vs. local variables in functions


def someFunction():
    #global f
    f = "def"
    print(f)


someFunction()
print(f)

# use the del operator to un-declare a variable
del f
# print(f)
