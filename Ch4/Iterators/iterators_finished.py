# Exercise file for Python for the C# Developer LinkedIn Learning course by Joe Marini

# define a list of days in English and French
days = ["Sunday", "Monday", "Tueday", "Wedday", "Thuday", "Friday", "Satday"]
daysFr = ["Dimanche", "Lunedi", "Martedi",
          "Mercoledi", "Jeudi", "Vendredi", "Samedi"]
daysdict = {"Sun": "Dim", "Mon": "Lun", "Tue": "Mar",
            "Wed": "Mer", "Thu": "Jeu", "Fri": "Ven", "Sat": "Sam"}

# iterate over a list
print("using iter:")
i = iter(days)
print(next(i))  # Sun
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

# use the zip function
print("using zip:")
for m in zip(days, daysFr):
    print(m)

# combine enumerate and zip
print("using enumerate with zip:")
for i, m in enumerate(zip(days, daysFr), start=1):
    print(f"Day {i}, {m[0]} is {m[1]}, in French")
