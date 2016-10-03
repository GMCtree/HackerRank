def fact(n):
    if n == 0:
        return 1
    return reduce(lambda x, y: x * y, xrange(1, n + 1))

assert(fact(5) == 5 * 4 * 3 * 2 * 1)
assert(fact(0) == 1)
assert(fact(2) == 2)

num = input()
print(fact(num))

