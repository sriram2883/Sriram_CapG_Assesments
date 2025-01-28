def celsius_to_fahrenheit(celsius):
    return (celsius * 9/5) + 32

def fahrenheit_to_celsius(fahrenheit):
    return (fahrenheit - 32) * 5/9

def celsius_to_kelvin(celsius):
    return celsius + 273.15

def kelvin_to_celsius(kelvin):
    return kelvin - 273.15

def fahrenheit_to_kelvin(fahrenheit):
    celsius = fahrenheit_to_celsius(fahrenheit)
    return celsius_to_kelvin(celsius)

def kelvin_to_fahrenheit(kelvin):
    celsius = kelvin_to_celsius(kelvin)
    return celsius_to_fahrenheit(celsius)

print("Temperature Conversion")
print("1. Celsius to Fahrenheit")
print("2. Fahrenheit to Celsius")
print("3. Celsius to Kelvin")
print("4. Kelvin to Celsius")
print("5. Fahrenheit to Kelvin")
print("6. Kelvin to Fahrenheit")

choice = int(input("Enter your choice (1-6): "))
temp = float(input("Enter the temperature to convert: "))

if choice == 1:
    print(f"{temp} Celsius is {celsius_to_fahrenheit(temp)} Fahrenheit")
elif choice == 2:
    print(f"{temp} Fahrenheit is {fahrenheit_to_celsius(temp)} Celsius")
elif choice == 3:
    print(f"{temp} Celsius is {celsius_to_kelvin(temp)} Kelvin")
elif choice == 4:
    print(f"{temp} Kelvin is {kelvin_to_celsius(temp)} Celsius")
elif choice == 5:
    print(f"{temp} Fahrenheit is {fahrenheit_to_kelvin(temp)} Kelvin")
elif choice == 6:
    print(f"{temp} Kelvin is {kelvin_to_fahrenheit(temp)} Fahrenheit")
else:
    print("Invalid choice")
