tests = int(raw_input())
for i in xrange(1, tests+1):
	height = 1
	cycle = int(raw_input())
	for j in xrange(1, cycle+1):
		if j % 2 == 0:
			height += 1
		else:
			height *= 2
	print height
