# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini

# functions are defined using the def keyword, then
# the : character and whitespace indentation define the function body


def myfunc():
    print("This is a line of code in my function")
    # functions can return a value or not
    return 42


def myvoidfunc(a, b):
    print("This function returns nothing")
    print(a + b)


def variableargs(a, b, *args):
    print(a + b)
    for arg in args:
        print(arg)


# functions are called pretty much the same as in C#
# if there is no return value, the result is None
retval = myfunc()
print(retval)

retval = myvoidfunc(5, 10)
print(retval)

# Call a function with a variable set of arguments
variableargs(1, 2, "bob", 3.0, 5)
