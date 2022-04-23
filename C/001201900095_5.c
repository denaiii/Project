#include<stdio.h>
#define students 5
#define exams 3

	int min(const int [][ exams ],int,int);
	int max(const int [][ exams ],int,int);
	double avg(const int [],int);
	void printArray(const int [] [ exams ], int,int);

int main()
{
    const int studentGrades[ students ][ exams ];
	int student=0;
	
	for (;;) {
        printf("\nStudent no. %d\n", student + 1);

        printf("Assignment: ");
        scanf("%d", &studentGrades[ student ][0]);

        if (feof(stdin)) {
            break;
        }

        printf("Mid: ");
        scanf("%d", &studentGrades[ student ][1]);

        printf("Final: ");
        scanf("%d", &studentGrades[ student ][2]);

        student++;
    }
	printf("The Array is:\n");
	printArray(studentGrades, students, exams);
	printf("\n\nLowest grade: %d\nHighest grade: %d\n",
		min(studentGrades, students, exams),
		max(studentGrades, students, exams));
	for (student=0; student <= students-1;student++)
		printf("The average grade for student %d is %.2f\n",
		student,
		avg(studentGrades[ student ], exams));

	return 0;
}
int min(const int grades[][ exams ],
		int pupils, int tests)
{
	int i,j, lowGrade =100;

	for(i=0; i<=pupils-1;i++)
		for(j=0; j<= tests -1; j++)
			if (grades [i][j]<lowGrade)
				lowGrade= grades[i][j];
	return lowGrade;
}
int max(const int grades[][ exams ],int pupils, int tests)
{
	int i,j,highGrade=0;

	for (i=0; i<= pupils-1; i++)
		for(j=0; j<= tests-1;j++)
			if (grades[i][j]>highGrade)
				highGrade = grades[i][j];
	return highGrade;
}
double avg(const int setOfGrades[], int tests)
{
	int i, total =0;

			for(i=0; i <=tests-1; i++)
			total += setOfGrades[i];

	return (double) total/tests;
}
void printArray(const int grades[][ exams ],
		int pupils, int tests)
{
	int i,j;

	printf("	[assignment]	[mid]	[final]	");
		for (i = 0; i <= pupils-1; i++ ){
		printf("\nstudentGrades[%d]",i);

		for(j=0; j<= tests -1; j++)
		printf("%-5d", grades[i][j]);
	}
}
