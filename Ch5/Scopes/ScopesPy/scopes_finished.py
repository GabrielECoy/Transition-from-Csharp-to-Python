# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini

# Python uses the "with" statement to define a scope block
linecount = 0
with open("MyTextFile.txt", "r") as thefile:
    while True:
        str = thefile.readline()
        if not str:
            break
        print(str)
        linecount += 1

print(f"The file has {linecount} lines")
