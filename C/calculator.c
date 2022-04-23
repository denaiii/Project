#include <stdio.h>

void clear_stdin () {
	while (getchar() != '\n') {}
}

int main () {
char dx;
int num1, num2, c;

	printf ("Input number #1; ");
	scanf("%d", &num1);

	printf ("Input number #2; ");
	scanf("%d", &num2);

	clear_stdin ();

	printf ("Input character (+,-,*,/): ");
	scanf ("%c", &dx);

	switch (dx)
	{

	case '+':
	printf ("%d + %d= %d",num1,num1,num1+num2);
	break;

	case '-':
	printf ("%d - %d= %d",num1,num2,num1-num2);

	case '*':
	printf ("%d * %d= %d",num1,num2,num1*num2);

	case '/':
	printf ("%d / %d= %d",num1,num2,num1/num2);

	break;
	default:
	printf ("\nError! operator is not correct\n");
}
return 0;
}
