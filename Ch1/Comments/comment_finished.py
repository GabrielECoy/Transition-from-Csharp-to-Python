# Example HelloWorld file for the Python for the C# Developer LinkedIn Learning course
"""This is a module-level string.

Comments can be placed at the module or function level.
"""


def main():
    '''This is a Python program
    With a multi-line documentation string in it.
    You can access this directly via the __doc__ attribute
    '''
    # In python, comments are created using hash characters. There is no
    # direct equivalent for multi-line comments like there is in C#
    print("Hello World")
    print(main.__doc__)
    # The __doc__ attribute contains the docstring for the function
    print(__doc__)
    # The __doc__ attribute contains the docstring for the module
    
if __name__ == "__main__":
    main()
