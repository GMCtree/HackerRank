num_students = int(input())
students = {}
for x in range(0, num_students) :
	person = input().split() # get all the information of the student
	name = person.pop(0)
	marks = list(map(float, person)) # convert marks to float
	students[name] = marks # add student to dictionary
check = str(input())
avg = sum(students[check]) / 3 # only 3 courses
print ("%.2f" % avg)

