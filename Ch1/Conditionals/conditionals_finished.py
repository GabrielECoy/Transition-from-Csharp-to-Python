# Python for the C# Developer by Joe Marini
# Example code file for conditional statements

# Python only has an if/elif/else construct, unlike C#
# which supports switch statements

x = 10
y = 20
z = 30

# TODO: define an if-elif-else structure
if x < y:
    print("result #1")
    print("----------")
elif z > x and y < z:
    print("result #2")
    print("----------")
else:
    print("result #3")
    print("----------")

# TODO: use the compact if-else format
print("result #4") if x < y else print("result #5")
