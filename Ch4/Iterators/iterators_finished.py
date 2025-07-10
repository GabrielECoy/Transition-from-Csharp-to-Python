# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini

# define a list of days in English and French
days = ["Sunday", "Monday", "Tueday", "Wedday", "Thuday", "Friday", "Satday"]
daysFr = ["Dimanche", "Lunedi", "Martedi",
          "Mercoledi", "Jeudi", "Vendredi", "Samedi"]
daysdict = {"Sun": "Dim", "Mon": "Lun", "Tue": "Mar",
            "Wed": "Mer", "Thu": "Jeu", "Fri": "Ven", "Sat": "Sam"}

# iterate over a list
print("using iter:")
i = iter(daysdict.items())
print(next(i))  # Sun
key1, value1 = next(i)
print(f"{key1}: {value1}")
print(next(i))  # Mon
print(next(i))  # Tue

# iterate over a dictionary using regular iterator
print("dictionary iteration:")
for key in daysdict:
    print(key, ":", daysdict[key])

print("\n---------\n")

for k, v in daysdict.items():
    print(k, ":", v)

# use the enumerate function
print("using enumerate:")
for i, m in enumerate(days, start=1):
    print(i, m)

print("using enumerate over dict:")
for i, m in enumerate(daysdict.items(), start=1):
    print(i, m, m[0], m[1])

# use the zip function
print("using zip:")
for m in zip(days, daysFr):
    print(m, m[0], m[1])

# combine enumerate and zip
print("using enumerate with zip:")
for i, m in enumerate(zip(days, daysFr), start=1):
    print(f"Day {i}, {m[0]} is {m[1]}, in French")
