# Example file for the Python for the C# Developer LinkedIn Learning course by Joe Marini

# Exceptions in Python are similar to those in C#
# There's a try-except-finally mechansism

try:
    a = 10
    b = 5
    x = a / b
    #c = None

    if a > 20:
        raise ValueError("Can't go more than 20!")
    print("Result is ", x)
    #x = int(c)
except ZeroDivisionError as e:
    print("Whoops! ", e)
except ValueError as e:
    print("uh oh:", e)
except BaseException as e:
    print(e)
finally:
    print("This code always runs")
