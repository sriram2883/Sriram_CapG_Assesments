def factorial(n):
    if n == 0:
        return 1
    else:
        return n * factorial(n-1)
n = int(input("Enter the number: "))
if(n<0):
    print("Factorial does not exist for negative numbers")
else:
    print(f"Factorial of {n} is {factorial(n)}")
