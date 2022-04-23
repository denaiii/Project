#include <stdio.h>

int main ()
{

	int x,y,z,a,number;
	printf ("Enter odd number to make a diamond :\n");
	scanf ("%d", &number);
	 a = (number+1)/2;
	for (x=1; x<=a; x++)

	{
		for (z=1; z<=(a-x); z++)
			printf (" ");

		for (y=1; y<=x; y++)
			printf ("*");

		for (y=2; y<=x; y++)
			printf ("*");

		 printf ("\n");
	}

	for (x=a-1; x>=1; x--)

	{
		for (z=1; z<=(a-x); z++)
			printf (" ");
		for (y=1; y<=x; y++)
			printf ("*");
		for (y=2; y<=x; y++)
			printf ("*");

		 printf ("\n");
	}

	return 0;
}
