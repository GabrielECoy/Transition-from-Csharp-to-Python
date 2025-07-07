# Python for the C# Developer by Joe Marini
# Example code file for loops

# the Python for loop always acts as an iterator - the typical
# (init value, test, increment) pattern isn't something you see in Python

# to iterate over a count, you create a numerical iterator with range()
for i in range(10):
    print(i, end=" ")
print("\n---------")

for i in range(-5, 5, 2):
    print(i, end=" ")
print("\n---------")


# iterating over a collection or string is the same as with C# foreach,
# but we use the same "for" keyword
thestr = "Hello World!"
for c in thestr:
    print(c + ",", end=" ")
print("\n---------")

# if you really need an index, you can use enumerate()
for i, c in enumerate(thestr):
    print(str(i) + "," + c + ",", end=" ")
print("\n---------")


# Similarly, there's only a while loop in python and no do-while, which
# is just syntactic sugar for a loop that always executes at least once
keepgoing = True
i = 0
while (keepgoing):
    print("Num: ", i)
    i += 1
    if i == 10:
        keepgoing = False
