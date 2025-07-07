# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini
# Built-in functions finished example

# Where C# takes the approach of having class methods for many kinds of
# operations, Python has a set of global built-in functions that perform
# the same tasks.

# Define some data to use in our functions
numbers = [10, 6, 23, 15, 18, 59, 62, 7, 103, 29, 35]
names = ["Amy", "Adam", "Benjamin", "Elise", "Terry", "Ziggy"]
somestr = "The quick brown fox jumped over the lazy dog"

# The len function will return the length of any iterable
print(len(numbers))
print(len(somestr))

# min and max calculate the smallest and largest values
minnum = min(numbers)
maxnum = max(numbers)
print(minnum, maxnum)

# min and max can also use a key function to provide a comparable value
minname = min(names, key=lambda x: len(x))
maxname = max(names, key=lambda x: len(x))
print(minname, maxname)

# The sorted function will return a new sorted list from an iterable
print(sorted(numbers))
print(sorted(names, key=lambda x: len(x)))
print(sorted(somestr))

# any and all can be used to perform a test on a set of data
print(any(len(w) > 4 for w in names))
print(all(x > 20 for x in numbers))
