#include <stdio.h> 

int main ()
{
	int c, first, last, center, n, search, array[100];
	printf ("Enter number of elements\n");
	scanf ("%d" ,&n);

	printf ("Enter %d number\n", n);

	for (c = 0; c < n; c++)
		scanf ("%d", &array[c]);

	printf ("Enter value to find\n");
	scanf ("%d", &search);

	first = 0;
	last = n - 1;
	center = (first+last)/2;

	while (first <= last) {
		if (array[center] < search)
		  first = center +1;
		else if (array[center] == search) {
		  printf ("%d found at location %d.\n", search, center+1);
		  break;
		}
		else
		  last = center - 1;

		center = (first + last)/2;
	}
	if (first > last)
	    printf ("Not found! %d number isn't present in the list.\n", search);

	return 0;

}
