def count_digits(num):
	numstring = str(num)
	count = 0
	for x in numstring:
		if x != "0": #checks if 0 to avoid division by zero
			if num % int(x) == 0:
				count += 1
	return count

numcases = int(raw_input())
for x in xrange(0, numcases):
	numdigits = 0
	currentnum = int(raw_input())
	numdigits = count_digits(currentnum)
	print numdigits
