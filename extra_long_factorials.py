def fact(n):
    if n == 0:
        return 1
    return n * fact(n - 1)

num = input()
print(fact(num))

