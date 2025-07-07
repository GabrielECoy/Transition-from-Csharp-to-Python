# Example HelloWorld file for the Python for the C# Developer LinkedIn Learning course

print("RunningTally(tm)")
print("Enter a number to start the tally, enter 'quit' to stop")
run = True
total = 0

while(run):
    try:
        # use the input method to read the command line
        str = input()
        if str == "quit":
            run = False
        else:
            # the int function tries to convert the input to an integer
            val = int(str)
            total += val
            print(total)
    except ValueError:
        # if int() throws an error then we ignore it and keep going
        pass
