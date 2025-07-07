# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini

# declare an empty dictionary
fileDesc = {}
# dictionaries can also be declared with initial content
nums = {1: "one", 2: "two", 3: "three"}

# add some items
fileDesc["pdf"] = "Portable Document Format"
fileDesc["txt"] = "Text File"
fileDesc["rtf"] = "Rich Text Format"
fileDesc["jpg"] = "JPEG Image"
fileDesc["png"] = "Portable Network Graphic Image"

# get the item count
print(f"Dictionary contains {len(fileDesc)} items")

# adding an existing key just replaces the item
fileDesc["png"] = "PNG File"
print(fileDesc["png"])

# check if a key exists
print("txt" in fileDesc.keys())

# check if a value exists
print("JPEG Image" in fileDesc.values())

# remove a single item
del fileDesc["pdf"]
print(f"Dictionary contains {len(fileDesc)} items")

# clear all values
fileDesc.clear()
print(f"Dictionary contains {len(fileDesc)} items")
