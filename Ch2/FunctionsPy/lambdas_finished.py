# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini

data = [10, 6, 23, 15, 18, 59, 62, 7, 103, 29, 35]

# regular sort
print("Sorted:")
result = sorted(data)
print(result)

# sort using a lambda
print("Sort by first digit:")
result = sorted(data, key=lambda x: str(x)[0])
print(result)
