# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini

# Functions can have default parameter values like in C#
# They can also be explicitly used in the calling location


def namedparams(a,  b,  c=False):
    if c:
        print("'a' comes first")
        print(a)
        print(b)
    else:
        print("'b' comes first")
        print(b)
        print(a)


# Functions can then be called using named parameters
# once you use a named parameter, all following params must be
# called by name as well
namedparams(5, b="hello", c=True)
namedparams(10, b="world")
