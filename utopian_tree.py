tests = int(input())
for i in range(1, tests+1):
	height = 1
	cycle = int(input())
	for j in range(1, cycle+1):
		if j % 2 == 0:
			height += 1
		else:
			height *= 2
	print(height)
