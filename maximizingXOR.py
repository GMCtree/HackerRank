def  maxXor(l, r):
	largest = 0
	for i in xrange(l, r+1):
		for j in xrange(l, r+1):
			current = i ^ j #performs bitwise XOR
			if current > largest:
				largest = current
	return largest
    
l = int(raw_input());
r = int(raw_input());
res = maxXor(l, r);
print res

