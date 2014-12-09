#include <stdio.h>

int isFibo(long int);

int main() {
	int numcases, i;
	long int num;
	scanf("%d", &numcases);
	for (i = 0; i < numcases; i++) {
		scanf("%lu", &num);
		if (isFibo(num) == 1)
			printf("IsFibo\n");
		else
			printf("IsNotFibo\n");
	}
	return 0;
}

/* only goes through the first million fibonacci numbers because the range given by the problem will not exceed the millionth fibonacci number */
int isFibo(long int n) {
	long int num1 = 0, num2 = 1, fib = 0, i;
	for (i = 0; i < 1000000; i++) {
		fib = num1 + num2;
		if (fib == n)
			return 1;
		num1 = num2;
		num2 = fib;
	}
	return 0;
}
