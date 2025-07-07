# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini


fruitlist = []  # declare an empty list
listwithdata = ['a', 1, True, "Bob"]  # declare a list with content

# append data to a list
fruitlist.append("apple")
fruitlist.extend(["orange", "banana", "melon"])
print(fruitlist)

# insert data
fruitlist.insert(2, "grape")
print(fruitlist)

# search for a list item
print("pear" in fruitlist)
print(fruitlist.index("banana"))
# print(fruitlist.index("pear"))

# modify an item in-place
fruitlist[3] = "mango"
print(fruitlist)

# remove an item
fruitlist.remove("grape")
print(fruitlist)

# empty the list
fruitlist.clear()

# lists can be created using the list() global function
chars = list("abcdefg")
print(chars)
nums = list(range(50, 100, 5))
print(nums)
