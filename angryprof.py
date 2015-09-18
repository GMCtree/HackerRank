num_test = int(input())

for i in range(num_test) :
	count = 0
	students = (input()).split() #grab the number of students required for class
	times = (input()).split() #grab all the times of the kids coming into the class
	for cur_student in times : 
		if int(cur_student) <= 0 : #check if the student is on time
			count += 1
	if count >= int(students[1]) :
		print ("NO")
	if count < int(students[1]) :
		print ("YES")