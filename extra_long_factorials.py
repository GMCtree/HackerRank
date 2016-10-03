def fact(n):
    return reduce(lambda x, y: x * y, xrange(1, n + 1))

num = input()
print(fact(num))

