# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini

# Python provides a way to require that some arguments can only be called
# by keyword. This is usually used when the argument is important and you
# want the caller to explicitly use the argument name


def myFunction(arg1, arg2, *, suppressExceptions=False):
    print(arg1, arg2, suppressExceptions)


# try to call the function without the keyword
# myFunction(1, 2, True)
myFunction(1, 2, suppressExceptions=True)
