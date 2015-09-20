size = int(input())
array = input().split()
array = list(map(int, array))

for i in range(0, size) :
	j = i
	while (j > 0) and (array[j-1] > array[j]) :
		array[j], array[j-1] = array[j-1], array[j] #swap function
		print (array)
		j -= 1
print (array)